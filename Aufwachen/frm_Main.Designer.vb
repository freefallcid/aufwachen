<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.txt_mac = New System.Windows.Forms.MaskedTextBox()
        Me.btn_wake = New System.Windows.Forms.Button()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_defined_1 = New System.Windows.Forms.Button()
        Me.btn_defined_2 = New System.Windows.Forms.Button()
        Me.btn_defined_3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_mac
        '
        Me.txt_mac.Location = New System.Drawing.Point(12, 12)
        Me.txt_mac.Mask = "AA:AA:AA:AA:AA:AA"
        Me.txt_mac.Name = "txt_mac"
        Me.txt_mac.Size = New System.Drawing.Size(331, 20)
        Me.txt_mac.TabIndex = 0
        '
        'btn_wake
        '
        Me.btn_wake.Location = New System.Drawing.Point(196, 38)
        Me.btn_wake.Name = "btn_wake"
        Me.btn_wake.Size = New System.Drawing.Size(147, 33)
        Me.btn_wake.TabIndex = 1
        Me.btn_wake.Text = "AUFWECKEN"
        Me.btn_wake.UseVisualStyleBackColor = True
        '
        'btn_help
        '
        Me.btn_help.Location = New System.Drawing.Point(196, 77)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(147, 33)
        Me.btn_help.TabIndex = 2
        Me.btn_help.Text = "HILFE"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(196, 116)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(147, 33)
        Me.btn_end.TabIndex = 3
        Me.btn_end.Text = "ENDE"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_defined_1
        '
        Me.btn_defined_1.Location = New System.Drawing.Point(12, 38)
        Me.btn_defined_1.Name = "btn_defined_1"
        Me.btn_defined_1.Size = New System.Drawing.Size(147, 33)
        Me.btn_defined_1.TabIndex = 4
        Me.btn_defined_1.Text = "&BÜRO"
        Me.btn_defined_1.UseVisualStyleBackColor = True
        '
        'btn_defined_2
        '
        Me.btn_defined_2.Location = New System.Drawing.Point(12, 77)
        Me.btn_defined_2.Name = "btn_defined_2"
        Me.btn_defined_2.Size = New System.Drawing.Size(147, 33)
        Me.btn_defined_2.TabIndex = 5
        Me.btn_defined_2.Text = "&DESKTOP-IM5196M"
        Me.btn_defined_2.UseVisualStyleBackColor = True
        '
        'btn_defined_3
        '
        Me.btn_defined_3.Location = New System.Drawing.Point(12, 116)
        Me.btn_defined_3.Name = "btn_defined_3"
        Me.btn_defined_3.Size = New System.Drawing.Size(147, 33)
        Me.btn_defined_3.TabIndex = 6
        Me.btn_defined_3.Text = "D&ANIELR"
        Me.btn_defined_3.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 163)
        Me.Controls.Add(Me.btn_defined_3)
        Me.Controls.Add(Me.btn_defined_2)
        Me.Controls.Add(Me.btn_defined_1)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.btn_wake)
        Me.Controls.Add(Me.txt_mac)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aufwachen - Wake On LAN Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_mac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_wake As System.Windows.Forms.Button
    Friend WithEvents btn_help As System.Windows.Forms.Button
    Friend WithEvents btn_end As System.Windows.Forms.Button
    Friend WithEvents btn_defined_1 As System.Windows.Forms.Button
    Friend WithEvents btn_defined_2 As System.Windows.Forms.Button
    Friend WithEvents btn_defined_3 As System.Windows.Forms.Button

End Class
