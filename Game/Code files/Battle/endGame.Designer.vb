<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class endGame
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
        Me.bagain = New System.Windows.Forms.Button()
        Me.bexit = New System.Windows.Forms.Button()
        Me.lstats = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bagain
        '
        Me.bagain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bagain.Location = New System.Drawing.Point(190, 276)
        Me.bagain.Name = "bagain"
        Me.bagain.Size = New System.Drawing.Size(129, 53)
        Me.bagain.TabIndex = 0
        Me.bagain.Text = "Play again"
        Me.bagain.UseVisualStyleBackColor = True
        '
        'bexit
        '
        Me.bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bexit.Location = New System.Drawing.Point(190, 370)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(129, 53)
        Me.bexit.TabIndex = 0
        Me.bexit.Text = "Exit"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'lstats
        '
        Me.lstats.AutoSize = True
        Me.lstats.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstats.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lstats.Location = New System.Drawing.Point(182, 78)
        Me.lstats.Name = "lstats"
        Me.lstats.Size = New System.Drawing.Size(140, 44)
        Me.lstats.TabIndex = 1
        Me.lstats.Text = "Label1"
        Me.lstats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'endGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(520, 516)
        Me.Controls.Add(Me.lstats)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.bagain)
        Me.Name = "endGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "endGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bagain As System.Windows.Forms.Button
    Friend WithEvents bexit As System.Windows.Forms.Button
    Friend WithEvents lstats As System.Windows.Forms.Label
End Class
