<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvaluaciones
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BDDataSet = New WindowsApplication1.BDDataSet()
        Me.EstudianteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudianteTableAdapter = New WindowsApplication1.BDDataSetTableAdapters.EstudianteTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvaluacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudianteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdentificacionDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.GradoDataGridViewTextBoxColumn, Me.EvaluacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EstudianteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(596, 279)
        Me.DataGridView1.TabIndex = 0
        '
        'BDDataSet
        '
        Me.BDDataSet.DataSetName = "BDDataSet"
        Me.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudianteBindingSource
        '
        Me.EstudianteBindingSource.DataMember = "Estudiante"
        Me.EstudianteBindingSource.DataSource = Me.BDDataSet
        '
        'EstudianteTableAdapter
        '
        Me.EstudianteTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'IdentificacionDataGridViewTextBoxColumn
        '
        Me.IdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.Name = "IdentificacionDataGridViewTextBoxColumn"
        Me.IdentificacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GradoDataGridViewTextBoxColumn
        '
        Me.GradoDataGridViewTextBoxColumn.DataPropertyName = "Grado"
        Me.GradoDataGridViewTextBoxColumn.HeaderText = "Grado"
        Me.GradoDataGridViewTextBoxColumn.Name = "GradoDataGridViewTextBoxColumn"
        Me.GradoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EvaluacionDataGridViewTextBoxColumn
        '
        Me.EvaluacionDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion"
        Me.EvaluacionDataGridViewTextBoxColumn.HeaderText = "Evaluacion"
        Me.EvaluacionDataGridViewTextBoxColumn.Name = "EvaluacionDataGridViewTextBoxColumn"
        Me.EvaluacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmEvaluaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 312)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmEvaluaciones"
        Me.Text = "Evaluaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudianteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BDDataSet As WindowsApplication1.BDDataSet
    Friend WithEvents EstudianteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudianteTableAdapter As WindowsApplication1.BDDataSetTableAdapters.EstudianteTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvaluacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
