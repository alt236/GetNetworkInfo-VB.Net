Imports System.Management
Imports System.Net
Imports System.IO

Module Module1
    Public Const TITLE_IPX As String = "  IPX"
    Public Const TITLE_IPSEC As String = "  IPSec"
    Public Const TITLE_DNS As String = "  DNS"
    Public Const TITLE_IP As String = "  IP"
    Public Const TITLE_DHCP As String = "  DHCP"
    Public Const TITLE_WINS As String = "  WINS"
    Public Const TITLE_GW As String = "  Gateway"
    Public Const TITLE_EXTENDED As String = "  Extended Info"

    Public Const SECTION_TITLE_LENGTH As Integer = 34
    Public Const ITEM_TITLE_LENGTH As Integer = 34
    Public Const MAX_LINE_LENGTH As Integer = 80

    'Try
    '    For Each prop As PropertyData In mo.Properties
    '        result += prop.Name & Environment.NewLine
    '    Next
    'Catch
    '    result += "Error extracting property names"
    'End Try


    'ArpAlwaysSourceRoute
    'ArpUseEtherSNAP
    'Caption * 
    'DatabasePath
    'DeadGWDetectEnabled
    'DefaultIPGateway
    'DefaultTOS
    'DefaultTTL
    'Description *
    'DHCPEnabled *
    'DHCPLeaseExpires *
    'DHCPLeaseObtained *
    'DHCPServer *
    'DNSDomain *
    'DNSDomainSuffixSearchOrder
    'DNSEnabledForWINSResolution
    'DNSHostName *
    'DNSServerSearchOrder *
    'DomainDNSRegistrationEnabled
    'ForwardBufferMemory
    'FullDNSRegistrationEnabled
    'GatewayCostMetric
    'IGMPLevel
    'Index
    'InterfaceIndex
    'IPAddress *
    'IPConnectionMetric
    'IPEnabled *
    'IPFilterSecurityEnabled
    'IPPortSecurityEnabled
    'IPSecPermitIPProtocols
    'IPSecPermitTCPPorts
    'IPSecPermitUDPPorts
    'IPSubnet *
    'IPUseZeroBroadcast
    'IPXAddress
    'IPXEnabled
    'IPXFrameType
    'IPXMediaType
    'IPXNetworkNumber
    'IPXVirtualNetNumber
    'KeepAliveInterval
    'KeepAliveTime
    'MACAddress
    'MTU
    'NumForwardPackets
    'PMTUBHDetectEnabled
    'PMTUDiscoveryEnabled
    'ServiceName
    'SettingID
    'TcpipNetbiosOptions
    'TcpMaxConnectRetransmissions
    'TcpMaxDataRetransmissions
    'TcpNumConnections
    'TcpUseRFC1122UrgentPointer
    'TcpWindowSize
    'WINSEnableLMHostsLookup
    'WINSHostLookupFile
    'WINSPrimaryServer
    'WINSScopeID
    'WINSSecondaryServer

    Public Function GetManagementObjectInfo(ByRef m As ManagementObject, ByVal Attribute As String, ByVal Title As String, Optional ByVal AddNL As Boolean = False) As String
        Dim res As String = ""
        Try
            Dim stmp As String = GetAttribute(m, Attribute)

            If Trim(stmp).Length > 0 Then
                res += FormatLine(Title, stmp)

                If res.Length > 0 And AddNL Then
                    res += Environment.NewLine
                End If
            End If
        Catch
            res = FormatLine(Title, "!! Error: GetManagementObjectInfo(): " & Err.Description)
        End Try
        Return res
    End Function

    Public Function GetAttribute(ByRef m As ManagementObject, ByVal Attribute As String, Optional ByVal Type As String = "String") As String
        Dim res As String = ""
        Try
            If Not m(Attribute) Is Nothing Then
                res = m(Attribute).ToString()
            End If
        Catch
            res = "Error"
        End Try
        Return res
    End Function


    Public Function GetManagementObjectInfoArray(ByRef m As ManagementObject, ByVal Attribute As String, ByVal Title As String, Optional ByVal AddNL As Boolean = False) As String
        Dim res As String = ""

        Try
            If Not m(Attribute) Is Nothing Then

                Dim flag As Boolean = False

                Console.WriteLine(m(Attribute).GetType)

                Select Case m(Attribute).GetType.ToString
                    Case "System.UInt16[]"
                        Dim arrItems As UInt16()
                        arrItems = CType(m(Attribute), UInt16())

                        For Each arrI As UInt16 In arrItems
                            If Trim(CStr(arrI)).Length > 0 Then
                                flag = True
                                res += FormatLine(Title, CStr(arrI))
                            End If
                        Next

                    Case "System.String[]"
                        Dim arrItems As String()
                        arrItems = CType(m(Attribute), String())

                        For Each arrI As String In arrItems
                            If Trim(arrI).Length > 0 Then
                                flag = True
                                res += FormatLine(Title, arrI)
                            End If
                        Next
                    Case Else
                        res = FormatLine(Title, "!! Error: GetManagementObjectInfoArray(): Unknown type in case statement (" & m(Attribute).GetType.ToString & ")")
                        Return res
                End Select

                If res.Length > 0 And AddNL And flag Then
                    res += Environment.NewLine
                End If
            End If
        Catch
            res = FormatLine(Title, "!! Error: GetManagementObjectInfoArray(): " & Err.Description)
        End Try
        Return res
    End Function

    Public Function FormatLine(ByVal Title As String, ByVal Data As String) As String
        Dim res As String = ""
        'Dim retData As String = ""
        Dim stmp As String = ""

        Dim bflag As Boolean = True
        Dim iLength As Integer = MAX_LINE_LENGTH - ITEM_TITLE_LENGTH

        res = AfterPad("  · " & Title & ": ", ITEM_TITLE_LENGTH, CChar(" "))

        stmp = Data
        While bflag
            If stmp.Length > iLength Then

                If stmp.Length = Data.Length Then
                    res += stmp.Substring(0, iLength)
                Else
                    res += AfterPad("", ITEM_TITLE_LENGTH, CChar(" ")) & stmp.Substring(0, iLength)
                End If

                stmp = stmp.Substring(iLength)

            Else
                bflag = False


                If stmp.Length = Data.Length Then
                    res += stmp
                Else
                    res += AfterPad("", ITEM_TITLE_LENGTH, CChar(" ")) & stmp
                End If
            End If
            res += Environment.NewLine
        End While

        If res.Length <= 0 Then
            res = stmp
        End If

        Return res
    End Function

    Public Function AfterPad(ByVal Str As String, ByVal DesiredLength As Integer, ByVal PaddingChar As Char) As String
        Dim res As String = Str

        If res.Length < DesiredLength Then

            While res.Length < DesiredLength
                res += PaddingChar
            End While
        End If

        Return res
    End Function

    Function GetPage(ByVal pageUrl As String) As String
        Dim s As String = ""
        Try
            Dim request As WebRequest = WebRequest.Create(pageUrl)
            Dim response As WebResponse = request.GetResponse()

            Using reader As StreamReader = New StreamReader(response.GetResponseStream())
                s = reader.ReadToEnd()
            End Using
        Catch ex As Exception
            s = Err.Description
        End Try
        Return s
    End Function

    Function GetPage2(ByVal pageUrl As String) As String
        Dim s As String = ""
        Dim userAgent As String = ""

        Try
            userAgent = System.Reflection.Assembly.GetExecutingAssembly().FullName
        Catch
            userAgent = ""
        End Try

        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create(pageUrl), HttpWebRequest)
            request.UserAgent = userAgent
            Dim response As WebResponse = request.GetResponse()

            Using reader As StreamReader = New StreamReader(response.GetResponseStream())
                s = reader.ReadToEnd()
            End Using
        Catch ex As Exception
            s = Err.Description
        End Try
        Return s
    End Function
End Module
