<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnGo = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.fldInfo = New System.Windows.Forms.RichTextBox
        Me.cmTxtBox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCMCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCMCut = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCMPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.chkSaveToFile = New System.Windows.Forms.CheckBox
        Me.chkIPEnabled = New System.Windows.Forms.CheckBox
        Me.chkExtended = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.fldHostname = New System.Windows.Forms.TextBox
        Me.fldComment = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkGetExternalInfo = New System.Windows.Forms.CheckBox
        Me.btnOpenFolder = New System.Windows.Forms.Button
        Me.cmTxtBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.Image = Global.GetNetworkInfo.My.Resources.Resources.lightning
        Me.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGo.Location = New System.Drawing.Point(534, 383)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(451, 383)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'fldInfo
        '
        Me.fldInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fldInfo.BackColor = System.Drawing.Color.OldLace
        Me.fldInfo.ContextMenuStrip = Me.cmTxtBox
        Me.fldInfo.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldInfo.Location = New System.Drawing.Point(12, 75)
        Me.fldInfo.Name = "fldInfo"
        Me.fldInfo.ReadOnly = True
        Me.fldInfo.Size = New System.Drawing.Size(597, 292)
        Me.fldInfo.TabIndex = 2
        Me.fldInfo.Text = ""
        '
        'cmTxtBox
        '
        Me.cmTxtBox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCMCopy, Me.mnuCMCut, Me.mnuCMPaste})
        Me.cmTxtBox.Name = "cmTextBox"
        Me.cmTxtBox.Size = New System.Drawing.Size(113, 70)
        '
        'mnuCMCopy
        '
        Me.mnuCMCopy.Image = Global.GetNetworkInfo.My.Resources.Resources.copy
        Me.mnuCMCopy.Name = "mnuCMCopy"
        Me.mnuCMCopy.Size = New System.Drawing.Size(112, 22)
        Me.mnuCMCopy.Text = "Copy"
        '
        'mnuCMCut
        '
        Me.mnuCMCut.Image = Global.GetNetworkInfo.My.Resources.Resources.cut
        Me.mnuCMCut.Name = "mnuCMCut"
        Me.mnuCMCut.Size = New System.Drawing.Size(112, 22)
        Me.mnuCMCut.Text = "Cut"
        '
        'mnuCMPaste
        '
        Me.mnuCMPaste.Image = Global.GetNetworkInfo.My.Resources.Resources.paste
        Me.mnuCMPaste.Name = "mnuCMPaste"
        Me.mnuCMPaste.Size = New System.Drawing.Size(112, 22)
        Me.mnuCMPaste.Text = "Paste"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(621, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(114, 22)
        Me.mnuAbout.Text = "About"
        '
        'chkSaveToFile
        '
        Me.chkSaveToFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSaveToFile.AutoSize = True
        Me.chkSaveToFile.Location = New System.Drawing.Point(8, 16)
        Me.chkSaveToFile.Name = "chkSaveToFile"
        Me.chkSaveToFile.Size = New System.Drawing.Size(79, 17)
        Me.chkSaveToFile.TabIndex = 4
        Me.chkSaveToFile.Text = "Save to file"
        Me.chkSaveToFile.UseVisualStyleBackColor = True
        '
        'chkIPEnabled
        '
        Me.chkIPEnabled.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIPEnabled.AutoSize = True
        Me.chkIPEnabled.Location = New System.Drawing.Point(6, 16)
        Me.chkIPEnabled.Name = "chkIPEnabled"
        Me.chkIPEnabled.Size = New System.Drawing.Size(101, 17)
        Me.chkIPEnabled.TabIndex = 5
        Me.chkIPEnabled.Text = "Only IP enabled"
        Me.chkIPEnabled.UseVisualStyleBackColor = True
        '
        'chkExtended
        '
        Me.chkExtended.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkExtended.AutoSize = True
        Me.chkExtended.Location = New System.Drawing.Point(6, 39)
        Me.chkExtended.Name = "chkExtended"
        Me.chkExtended.Size = New System.Drawing.Size(110, 17)
        Me.chkExtended.TabIndex = 6
        Me.chkExtended.Text = "Get extended info"
        Me.chkExtended.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hostname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Comment:"
        '
        'fldHostname
        '
        Me.fldHostname.BackColor = System.Drawing.SystemColors.Window
        Me.fldHostname.Location = New System.Drawing.Point(76, 23)
        Me.fldHostname.Name = "fldHostname"
        Me.fldHostname.Size = New System.Drawing.Size(533, 20)
        Me.fldHostname.TabIndex = 9
        '
        'fldComment
        '
        Me.fldComment.BackColor = System.Drawing.SystemColors.Window
        Me.fldComment.Location = New System.Drawing.Point(76, 49)
        Me.fldComment.Name = "fldComment"
        Me.fldComment.Size = New System.Drawing.Size(533, 20)
        Me.fldComment.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkIPEnabled)
        Me.GroupBox1.Controls.Add(Me.chkExtended)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 373)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 62)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interfaces"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chkGetExternalInfo)
        Me.GroupBox2.Controls.Add(Me.chkSaveToFile)
        Me.GroupBox2.Location = New System.Drawing.Point(150, 373)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 62)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Advanced"
        '
        'chkGetExternalInfo
        '
        Me.chkGetExternalInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkGetExternalInfo.AutoSize = True
        Me.chkGetExternalInfo.Location = New System.Drawing.Point(8, 39)
        Me.chkGetExternalInfo.Name = "chkGetExternalInfo"
        Me.chkGetExternalInfo.Size = New System.Drawing.Size(103, 17)
        Me.chkGetExternalInfo.TabIndex = 5
        Me.chkGetExternalInfo.Text = "Get external info"
        Me.chkGetExternalInfo.UseVisualStyleBackColor = True
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFolder.Image = Global.GetNetworkInfo.My.Resources.Resources.folder_star
        Me.btnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpenFolder.Location = New System.Drawing.Point(451, 412)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(158, 23)
        Me.btnOpenFolder.TabIndex = 17
        Me.btnOpenFolder.Text = "Open Folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 441)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnOpenFolder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fldComment)
        Me.Controls.Add(Me.fldHostname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fldInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClear)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "GetNetworkInfo"
        Me.cmTxtBox.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents fldInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkSaveToFile As System.Windows.Forms.CheckBox
    Friend WithEvents chkIPEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents cmTxtBox As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuCMCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkExtended As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fldHostname As System.Windows.Forms.TextBox
    Friend WithEvents fldComment As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkGetExternalInfo As System.Windows.Forms.CheckBox
    Friend WithEvents btnOpenFolder As System.Windows.Forms.Button

End Class
