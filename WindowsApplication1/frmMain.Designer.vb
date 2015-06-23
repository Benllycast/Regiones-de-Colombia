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
        Me.btnCaribe = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnEvaluaciones = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCaribe
        '
        Me.btnCaribe.Enabled = False
        Me.btnCaribe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaribe.Location = New System.Drawing.Point(442, 125)
        Me.btnCaribe.Name = "btnCaribe"
        Me.btnCaribe.Size = New System.Drawing.Size(99, 28)
        Me.btnCaribe.TabIndex = 0
        Me.btnCaribe.Text = "R. Caribe"
        Me.btnCaribe.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Enabled = False
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(123, 99)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(99, 28)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnEvaluaciones
        '
        Me.btnEvaluaciones.Enabled = False
        Me.btnEvaluaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluaciones.Location = New System.Drawing.Point(793, 65)
        Me.btnEvaluaciones.Name = "btnEvaluaciones"
        Me.btnEvaluaciones.Size = New System.Drawing.Size(99, 28)
        Me.btnEvaluaciones.TabIndex = 6
        Me.btnEvaluaciones.Text = "Evaluaciones"
        Me.btnEvaluaciones.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(123, 65)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(99, 28)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Regiones_naturales_de_Colombia
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1004, 560)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnEvaluaciones)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCaribe)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1020, 760)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1020, 598)
        Me.Name = "frmMain"
        Me.Text = "Regiones de Colombia."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCaribe As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnEvaluaciones As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button

End Class
