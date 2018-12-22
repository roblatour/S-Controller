<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.rtbAbout = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblProgramNameAndVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtbAbout
        '
        Me.rtbAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbAbout.Location = New System.Drawing.Point(12, 49)
        Me.rtbAbout.Name = "rtbAbout"
        Me.rtbAbout.ReadOnly = True
        Me.rtbAbout.Size = New System.Drawing.Size(544, 230)
        Me.rtbAbout.TabIndex = 0
        Me.rtbAbout.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(464, 288)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(92, 41)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblProgramNameAndVersion
        '
        Me.lblProgramNameAndVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProgramNameAndVersion.AutoSize = True
        Me.lblProgramNameAndVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramNameAndVersion.Location = New System.Drawing.Point(12, 9)
        Me.lblProgramNameAndVersion.Name = "lblProgramNameAndVersion"
        Me.lblProgramNameAndVersion.Size = New System.Drawing.Size(163, 24)
        Me.lblProgramNameAndVersion.TabIndex = 1
        Me.lblProgramNameAndVersion.Text = "S-Controller v1.0.0"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 341)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblProgramNameAndVersion)
        Me.Controls.Add(Me.rtbAbout)
        Me.MinimumSize = New System.Drawing.Size(590, 380)
        Me.Name = "frmAbout"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "frmAbout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbAbout As RichTextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents lblProgramNameAndVersion As Label
End Class
