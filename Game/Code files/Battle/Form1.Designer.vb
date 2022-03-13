<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.batk = New System.Windows.Forms.Button()
        Me.bshield = New System.Windows.Forms.Button()
        Me.bsharp = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lhhealth = New System.Windows.Forms.Label()
        Me.lenergy = New System.Windows.Forms.Label()
        Me.lhshield = New System.Windows.Forms.Label()
        Me.lhattack = New System.Windows.Forms.Label()
        Me.lehealth = New System.Windows.Forms.Label()
        Me.leshield = New System.Windows.Forms.Label()
        Me.leattack = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.Timer(Me.components)
        Me.lturn = New System.Windows.Forms.Label()
        Me.laction = New System.Windows.Forms.Label()
        Me.bendturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'batk
        '
        Me.batk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.batk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batk.ForeColor = System.Drawing.Color.White
        Me.batk.Location = New System.Drawing.Point(208, 431)
        Me.batk.Name = "batk"
        Me.batk.Size = New System.Drawing.Size(96, 56)
        Me.batk.TabIndex = 0
        Me.batk.Text = "Attack(2)"
        Me.batk.UseVisualStyleBackColor = False
        '
        'bshield
        '
        Me.bshield.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bshield.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bshield.ForeColor = System.Drawing.Color.White
        Me.bshield.Location = New System.Drawing.Point(310, 431)
        Me.bshield.Name = "bshield"
        Me.bshield.Size = New System.Drawing.Size(96, 56)
        Me.bshield.TabIndex = 0
        Me.bshield.Text = "Shield(3)"
        Me.bshield.UseVisualStyleBackColor = False
        '
        'bsharp
        '
        Me.bsharp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bsharp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsharp.ForeColor = System.Drawing.Color.White
        Me.bsharp.Location = New System.Drawing.Point(412, 431)
        Me.bsharp.Name = "bsharp"
        Me.bsharp.Size = New System.Drawing.Size(96, 56)
        Me.bsharp.TabIndex = 0
        Me.bsharp.Text = "Sharpen(4)"
        Me.bsharp.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(138, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(258, 57)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Enemy"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lhhealth
        '
        Me.lhhealth.AutoSize = True
        Me.lhhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lhhealth.Location = New System.Drawing.Point(17, 414)
        Me.lhhealth.Name = "lhhealth"
        Me.lhhealth.Size = New System.Drawing.Size(64, 22)
        Me.lhhealth.TabIndex = 2
        Me.lhhealth.Text = "Label1"
        '
        'lenergy
        '
        Me.lenergy.AutoSize = True
        Me.lenergy.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lenergy.Location = New System.Drawing.Point(387, 382)
        Me.lenergy.Name = "lenergy"
        Me.lenergy.Size = New System.Drawing.Size(64, 22)
        Me.lenergy.TabIndex = 2
        Me.lenergy.Text = "Label1"
        '
        'lhshield
        '
        Me.lhshield.AutoSize = True
        Me.lhshield.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lhshield.Location = New System.Drawing.Point(17, 441)
        Me.lhshield.Name = "lhshield"
        Me.lhshield.Size = New System.Drawing.Size(64, 22)
        Me.lhshield.TabIndex = 2
        Me.lhshield.Text = "Label1"
        '
        'lhattack
        '
        Me.lhattack.AutoSize = True
        Me.lhattack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lhattack.Location = New System.Drawing.Point(17, 470)
        Me.lhattack.Name = "lhattack"
        Me.lhattack.Size = New System.Drawing.Size(64, 22)
        Me.lhattack.TabIndex = 2
        Me.lhattack.Text = "Label1"
        '
        'lehealth
        '
        Me.lehealth.AutoSize = True
        Me.lehealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lehealth.Location = New System.Drawing.Point(233, 21)
        Me.lehealth.Name = "lehealth"
        Me.lehealth.Size = New System.Drawing.Size(64, 22)
        Me.lehealth.TabIndex = 2
        Me.lehealth.Text = "Label1"
        '
        'leshield
        '
        Me.leshield.AutoSize = True
        Me.leshield.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leshield.Location = New System.Drawing.Point(408, 21)
        Me.leshield.Name = "leshield"
        Me.leshield.Size = New System.Drawing.Size(64, 22)
        Me.leshield.TabIndex = 2
        Me.leshield.Text = "Label1"
        '
        'leattack
        '
        Me.leattack.AutoSize = True
        Me.leattack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leattack.Location = New System.Drawing.Point(28, 21)
        Me.leattack.Name = "leattack"
        Me.leattack.Size = New System.Drawing.Size(64, 22)
        Me.leattack.TabIndex = 2
        Me.leattack.Text = "Label1"
        '
        't1
        '
        Me.t1.Interval = 500
        '
        'lturn
        '
        Me.lturn.AutoSize = True
        Me.lturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lturn.Location = New System.Drawing.Point(228, 302)
        Me.lturn.Name = "lturn"
        Me.lturn.Size = New System.Drawing.Size(64, 22)
        Me.lturn.TabIndex = 2
        Me.lturn.Text = "Label1"
        '
        'laction
        '
        Me.laction.AutoSize = True
        Me.laction.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laction.Location = New System.Drawing.Point(211, 192)
        Me.laction.Name = "laction"
        Me.laction.Size = New System.Drawing.Size(95, 31)
        Me.laction.TabIndex = 3
        Me.laction.Text = "Label1"
        Me.laction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bendturn
        '
        Me.bendturn.BackColor = System.Drawing.Color.Maroon
        Me.bendturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bendturn.Location = New System.Drawing.Point(217, 351)
        Me.bendturn.Name = "bendturn"
        Me.bendturn.Size = New System.Drawing.Size(87, 30)
        Me.bendturn.TabIndex = 4
        Me.bendturn.Text = "End Turn"
        Me.bendturn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 516)
        Me.Controls.Add(Me.bendturn)
        Me.Controls.Add(Me.laction)
        Me.Controls.Add(Me.lenergy)
        Me.Controls.Add(Me.lturn)
        Me.Controls.Add(Me.leattack)
        Me.Controls.Add(Me.lhattack)
        Me.Controls.Add(Me.leshield)
        Me.Controls.Add(Me.lhshield)
        Me.Controls.Add(Me.lehealth)
        Me.Controls.Add(Me.lhhealth)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.bsharp)
        Me.Controls.Add(Me.bshield)
        Me.Controls.Add(Me.batk)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents batk As System.Windows.Forms.Button
    Friend WithEvents bshield As System.Windows.Forms.Button
    Friend WithEvents bsharp As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lhhealth As System.Windows.Forms.Label
    Friend WithEvents lenergy As System.Windows.Forms.Label
    Friend WithEvents lhshield As System.Windows.Forms.Label
    Friend WithEvents lhattack As System.Windows.Forms.Label
    Friend WithEvents lehealth As System.Windows.Forms.Label
    Friend WithEvents leshield As System.Windows.Forms.Label
    Friend WithEvents leattack As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.Timer
    Friend WithEvents lturn As System.Windows.Forms.Label
    Friend WithEvents laction As System.Windows.Forms.Label
    Friend WithEvents bendturn As System.Windows.Forms.Button

End Class
