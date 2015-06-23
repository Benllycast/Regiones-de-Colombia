<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegionCaribe
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
        Me.cbxDepartamentos = New System.Windows.Forms.ComboBox()
        Me.btnInformacion = New System.Windows.Forms.Button()
        Me.btnPreguntas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxDepartamentos
        '
        Me.cbxDepartamentos.AutoCompleteCustomSource.AddRange(New String() {"Gaujira", "Cesar", "Magdalena", "Atlantico", "Bolivar", "Sucre", "Cordoba"})
        Me.cbxDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDepartamentos.FormattingEnabled = True
        Me.cbxDepartamentos.Items.AddRange(New Object() {"Gaujira", "Cesar", "Magdalena", "Atlantico", "Bolivar", "Sucre", "Cordoba"})
        Me.cbxDepartamentos.Location = New System.Drawing.Point(32, 271)
        Me.cbxDepartamentos.Name = "cbxDepartamentos"
        Me.cbxDepartamentos.Size = New System.Drawing.Size(180, 28)
        Me.cbxDepartamentos.TabIndex = 0
        '
        'btnInformacion
        '
        Me.btnInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformacion.Location = New System.Drawing.Point(32, 305)
        Me.btnInformacion.Name = "btnInformacion"
        Me.btnInformacion.Size = New System.Drawing.Size(180, 66)
        Me.btnInformacion.TabIndex = 1
        Me.btnInformacion.Text = "INFORMACION"
        Me.btnInformacion.UseVisualStyleBackColor = True
        '
        'btnPreguntas
        '
        Me.btnPreguntas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreguntas.Location = New System.Drawing.Point(767, 305)
        Me.btnPreguntas.Name = "btnPreguntas"
        Me.btnPreguntas.Size = New System.Drawing.Size(180, 66)
        Me.btnPreguntas.TabIndex = 2
        Me.btnPreguntas.Text = "PREGUNTAS DE EVALUACION"
        Me.btnPreguntas.UseVisualStyleBackColor = True
        '
        'frmRegionCaribe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.atlantico
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1004, 722)
        Me.Controls.Add(Me.btnPreguntas)
        Me.Controls.Add(Me.btnInformacion)
        Me.Controls.Add(Me.cbxDepartamentos)
        Me.DoubleBuffered = True
        Me.Name = "frmRegionCaribe"
        Me.Text = "Region Caribe"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbxDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents btnInformacion As System.Windows.Forms.Button
    Friend WithEvents btnPreguntas As System.Windows.Forms.Button
End Class
