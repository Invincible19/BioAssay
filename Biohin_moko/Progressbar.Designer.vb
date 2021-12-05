<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Progressbar
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
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.Animated = True
        Me.Guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2CircleProgressBar1.FillOffset = 21
        Me.Guna2CircleProgressBar1.FillThickness = 10
        Me.Guna2CircleProgressBar1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2CircleProgressBar1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(74, 79)
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Cyan
        Me.Guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Guna2CircleProgressBar1.ProgressThickness = 40
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.ShadowDecoration.Parent = Me.Guna2CircleProgressBar1
        Me.Guna2CircleProgressBar1.ShowPercentage = True
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(253, 251)
        Me.Guna2CircleProgressBar1.TabIndex = 0
        Me.Guna2CircleProgressBar1.Value = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-2, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(408, 49)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BIO-ASSAY DIAGNOSTIC CENTER"
        '
        'Progressbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 370)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Progressbar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
