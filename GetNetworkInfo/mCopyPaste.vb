Module mCopyPaste

    Public ReadOnly CLIPBOARD_ERROR_MESSAGE As String = "Clipboard operation unsuccessful." + _
    Environment.NewLine + "Please try using the equivelant keyboard shortcut:" + Environment.NewLine + _
    "Cut: Ctrl+X" + Environment.NewLine + "Copy: Ctrl+C" + Environment.NewLine + "Paste: Ctrl+V"


    Public Function EnableCut(ByRef c As Control) As Boolean
        Dim r As Boolean = True

        If TypeOf c Is TextBox Then
            If CType(c, TextBox).ReadOnly Then
                r = False
            End If
        ElseIf TypeOf c Is RichTextBox Then
            If CType(c, RichTextBox).ReadOnly Then
                r = False
            End If
        End If

        Return r
    End Function

    Public Function EnableCopy(ByRef c As Control) As Boolean
        Dim r As Boolean = True

        If TypeOf c Is TextBox Then
            If Not CType(c, TextBox).SelectionLength > 0 Then
                r = False
            End If
        ElseIf TypeOf c Is RichTextBox Then
            If Not CType(c, RichTextBox).SelectionLength > 0 Then
                r = False
            End If
        End If

        Return r
    End Function

    Public Function EnablePaste(ByRef c As Control) As Boolean
        Dim r As Boolean = True

        If TypeOf c Is TextBox Then
            If CType(c, TextBox).ReadOnly Then
                r = False
            End If
        ElseIf TypeOf c Is RichTextBox Then
            If CType(c, RichTextBox).ReadOnly Then
                r = False
            End If
        End If

        Return r
    End Function

    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '
    Public Sub MyCopy(ByRef c As Control)
        Try
            If TypeOf (c) Is TextBox Then
                If CType(c, TextBox).SelectionLength > 0 Then
                    Clipboard.SetDataObject(CType(c, TextBox).SelectedText, True)
                End If
            ElseIf TypeOf (c) Is RichTextBox Then
                'Clipboard.SetDataObject(CType(c, RichTextBox).SelectedText)
                If CType(c, RichTextBox).SelectionLength > 0 Then
                    Dim rtfText, plainText As String
                    Dim data As New DataObject()

                    rtfText = CType(c, RichTextBox).SelectedRtf
                    plainText = CType(c, RichTextBox).SelectedText
                    ' do the copy only if there is something to be copied
                    If plainText.Length > 0 Then data.SetData(DataFormats.Text, plainText)
                    If rtfText.Length > 0 Then data.SetData(DataFormats.Rtf, rtfText)
                    ' finally copy into the clipboard
                    Clipboard.SetDataObject(data, True)
                End If
            End If

        Catch
            MsgBox(CLIPBOARD_ERROR_MESSAGE, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Public Sub MyPaste(ByRef c As Control)
        'Retrieve data from clipboard and place it in text box
        Try
            If TypeOf (c) Is TextBox Then
                Dim oDataObject As IDataObject
                If CType(c, TextBox).ReadOnly Then Exit Sub
                oDataObject = Clipboard.GetDataObject()
                If oDataObject.GetDataPresent(DataFormats.Text) Then
                    CType(c, TextBox).SelectedText = CType(oDataObject.GetData(DataFormats.Text), String)
                End If
            ElseIf TypeOf (c) Is RichTextBox Then
                Dim oDataObject As IDataObject
                If CType(c, RichTextBox).ReadOnly Then Exit Sub
                oDataObject = Clipboard.GetDataObject()
                If oDataObject.GetDataPresent(DataFormats.Text) Then
                    CType(c, RichTextBox).SelectedText = CType(oDataObject.GetData(DataFormats.Text), String)
                End If
            End If
        Catch
            MsgBox(CLIPBOARD_ERROR_MESSAGE, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Public Sub MyCut(ByRef c As Control)
        Try
            If TypeOf (c) Is TextBox Then
                If CType(c, TextBox).ReadOnly Then Exit Sub
                Clipboard.SetDataObject(CType(c, TextBox).SelectedText, True)
                CType(c, TextBox).SelectedText = ""
            ElseIf TypeOf (c) Is RichTextBox Then
                If CType(c, RichTextBox).ReadOnly Then Exit Sub
                If CType(c, RichTextBox).SelectionLength > 0 Then
                    Dim rtfText, plainText As String
                    Dim data As New DataObject()

                    rtfText = CType(c, RichTextBox).SelectedRtf
                    plainText = CType(c, RichTextBox).SelectedText
                    ' do the copy only if there is something to be copied
                    If plainText.Length > 0 Then data.SetData(DataFormats.Text, plainText)
                    If rtfText.Length > 0 Then data.SetData(DataFormats.Rtf, rtfText)
                    ' finally copy into the clipboard
                    Clipboard.SetDataObject(data, True)
                End If

                CType(c, RichTextBox).SelectedText = ""
            End If
        Catch
            MsgBox(CLIPBOARD_ERROR_MESSAGE, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Module
