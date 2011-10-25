<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.btnOK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.tpChangelog = New System.Windows.Forms.TabPage
        Me.fldChange = New System.Windows.Forms.TextBox
        Me.tpNotes = New System.Windows.Forms.TabPage
        Me.fldNotes = New System.Windows.Forms.TextBox
        Me.tpAcknowledgements = New System.Windows.Forms.TabPage
        Me.fldAck = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tpChangelog.SuspendLayout()
        Me.tpNotes.SuspendLayout()
        Me.tpAcknowledgements.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(269, 259)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(71, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.tpChangelog)
        Me.TabControl1.Controls.Add(Me.tpNotes)
        Me.TabControl1.Controls.Add(Me.tpAcknowledgements)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(352, 253)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCopyright)
        Me.TabPage1.Controls.Add(Me.lblVersion)
        Me.TabPage1.Controls.Add(Me.lblName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(344, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Info"
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCopyright.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCopyright.Location = New System.Drawing.Point(0, 124)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(352, 20)
        Me.lblCopyright.TabIndex = 0
        Me.lblCopyright.Text = "Copyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.Location = New System.Drawing.Point(0, 104)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(352, 20)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(0, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(352, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tpChangelog
        '
        Me.tpChangelog.Controls.Add(Me.fldChange)
        Me.tpChangelog.Location = New System.Drawing.Point(4, 22)
        Me.tpChangelog.Name = "tpChangelog"
        Me.tpChangelog.Size = New System.Drawing.Size(344, 227)
        Me.tpChangelog.TabIndex = 1
        Me.tpChangelog.Text = "Changelog"
        '
        'fldChange
        '
        Me.fldChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fldChange.Location = New System.Drawing.Point(0, 0)
        Me.fldChange.Multiline = True
        Me.fldChange.Name = "fldChange"
        Me.fldChange.ReadOnly = True
        Me.fldChange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fldChange.Size = New System.Drawing.Size(344, 227)
        Me.fldChange.TabIndex = 0
        '
        'tpNotes
        '
        Me.tpNotes.Controls.Add(Me.fldNotes)
        Me.tpNotes.Location = New System.Drawing.Point(4, 22)
        Me.tpNotes.Name = "tpNotes"
        Me.tpNotes.Size = New System.Drawing.Size(344, 227)
        Me.tpNotes.TabIndex = 2
        Me.tpNotes.Text = "Notes"
        '
        'fldNotes
        '
        Me.fldNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fldNotes.Location = New System.Drawing.Point(0, 0)
        Me.fldNotes.Multiline = True
        Me.fldNotes.Name = "fldNotes"
        Me.fldNotes.ReadOnly = True
        Me.fldNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fldNotes.Size = New System.Drawing.Size(344, 227)
        Me.fldNotes.TabIndex = 1
        '
        'tpAcknowledgements
        '
        Me.tpAcknowledgements.Controls.Add(Me.fldAck)
        Me.tpAcknowledgements.Location = New System.Drawing.Point(4, 22)
        Me.tpAcknowledgements.Name = "tpAcknowledgements"
        Me.tpAcknowledgements.Size = New System.Drawing.Size(344, 227)
        Me.tpAcknowledgements.TabIndex = 3
        Me.tpAcknowledgements.Text = "Acknowledgements"
        '
        'fldAck
        '
        Me.fldAck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fldAck.Location = New System.Drawing.Point(0, 0)
        Me.fldAck.Multiline = True
        Me.fldAck.Name = "fldAck"
        Me.fldAck.ReadOnly = True
        Me.fldAck.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fldAck.Size = New System.Drawing.Size(344, 227)
        Me.fldAck.TabIndex = 2
        '
        'frmAbout
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(352, 294)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tpChangelog.ResumeLayout(False)
        Me.tpChangelog.PerformLayout()
        Me.tpNotes.ResumeLayout(False)
        Me.tpNotes.PerformLayout()
        Me.tpAcknowledgements.ResumeLayout(False)
        Me.tpAcknowledgements.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents tpChangelog As System.Windows.Forms.TabPage
    Friend WithEvents fldChange As System.Windows.Forms.TextBox
    Friend WithEvents tpNotes As System.Windows.Forms.TabPage
    Friend WithEvents fldNotes As System.Windows.Forms.TextBox
    Friend WithEvents tpAcknowledgements As System.Windows.Forms.TabPage
    Friend WithEvents fldAck As System.Windows.Forms.TextBox
End Class
