Imports System.Management

Public Class clsWin32_NetworkAdapterConfiguration
    Private mExternalInfo As Boolean = False
    Private mExtendedInformation As Boolean = False
    Private mIpEnabledOnly As Boolean = False
    Private mOwnHostname As String = ""

    Public Sub New(ByVal ownHostname As String, ByVal ipEnabledOnly As Boolean, ByVal extendedInformation As Boolean, ByVal externalInfo As Boolean)
        mExternalInfo = externalInfo
        mIpEnabledOnly = ipEnabledOnly
        mExtendedInformation = extendedInformation
        mOwnHostname = ownHostname
    End Sub

    Public Function GetNetInfo(ByVal sHostname As String, ByVal sComment As String, ByVal timeStamp As Date) As String
        Dim result As String = ""

        sHostname = Trim(sHostname)
        sComment = Trim(sComment)

        Try
            Dim strMACAddress As String = ""
            Dim strIP As String = ""
            Dim strQuery As String = ""
            Dim InterfaceIndex As String = ""
            Dim ms As ManagementScope
            Dim query As ManagementObjectSearcher
            Dim queryCollection As ManagementObjectCollection

            result += "Hostname: " & ControlChars.Tab & sHostname & Environment.NewLine
            result += "Timestamp: " & ControlChars.Tab & CStr(timeStamp) + Environment.NewLine + Environment.NewLine
            result += "Comment: " & ControlChars.Tab & sComment + Environment.NewLine + Environment.NewLine

            If mExternalInfo Then
                result += DisplayExternalData(mOwnHostname, sHostname)
            End If

            Dim myConnectionOptions As New System.Management.ConnectionOptions
            With myConnectionOptions
                .Impersonation = System.Management.ImpersonationLevel.Impersonate
                '* Use next line for XP
                .Authentication = System.Management.AuthenticationLevel.Packet
                '* Use next line for Win prior XP
                '*.Authentication = System.Management.AuthenticationLevel.Connect
            End With

            ms = New ManagementScope("\\" & sHostname & "\root\cimv2", myConnectionOptions)
            ms.Connect()

            If ms.IsConnected = False Then
                result += "Error: Could not connect to WMI namespace"
            Else

                If mIpEnabledOnly Then
                    strQuery = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True"
                Else
                    strQuery = "SELECT * FROM Win32_NetworkAdapterConfiguration"
                End If

                query = New ManagementObjectSearcher(strQuery)
                query.Scope = ms

                queryCollection = query.Get()

                For Each mo As ManagementObject In queryCollection
                    InterfaceIndex = GetAttribute(mo, "Index")
                    result += AfterPad("Interface " & InterfaceIndex, MAX_LINE_LENGTH, CChar("_")) & Environment.NewLine

                    result += GetManagementObjectInfo(mo, "Description", "Description")
                    result += GetManagementObjectInfo(mo, "ServiceName", "ServiceName")
                    result += GetManagementObjectInfo(mo, "MacAddress", "Mac Address")
                    result += Environment.NewLine

                    result += DisplayIP(mo)
                    result += DisplayDHCP(mo)
                    result += DisplayDNS(mo)

                    result += GetManagementObjectInfoArray(mo, "DefaultIPGateway", "Default Gateway", True)


                    If mExtendedInformation Then
                        result += DisplayExtended(mo)
                    End If
                Next
                result += AfterPad("", MAX_LINE_LENGTH, CChar("~"))
            End If
        Catch
            result += Environment.NewLine & "! GetNetInfo() error: " & Err.Description
        End Try
        Return result
    End Function

    ' ---------------------------------------------------------------------------
    Private Function DisplayIP(ByRef m As ManagementObject) As String
        Dim res As String = ""

        If Not mIpEnabledOnly Then
            res += GetManagementObjectInfo(m, "IPEnabled", "IP Enabled")
        End If

        If Not (m("IPSubnet") Is Nothing And m("IPAddress") Is Nothing) Then
            Dim arrIPSubnet As String()
            Dim arrIPAddr As String()
            Dim sTmp As String = ""

            arrIPSubnet = CType(m("IPSubnet"), String())
            arrIPAddr = CType(m("IPAddress"), String())


            For Each arrSub As String In arrIPSubnet
                For Each arrIP As String In arrIPAddr
                    If Trim(arrSub).Length > 0 Then
                        sTmp += FormatLine("IPAddress", arrIP & " / " & arrSub)
                    End If
                Next
            Next

            If Trim(sTmp).Length > 0 Then
                res = AfterPad(TITLE_IP, ITEM_TITLE_LENGTH, CChar("_")) & Environment.NewLine & sTmp & Environment.NewLine
            End If
        End If

        Return res
    End Function


    Private Function DisplayExtended(ByVal m As ManagementObject) As String
        Dim res As String = ""

        res += DisplayIPSEC(m)
        res += DisplayIPX(m)
        res += DisplayWINS(m)


        res += GetManagementObjectInfo(m, "ArpAlwaysSourceRoute", "ArpAlwaysSourceRoute")
        res += GetManagementObjectInfo(m, "ArpUseEtherSNAP", "ArpUseEtherSNAP")
        res += GetManagementObjectInfo(m, "DatabasePath", "DatabasePath")
        res += GetManagementObjectInfo(m, "DeadGWDetectEnabled", "DeadGWDetectEnabled")
        res += GetManagementObjectInfo(m, "DefaultTOS", "DefaultTOS")
        res += GetManagementObjectInfo(m, "DefaultTTL", "DefaultTTL")
        res += GetManagementObjectInfo(m, "DNSDomainSuffixSearchOrder", "DNSDomainSuffixSearchOrder")
        res += GetManagementObjectInfo(m, "DNSEnabledForWINSResolution", "DNSEnabledForWINSResolution")
        res += GetManagementObjectInfo(m, "DomainDNSRegistrationEnabled", "DomainDNSRegistrationEnabled")

        res += GetManagementObjectInfo(m, "ForwardBufferMemory", "ForwardBufferMemory")
        res += GetManagementObjectInfo(m, "FullDNSRegistrationEnabled", "FullDNSRegistrationEnabled")
        res += GetManagementObjectInfoArray(m, "GatewayCostMetric", "GatewayCostMetric")
        res += GetManagementObjectInfo(m, "IGMPLevel", "IGMPLevel")
        res += GetManagementObjectInfo(m, "Index", "Index")
        res += GetManagementObjectInfo(m, "InterfaceIndex", "InterfaceIndex")
        res += GetManagementObjectInfo(m, "IPConnectionMetric", "IPConnectionMetric")
        res += GetManagementObjectInfo(m, "IPFilterSecurityEnabled", "IPFilterSecurityEnabled")
        res += GetManagementObjectInfo(m, "DomainDNSRegistrationEnabled", "DomainDNSRegistrationEnabled")

        res += GetManagementObjectInfo(m, "IPPortSecurityEnabled", "IPPortSecurityEnabled")
        res += GetManagementObjectInfo(m, "IPUseZeroBroadcast", "IPUseZeroBroadcast")

        res += GetManagementObjectInfo(m, "KeepAliveInterval", "KeepAliveInterval")
        res += GetManagementObjectInfo(m, "KeepAliveTime", "KeepAliveTime")
        res += GetManagementObjectInfo(m, "MTU", "MTU")
        res += GetManagementObjectInfo(m, "NumForwardPackets", "NumForwardPackets")
        res += GetManagementObjectInfo(m, "PMTUBHDetectEnabled", "PMTUBHDetectEnabled")
        res += GetManagementObjectInfo(m, "PMTUDiscoveryEnabled", "PMTUDiscoveryEnabled")
        res += GetManagementObjectInfo(m, "SettingID", "SettingID")

        res += GetManagementObjectInfo(m, "TcpipNetbiosOptions", "TcpipNetbiosOptions")
        res += GetManagementObjectInfo(m, "TcpMaxConnectRetransmissions", "TcpMaxConnectRetransmissions")
        res += GetManagementObjectInfo(m, "TcpMaxDataRetransmissions", "TcpMaxDataRetransmissions")

        res += GetManagementObjectInfo(m, "TcpNumConnections", "TcpNumConnections")
        res += GetManagementObjectInfo(m, "TcpUseRFC1122UrgentPointer", "TcpUseRFC1122UrgentPointer")
        res += GetManagementObjectInfo(m, "TcpWindowSize", "TcpWindowSize")

        If Trim(res).Length > 0 Then
            res = AfterPad(TITLE_EXTENDED, ITEM_TITLE_LENGTH, CChar("_")) & Environment.NewLine & res & Environment.NewLine
        End If

        Return res
    End Function

    Private Function DisplayWINS(ByVal m As ManagementObject) As String
        Dim res As String = ""

        res += GetManagementObjectInfo(m, "WINSEnableLMHostsLookup", "WINSEnableLMHostsLookup")
        res += GetManagementObjectInfo(m, "WINSHostLookupFile", "WINSHostLookupFile")
        res += GetManagementObjectInfo(m, "WINSPrimaryServer", "WINSPrimaryServer")
        res += GetManagementObjectInfo(m, "WINSScopeID", "WINSScopeID")
        res += GetManagementObjectInfo(m, "WINSSecondaryServer", "WINSSecondaryServer")

        If Trim(res).Length > 0 Then
            res = AfterPad(TITLE_WINS, ITEM_TITLE_LENGTH, CChar("_")) & Environment.NewLine & res & Environment.NewLine
        End If

        Return res
    End Function

    Private Function DisplayExternalData(ByVal myHostname As String, ByVal checkedHostname As String) As String
        Dim result As String = AfterPad("External Information", MAX_LINE_LENGTH, CChar("_")) & Environment.NewLine
        If myHostname.Equals(checkedHostname) Then
            result += FormatLine("External IP", GetPage2(URL_EXT_IP))
            result += FormatLine("Ext. Hostname", GetPage2(URL_EXT_HOSTNAME))
        Else
            result += FormatLine("External IP", "Skipped as we are checking a remote system")
            result += FormatLine("Ext. Hostname", "Skipped as we are checking a remote system")
        End If
        Return result
    End Function

    Private Function DisplayIPSEC(ByRef m As ManagementObject) As String
        Dim res As String = ""

        res += GetManagementObjectInfoArray(m, "IPSecPermitIPProtocols", "IPSecPermitIPProtocols")
        res += GetManagementObjectInfoArray(m, "IPSecPermitTCPPorts", "IPSecPermitTCPPorts")
        res += GetManagementObjectInfoArray(m, "IPSecPermitUDPPorts", "IPSecPermitUDPPorts")

        If Trim(res).Length > 0 Then
            res = AfterPad(TITLE_IPSEC, ITEM_TITLE_LENGTH, CChar("_")) & Environment.NewLine & res & Environment.NewLine
        End If

        Return res
    End Function

    Private Function DisplayIPX(ByRef m As ManagementObject) As String
        Dim res As String = ""

        res += GetManagementObjectInfo(m, "IPXEnabled", "IPXEnabled")
        res += GetManagementObjectInfo(m, "IPXAddress", "IPXAddress")
        res += GetManagementObjectInfo(m, "IPXFrameType", "IPXFrameType")
        res += GetManagementObjectInfo(m, "IPXMediaType", "IPXMediaType")
        res += GetManagementObjectInfo(m, "IPXNetworkNumber", "IPXNetworkNumber")
        res += GetManagementObjectInfo(m, "IPXVirtualNetNumber", "IPXVirtualNetNumber")

        If Trim(res).Length > 0 Then
            res = AfterPad(TITLE_IPX, ITEM_TITLE_LENGTH, CChar("_")) & Environment.NewLine & res & Environment.NewLine
        End If

        Return res
    End Function

    Private Function DisplayDHCP(ByRef m As ManagementObject) As String
        Dim res As String = ""

        res += GetManagementObjectInfo(m, "DHCPEnabled", "DHCP Enabled")
        res += GetManagementObjectInfo(m, "DHCPServer", "DHCP Server")
        res += GetManagementObjectInfo(m, "DHCPLeaseObtained", "Lease Obtained")
        res += GetManagementObjectInfo(m, "DHCPLeaseExpires", "Lease Expires")

        If Trim(res).Length > 0 Then
            res = AfterPad(TITLE_DHCP, ITEM_TITLE_LENGTH, CChar("_")) & Environment.NewLine & res & Environment.NewLine
        End If
        Return res
    End Function

    Private Function DisplayDNS(ByVal m As ManagementObject) As String
        Dim res As String = ""

        res += GetManagementObjectInfo(m, "DNSHostName", "DNS HostName")
        res += GetManagementObjectInfo(m, "DNSDomain", "DNS Domain")
        res += GetManagementObjectInfoArray(m, "DNSServerSearchOrder", "DNS Server")

        If Trim(res).Length > 0 Then
            res = AfterPad(TITLE_DNS, ITEM_TITLE_LENGTH, CChar("_")) & Environment.NewLine & res & Environment.NewLine
        End If

        Return res
    End Function
End Class
