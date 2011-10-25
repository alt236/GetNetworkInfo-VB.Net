Imports System.Management

Public Class frmMain
    Private ownHostname As String

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.IconMain
        chkSaveToFile.Checked = True
        chkIPEnabled.Checked = True
        chkGetExternalInfo.Checked = True

        fldHostname.Text = Net.Dns.GetHostName()
        ownHostname = fldHostname.Text()
        fldInfo.Text = Trim(My.Resources.notes)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        fldComment.Text = ""
        fldHostname.Text = Trim(Net.Dns.GetHostName())
        ownHostname = fldHostname.Text()
        fldInfo.Text = ""
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Cursor.Current = Cursors.WaitCursor

        fldInfo.Text = ""
        fldInfo.Update()

        If Trim(fldHostname.Text).Length > 0 Then
            Dim timeStamp As Date = Now()

            Dim cNetworkAdapterConf As New clsWin32_NetworkAdapterConfiguration(ownHostname, chkIPEnabled.Checked, chkExtended.Checked, chkGetExternalInfo.Checked)

            fldInfo.Text += cNetworkAdapterConf.GetNetInfo(fldHostname.Text, fldComment.Text, timeStamp)

            If fldInfo.Text.Length > 0 And chkSaveToFile.Checked = True Then
                Dim path As String = Environment.CurrentDirectory & "/" & Net.Dns.GetHostName() & "_" & timeStamp.ToString("yyyyMMddHHmmsszz") & ".txt"
                Try
                    fldInfo.SaveFile(path, RichTextBoxStreamType.UnicodePlainText)
                Catch

                    MsgBox("Error writing to file." & Environment.NewLine & Environment.NewLine & _
                           "Filepath: " & path & Environment.NewLine & Environment.NewLine & _
                           "Error: " & Err.Description, MsgBoxStyle.Critical)
                End Try
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmTxtBox_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmTxtBox.Opening
        mnuCMCopy.Enabled = EnableCopy(cmTxtBox.SourceControl)
        mnuCMCut.Enabled = EnableCut(cmTxtBox.SourceControl)
        mnuCMPaste.Enabled = EnablePaste(cmTxtBox.SourceControl)
    End Sub

    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCMCopy.Click
        MyCopy(cmTxtBox.SourceControl)
    End Sub

    Private Sub mnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCMPaste.Click
        MyPaste(cmTxtBox.SourceControl)
    End Sub

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCMCut.Click
        MyCut(cmTxtBox.SourceControl)
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Dim f As New frmAbout
        f.ShowDialog()
    End Sub

    Private Sub btnOpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFolder.Click
        Process.Start("explorer.exe", Application.StartupPath)
    End Sub
End Class
