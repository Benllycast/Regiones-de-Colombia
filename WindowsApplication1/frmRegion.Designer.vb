<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegion))
        Me.tbpMain = New System.Windows.Forms.TabControl()
        Me.tbpImagen = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVideo = New System.Windows.Forms.Button()
        Me.btnPreguntas = New System.Windows.Forms.Button()
        Me.btnInformacion = New System.Windows.Forms.Button()
        Me.cbxDepartamentos = New System.Windows.Forms.ComboBox()
        Me.tbpInformacion = New System.Windows.Forms.TabPage()
        Me.PDF_region = New AxAcroPDFLib.AxAcroPDF()
        Me.tbpVideo = New System.Windows.Forms.TabPage()
        Me.reproductor = New AxWMPLib.AxWindowsMediaPlayer()
        Me.tbpPreguntas = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnCalificar = New System.Windows.Forms.Button()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.grpPregunta6 = New System.Windows.Forms.GroupBox()
        Me.respuesta24 = New System.Windows.Forms.RadioButton()
        Me.respuesta23 = New System.Windows.Forms.RadioButton()
        Me.respuesta22 = New System.Windows.Forms.RadioButton()
        Me.respuesta21 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpPregunta5 = New System.Windows.Forms.GroupBox()
        Me.respuesta20 = New System.Windows.Forms.RadioButton()
        Me.respuesta19 = New System.Windows.Forms.RadioButton()
        Me.respuesta18 = New System.Windows.Forms.RadioButton()
        Me.respuesta17 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpPregunta4 = New System.Windows.Forms.GroupBox()
        Me.respuesta16 = New System.Windows.Forms.RadioButton()
        Me.respuesta15 = New System.Windows.Forms.RadioButton()
        Me.respuesta14 = New System.Windows.Forms.RadioButton()
        Me.respuesta13 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpPregunta3 = New System.Windows.Forms.GroupBox()
        Me.respuesta12 = New System.Windows.Forms.RadioButton()
        Me.respuesta11 = New System.Windows.Forms.RadioButton()
        Me.respuesta10 = New System.Windows.Forms.RadioButton()
        Me.respuesta9 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpPregunta2 = New System.Windows.Forms.GroupBox()
        Me.respuesta8 = New System.Windows.Forms.RadioButton()
        Me.respuesta7 = New System.Windows.Forms.RadioButton()
        Me.respuesta6 = New System.Windows.Forms.RadioButton()
        Me.respuesta5 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpPregunta1 = New System.Windows.Forms.GroupBox()
        Me.respuesta4 = New System.Windows.Forms.RadioButton()
        Me.respuesta3 = New System.Windows.Forms.RadioButton()
        Me.respuesta2 = New System.Windows.Forms.RadioButton()
        Me.respuesta1 = New System.Windows.Forms.RadioButton()
        Me.lblPregunta1 = New System.Windows.Forms.Label()
        Me.BdDataSet1 = New WindowsApplication1.BDDataSet()
        Me.EstudianteTableAdapter1 = New WindowsApplication1.BDDataSetTableAdapters.EstudianteTableAdapter()
        Me.tbpMain.SuspendLayout()
        Me.tbpImagen.SuspendLayout()
        Me.tbpInformacion.SuspendLayout()
        CType(Me.PDF_region, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpVideo.SuspendLayout()
        CType(Me.reproductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPreguntas.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.grpPregunta6.SuspendLayout()
        Me.grpPregunta5.SuspendLayout()
        Me.grpPregunta4.SuspendLayout()
        Me.grpPregunta3.SuspendLayout()
        Me.grpPregunta2.SuspendLayout()
        Me.grpPregunta1.SuspendLayout()
        CType(Me.BdDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbpMain
        '
        Me.tbpMain.Controls.Add(Me.tbpImagen)
        Me.tbpMain.Controls.Add(Me.tbpInformacion)
        Me.tbpMain.Controls.Add(Me.tbpVideo)
        Me.tbpMain.Controls.Add(Me.tbpPreguntas)
        Me.tbpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbpMain.Location = New System.Drawing.Point(0, 0)
        Me.tbpMain.Name = "tbpMain"
        Me.tbpMain.SelectedIndex = 0
        Me.tbpMain.Size = New System.Drawing.Size(1004, 562)
        Me.tbpMain.TabIndex = 0
        '
        'tbpImagen
        '
        Me.tbpImagen.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.atlantico
        Me.tbpImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbpImagen.Controls.Add(Me.Label1)
        Me.tbpImagen.Controls.Add(Me.btnVideo)
        Me.tbpImagen.Controls.Add(Me.btnPreguntas)
        Me.tbpImagen.Controls.Add(Me.btnInformacion)
        Me.tbpImagen.Controls.Add(Me.cbxDepartamentos)
        Me.tbpImagen.Location = New System.Drawing.Point(4, 22)
        Me.tbpImagen.Name = "tbpImagen"
        Me.tbpImagen.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpImagen.Size = New System.Drawing.Size(996, 536)
        Me.tbpImagen.TabIndex = 1
        Me.tbpImagen.Text = "Mapa"
        Me.tbpImagen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Departamentos"
        '
        'btnVideo
        '
        Me.btnVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideo.Location = New System.Drawing.Point(31, 327)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.Size = New System.Drawing.Size(180, 25)
        Me.btnVideo.TabIndex = 6
        Me.btnVideo.Text = "VIDEO"
        Me.btnVideo.UseVisualStyleBackColor = True
        '
        'btnPreguntas
        '
        Me.btnPreguntas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreguntas.Location = New System.Drawing.Point(732, 295)
        Me.btnPreguntas.Name = "btnPreguntas"
        Me.btnPreguntas.Size = New System.Drawing.Size(180, 66)
        Me.btnPreguntas.TabIndex = 5
        Me.btnPreguntas.Text = "PREGUNTAS DE EVALUACION"
        Me.btnPreguntas.UseVisualStyleBackColor = True
        '
        'btnInformacion
        '
        Me.btnInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformacion.Location = New System.Drawing.Point(31, 295)
        Me.btnInformacion.Name = "btnInformacion"
        Me.btnInformacion.Size = New System.Drawing.Size(180, 26)
        Me.btnInformacion.TabIndex = 4
        Me.btnInformacion.Text = "INFORMACION"
        Me.btnInformacion.UseVisualStyleBackColor = True
        '
        'cbxDepartamentos
        '
        Me.cbxDepartamentos.AutoCompleteCustomSource.AddRange(New String() {"Caribe", "Gaujira", "Cesar", "Magdalena", "Atlantico", "Bolivar", "Sucre", "Cordoba"})
        Me.cbxDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDepartamentos.FormattingEnabled = True
        Me.cbxDepartamentos.Items.AddRange(New Object() {"Caribe", "Gaujira", "Cesar", "Magdalena", "Atlantico", "Bolivar", "Sucre", "Cordoba"})
        Me.cbxDepartamentos.Location = New System.Drawing.Point(31, 261)
        Me.cbxDepartamentos.Name = "cbxDepartamentos"
        Me.cbxDepartamentos.Size = New System.Drawing.Size(180, 28)
        Me.cbxDepartamentos.TabIndex = 3
        '
        'tbpInformacion
        '
        Me.tbpInformacion.Controls.Add(Me.PDF_region)
        Me.tbpInformacion.Location = New System.Drawing.Point(4, 22)
        Me.tbpInformacion.Name = "tbpInformacion"
        Me.tbpInformacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInformacion.Size = New System.Drawing.Size(996, 536)
        Me.tbpInformacion.TabIndex = 0
        Me.tbpInformacion.Text = "Informacion"
        Me.tbpInformacion.UseVisualStyleBackColor = True
        '
        'PDF_region
        '
        Me.PDF_region.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDF_region.Enabled = True
        Me.PDF_region.Location = New System.Drawing.Point(3, 3)
        Me.PDF_region.Name = "PDF_region"
        Me.PDF_region.OcxState = CType(resources.GetObject("PDF_region.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PDF_region.Size = New System.Drawing.Size(990, 530)
        Me.PDF_region.TabIndex = 0
        '
        'tbpVideo
        '
        Me.tbpVideo.Controls.Add(Me.reproductor)
        Me.tbpVideo.Location = New System.Drawing.Point(4, 22)
        Me.tbpVideo.Name = "tbpVideo"
        Me.tbpVideo.Size = New System.Drawing.Size(996, 536)
        Me.tbpVideo.TabIndex = 3
        Me.tbpVideo.Text = "Video"
        Me.tbpVideo.UseVisualStyleBackColor = True
        '
        'reproductor
        '
        Me.reproductor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reproductor.Enabled = True
        Me.reproductor.Location = New System.Drawing.Point(0, 0)
        Me.reproductor.Name = "reproductor"
        Me.reproductor.OcxState = CType(resources.GetObject("reproductor.OcxState"), System.Windows.Forms.AxHost.State)
        Me.reproductor.Size = New System.Drawing.Size(996, 536)
        Me.reproductor.TabIndex = 0
        '
        'tbpPreguntas
        '
        Me.tbpPreguntas.AutoScroll = True
        Me.tbpPreguntas.AutoScrollMargin = New System.Drawing.Size(0, 100)
        Me.tbpPreguntas.AutoScrollMinSize = New System.Drawing.Size(0, 30)
        Me.tbpPreguntas.Controls.Add(Me.GroupBox7)
        Me.tbpPreguntas.Controls.Add(Me.grpPregunta6)
        Me.tbpPreguntas.Controls.Add(Me.grpPregunta5)
        Me.tbpPreguntas.Controls.Add(Me.grpPregunta4)
        Me.tbpPreguntas.Controls.Add(Me.grpPregunta3)
        Me.tbpPreguntas.Controls.Add(Me.grpPregunta2)
        Me.tbpPreguntas.Controls.Add(Me.grpPregunta1)
        Me.tbpPreguntas.Location = New System.Drawing.Point(4, 22)
        Me.tbpPreguntas.Name = "tbpPreguntas"
        Me.tbpPreguntas.Padding = New System.Windows.Forms.Padding(10)
        Me.tbpPreguntas.Size = New System.Drawing.Size(996, 536)
        Me.tbpPreguntas.TabIndex = 2
        Me.tbpPreguntas.Text = "Preguntas"
        Me.tbpPreguntas.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnCalificar)
        Me.GroupBox7.Controls.Add(Me.lblRespuesta)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(10, 856)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(959, 141)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Resultado Final"
        '
        'btnCalificar
        '
        Me.btnCalificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalificar.ForeColor = System.Drawing.Color.Red
        Me.btnCalificar.Location = New System.Drawing.Point(21, 21)
        Me.btnCalificar.Name = "btnCalificar"
        Me.btnCalificar.Size = New System.Drawing.Size(230, 114)
        Me.btnCalificar.TabIndex = 1
        Me.btnCalificar.Text = "CALIFICAR "
        Me.btnCalificar.UseVisualStyleBackColor = True
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(266, 67)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(272, 20)
        Me.lblRespuesta.TabIndex = 0
        Me.lblRespuesta.Text = "Presion en el boton para calificar"
        '
        'grpPregunta6
        '
        Me.grpPregunta6.Controls.Add(Me.respuesta24)
        Me.grpPregunta6.Controls.Add(Me.respuesta23)
        Me.grpPregunta6.Controls.Add(Me.respuesta22)
        Me.grpPregunta6.Controls.Add(Me.respuesta21)
        Me.grpPregunta6.Controls.Add(Me.Label6)
        Me.grpPregunta6.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPregunta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPregunta6.Location = New System.Drawing.Point(10, 715)
        Me.grpPregunta6.Name = "grpPregunta6"
        Me.grpPregunta6.Size = New System.Drawing.Size(959, 141)
        Me.grpPregunta6.TabIndex = 7
        Me.grpPregunta6.TabStop = False
        Me.grpPregunta6.Text = "Pregunta 6"
        '
        'respuesta24
        '
        Me.respuesta24.AutoSize = True
        Me.respuesta24.Location = New System.Drawing.Point(22, 112)
        Me.respuesta24.Name = "respuesta24"
        Me.respuesta24.Size = New System.Drawing.Size(176, 20)
        Me.respuesta24.TabIndex = 4
        Me.respuesta24.TabStop = True
        Me.respuesta24.Text = "ninguna de las anteriores"
        Me.respuesta24.UseVisualStyleBackColor = True
        '
        'respuesta23
        '
        Me.respuesta23.AutoSize = True
        Me.respuesta23.Location = New System.Drawing.Point(22, 89)
        Me.respuesta23.Name = "respuesta23"
        Me.respuesta23.Size = New System.Drawing.Size(131, 20)
        Me.respuesta23.TabIndex = 3
        Me.respuesta23.TabStop = True
        Me.respuesta23.Text = "nevado y lluvioso"
        Me.respuesta23.UseVisualStyleBackColor = True
        '
        'respuesta22
        '
        Me.respuesta22.AutoSize = True
        Me.respuesta22.Location = New System.Drawing.Point(22, 66)
        Me.respuesta22.Name = "respuesta22"
        Me.respuesta22.Size = New System.Drawing.Size(103, 20)
        Me.respuesta22.TabIndex = 2
        Me.respuesta22.TabStop = True
        Me.respuesta22.Text = "frio y nevado"
        Me.respuesta22.UseVisualStyleBackColor = True
        '
        'respuesta21
        '
        Me.respuesta21.AutoSize = True
        Me.respuesta21.Location = New System.Drawing.Point(22, 43)
        Me.respuesta21.Name = "respuesta21"
        Me.respuesta21.Size = New System.Drawing.Size(123, 20)
        Me.respuesta21.TabIndex = 1
        Me.respuesta21.TabStop = True
        Me.respuesta21.Text = "tropical y cálido "
        Me.respuesta21.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(332, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "¿cual es el clima del departamento de bolívar?"
        '
        'grpPregunta5
        '
        Me.grpPregunta5.Controls.Add(Me.respuesta20)
        Me.grpPregunta5.Controls.Add(Me.respuesta19)
        Me.grpPregunta5.Controls.Add(Me.respuesta18)
        Me.grpPregunta5.Controls.Add(Me.respuesta17)
        Me.grpPregunta5.Controls.Add(Me.Label5)
        Me.grpPregunta5.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPregunta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPregunta5.Location = New System.Drawing.Point(10, 574)
        Me.grpPregunta5.Name = "grpPregunta5"
        Me.grpPregunta5.Size = New System.Drawing.Size(959, 141)
        Me.grpPregunta5.TabIndex = 6
        Me.grpPregunta5.TabStop = False
        Me.grpPregunta5.Text = "Pregunta 5"
        '
        'respuesta20
        '
        Me.respuesta20.AutoSize = True
        Me.respuesta20.Location = New System.Drawing.Point(22, 112)
        Me.respuesta20.Name = "respuesta20"
        Me.respuesta20.Size = New System.Drawing.Size(172, 20)
        Me.respuesta20.TabIndex = 4
        Me.respuesta20.TabStop = True
        Me.respuesta20.Text = "Ninguna de la anteriores"
        Me.respuesta20.UseVisualStyleBackColor = True
        '
        'respuesta19
        '
        Me.respuesta19.AutoSize = True
        Me.respuesta19.Location = New System.Drawing.Point(22, 89)
        Me.respuesta19.Name = "respuesta19"
        Me.respuesta19.Size = New System.Drawing.Size(66, 20)
        Me.respuesta19.TabIndex = 3
        Me.respuesta19.TabStop = True
        Me.respuesta19.Text = "Caribe"
        Me.respuesta19.UseVisualStyleBackColor = True
        '
        'respuesta18
        '
        Me.respuesta18.AutoSize = True
        Me.respuesta18.Location = New System.Drawing.Point(22, 66)
        Me.respuesta18.Name = "respuesta18"
        Me.respuesta18.Size = New System.Drawing.Size(87, 20)
        Me.respuesta18.TabIndex = 2
        Me.respuesta18.TabStop = True
        Me.respuesta18.Text = "Suma Paz"
        Me.respuesta18.UseVisualStyleBackColor = True
        '
        'respuesta17
        '
        Me.respuesta17.AutoSize = True
        Me.respuesta17.Location = New System.Drawing.Point(22, 43)
        Me.respuesta17.Name = "respuesta17"
        Me.respuesta17.Size = New System.Drawing.Size(68, 20)
        Me.respuesta17.TabIndex = 1
        Me.respuesta17.TabStop = True
        Me.respuesta17.Text = "Andina"
        Me.respuesta17.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(592, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cuál de las siguientes regiones  pertenece a las 6 Regiones Naturales de Colombia" & _
    ":"
        '
        'grpPregunta4
        '
        Me.grpPregunta4.Controls.Add(Me.respuesta16)
        Me.grpPregunta4.Controls.Add(Me.respuesta15)
        Me.grpPregunta4.Controls.Add(Me.respuesta14)
        Me.grpPregunta4.Controls.Add(Me.respuesta13)
        Me.grpPregunta4.Controls.Add(Me.Label4)
        Me.grpPregunta4.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPregunta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPregunta4.Location = New System.Drawing.Point(10, 433)
        Me.grpPregunta4.Name = "grpPregunta4"
        Me.grpPregunta4.Size = New System.Drawing.Size(959, 141)
        Me.grpPregunta4.TabIndex = 5
        Me.grpPregunta4.TabStop = False
        Me.grpPregunta4.Text = "Pregunta 4"
        '
        'respuesta16
        '
        Me.respuesta16.AutoSize = True
        Me.respuesta16.Location = New System.Drawing.Point(22, 112)
        Me.respuesta16.Name = "respuesta16"
        Me.respuesta16.Size = New System.Drawing.Size(129, 20)
        Me.respuesta16.TabIndex = 4
        Me.respuesta16.TabStop = True
        Me.respuesta16.Text = "A y B son Falsas."
        Me.respuesta16.UseVisualStyleBackColor = True
        '
        'respuesta15
        '
        Me.respuesta15.AutoSize = True
        Me.respuesta15.Location = New System.Drawing.Point(22, 89)
        Me.respuesta15.Name = "respuesta15"
        Me.respuesta15.Size = New System.Drawing.Size(155, 20)
        Me.respuesta15.TabIndex = 3
        Me.respuesta15.TabStop = True
        Me.respuesta15.Text = "A y B son verdaderas"
        Me.respuesta15.UseVisualStyleBackColor = True
        '
        'respuesta14
        '
        Me.respuesta14.AutoSize = True
        Me.respuesta14.Location = New System.Drawing.Point(22, 66)
        Me.respuesta14.Name = "respuesta14"
        Me.respuesta14.Size = New System.Drawing.Size(229, 20)
        Me.respuesta14.TabIndex = 2
        Me.respuesta14.TabStop = True
        Me.respuesta14.Text = "El relieve y condiciones del suelo."
        Me.respuesta14.UseVisualStyleBackColor = True
        '
        'respuesta13
        '
        Me.respuesta13.AutoSize = True
        Me.respuesta13.Location = New System.Drawing.Point(22, 43)
        Me.respuesta13.Name = "respuesta13"
        Me.respuesta13.Size = New System.Drawing.Size(170, 20)
        Me.respuesta13.TabIndex = 1
        Me.respuesta13.TabStop = True
        Me.respuesta13.Text = "El clima y la vegetación."
        Me.respuesta13.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(578, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Las características que se tienen en cuenta para designar una Región Natural son:" & _
    ""
        '
        'grpPregunta3
        '
        Me.grpPregunta3.Controls.Add(Me.respuesta12)
        Me.grpPregunta3.Controls.Add(Me.respuesta11)
        Me.grpPregunta3.Controls.Add(Me.respuesta10)
        Me.grpPregunta3.Controls.Add(Me.respuesta9)
        Me.grpPregunta3.Controls.Add(Me.Label3)
        Me.grpPregunta3.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPregunta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPregunta3.Location = New System.Drawing.Point(10, 292)
        Me.grpPregunta3.Name = "grpPregunta3"
        Me.grpPregunta3.Size = New System.Drawing.Size(959, 141)
        Me.grpPregunta3.TabIndex = 4
        Me.grpPregunta3.TabStop = False
        Me.grpPregunta3.Text = "Pregunta 3"
        '
        'respuesta12
        '
        Me.respuesta12.AutoSize = True
        Me.respuesta12.Location = New System.Drawing.Point(22, 112)
        Me.respuesta12.Name = "respuesta12"
        Me.respuesta12.Size = New System.Drawing.Size(65, 20)
        Me.respuesta12.TabIndex = 4
        Me.respuesta12.TabStop = True
        Me.respuesta12.Text = "Cálido"
        Me.respuesta12.UseVisualStyleBackColor = True
        '
        'respuesta11
        '
        Me.respuesta11.AutoSize = True
        Me.respuesta11.Location = New System.Drawing.Point(22, 89)
        Me.respuesta11.Name = "respuesta11"
        Me.respuesta11.Size = New System.Drawing.Size(95, 20)
        Me.respuesta11.TabIndex = 3
        Me.respuesta11.TabStop = True
        Me.respuesta11.Text = "De Paramo"
        Me.respuesta11.UseVisualStyleBackColor = True
        '
        'respuesta10
        '
        Me.respuesta10.AutoSize = True
        Me.respuesta10.Location = New System.Drawing.Point(22, 66)
        Me.respuesta10.Name = "respuesta10"
        Me.respuesta10.Size = New System.Drawing.Size(89, 20)
        Me.respuesta10.TabIndex = 2
        Me.respuesta10.TabStop = True
        Me.respuesta10.Text = "Templado"
        Me.respuesta10.UseVisualStyleBackColor = True
        '
        'respuesta9
        '
        Me.respuesta9.AutoSize = True
        Me.respuesta9.Location = New System.Drawing.Point(22, 43)
        Me.respuesta9.Name = "respuesta9"
        Me.respuesta9.Size = New System.Drawing.Size(49, 20)
        Me.respuesta9.TabIndex = 1
        Me.respuesta9.TabStop = True
        Me.respuesta9.Text = "Frio"
        Me.respuesta9.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "En nuestras costas del caribe el clima es:"
        '
        'grpPregunta2
        '
        Me.grpPregunta2.Controls.Add(Me.respuesta8)
        Me.grpPregunta2.Controls.Add(Me.respuesta7)
        Me.grpPregunta2.Controls.Add(Me.respuesta6)
        Me.grpPregunta2.Controls.Add(Me.respuesta5)
        Me.grpPregunta2.Controls.Add(Me.Label2)
        Me.grpPregunta2.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPregunta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPregunta2.Location = New System.Drawing.Point(10, 151)
        Me.grpPregunta2.Name = "grpPregunta2"
        Me.grpPregunta2.Size = New System.Drawing.Size(959, 141)
        Me.grpPregunta2.TabIndex = 3
        Me.grpPregunta2.TabStop = False
        Me.grpPregunta2.Text = "Pregunta 2"
        '
        'respuesta8
        '
        Me.respuesta8.AutoSize = True
        Me.respuesta8.Location = New System.Drawing.Point(22, 112)
        Me.respuesta8.Name = "respuesta8"
        Me.respuesta8.Size = New System.Drawing.Size(179, 20)
        Me.respuesta8.TabIndex = 4
        Me.respuesta8.TabStop = True
        Me.respuesta8.Text = "Ninguna de las anteriores"
        Me.respuesta8.UseVisualStyleBackColor = True
        '
        'respuesta7
        '
        Me.respuesta7.AutoSize = True
        Me.respuesta7.Location = New System.Drawing.Point(22, 89)
        Me.respuesta7.Name = "respuesta7"
        Me.respuesta7.Size = New System.Drawing.Size(127, 20)
        Me.respuesta7.TabIndex = 3
        Me.respuesta7.TabStop = True
        Me.respuesta7.Text = "7 departamentos"
        Me.respuesta7.UseVisualStyleBackColor = True
        '
        'respuesta6
        '
        Me.respuesta6.AutoSize = True
        Me.respuesta6.Location = New System.Drawing.Point(22, 66)
        Me.respuesta6.Name = "respuesta6"
        Me.respuesta6.Size = New System.Drawing.Size(127, 20)
        Me.respuesta6.TabIndex = 2
        Me.respuesta6.TabStop = True
        Me.respuesta6.Text = "6 departamentos"
        Me.respuesta6.UseVisualStyleBackColor = True
        '
        'respuesta5
        '
        Me.respuesta5.AutoSize = True
        Me.respuesta5.Location = New System.Drawing.Point(22, 43)
        Me.respuesta5.Name = "respuesta5"
        Me.respuesta5.Size = New System.Drawing.Size(127, 20)
        Me.respuesta5.TabIndex = 1
        Me.respuesta5.TabStop = True
        Me.respuesta5.Text = "4 departamentos"
        Me.respuesta5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "¿cuantos departamentos tiene la región caribe?"
        '
        'grpPregunta1
        '
        Me.grpPregunta1.Controls.Add(Me.respuesta4)
        Me.grpPregunta1.Controls.Add(Me.respuesta3)
        Me.grpPregunta1.Controls.Add(Me.respuesta2)
        Me.grpPregunta1.Controls.Add(Me.respuesta1)
        Me.grpPregunta1.Controls.Add(Me.lblPregunta1)
        Me.grpPregunta1.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPregunta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPregunta1.Location = New System.Drawing.Point(10, 10)
        Me.grpPregunta1.Name = "grpPregunta1"
        Me.grpPregunta1.Size = New System.Drawing.Size(959, 141)
        Me.grpPregunta1.TabIndex = 2
        Me.grpPregunta1.TabStop = False
        Me.grpPregunta1.Text = "Pregunta 1"
        '
        'respuesta4
        '
        Me.respuesta4.AutoSize = True
        Me.respuesta4.Location = New System.Drawing.Point(22, 112)
        Me.respuesta4.Name = "respuesta4"
        Me.respuesta4.Size = New System.Drawing.Size(179, 20)
        Me.respuesta4.TabIndex = 4
        Me.respuesta4.TabStop = True
        Me.respuesta4.Text = "Ninguna de las anteriores"
        Me.respuesta4.UseVisualStyleBackColor = True
        '
        'respuesta3
        '
        Me.respuesta3.AutoSize = True
        Me.respuesta3.Location = New System.Drawing.Point(22, 89)
        Me.respuesta3.Name = "respuesta3"
        Me.respuesta3.Size = New System.Drawing.Size(98, 20)
        Me.respuesta3.TabIndex = 3
        Me.respuesta3.TabStop = True
        Me.respuesta3.Text = "Magdalena "
        Me.respuesta3.UseVisualStyleBackColor = True
        '
        'respuesta2
        '
        Me.respuesta2.AutoSize = True
        Me.respuesta2.Location = New System.Drawing.Point(22, 66)
        Me.respuesta2.Name = "respuesta2"
        Me.respuesta2.Size = New System.Drawing.Size(56, 20)
        Me.respuesta2.TabIndex = 2
        Me.respuesta2.TabStop = True
        Me.respuesta2.Text = "Meta"
        Me.respuesta2.UseVisualStyleBackColor = True
        '
        'respuesta1
        '
        Me.respuesta1.AutoSize = True
        Me.respuesta1.BackColor = System.Drawing.Color.Transparent
        Me.respuesta1.Location = New System.Drawing.Point(22, 43)
        Me.respuesta1.Name = "respuesta1"
        Me.respuesta1.Size = New System.Drawing.Size(65, 20)
        Me.respuesta1.TabIndex = 1
        Me.respuesta1.TabStop = True
        Me.respuesta1.Text = "Cauca"
        Me.respuesta1.UseVisualStyleBackColor = False
        '
        'lblPregunta1
        '
        Me.lblPregunta1.AutoSize = True
        Me.lblPregunta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta1.Location = New System.Drawing.Point(19, 24)
        Me.lblPregunta1.Name = "lblPregunta1"
        Me.lblPregunta1.Size = New System.Drawing.Size(421, 16)
        Me.lblPregunta1.TabIndex = 0
        Me.lblPregunta1.Text = "¿cual es el departamento que pertenece a la región caribe?"
        '
        'BdDataSet1
        '
        Me.BdDataSet1.DataSetName = "BDDataSet"
        Me.BdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudianteTableAdapter1
        '
        Me.EstudianteTableAdapter1.ClearBeforeFill = True
        '
        'frmRegion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 562)
        Me.Controls.Add(Me.tbpMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegion"
        Me.Text = "Region Caribe"
        Me.TopMost = True
        Me.tbpMain.ResumeLayout(False)
        Me.tbpImagen.ResumeLayout(False)
        Me.tbpImagen.PerformLayout()
        Me.tbpInformacion.ResumeLayout(False)
        CType(Me.PDF_region, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpVideo.ResumeLayout(False)
        CType(Me.reproductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPreguntas.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.grpPregunta6.ResumeLayout(False)
        Me.grpPregunta6.PerformLayout()
        Me.grpPregunta5.ResumeLayout(False)
        Me.grpPregunta5.PerformLayout()
        Me.grpPregunta4.ResumeLayout(False)
        Me.grpPregunta4.PerformLayout()
        Me.grpPregunta3.ResumeLayout(False)
        Me.grpPregunta3.PerformLayout()
        Me.grpPregunta2.ResumeLayout(False)
        Me.grpPregunta2.PerformLayout()
        Me.grpPregunta1.ResumeLayout(False)
        Me.grpPregunta1.PerformLayout()
        CType(Me.BdDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbpMain As System.Windows.Forms.TabControl
    Friend WithEvents tbpInformacion As System.Windows.Forms.TabPage
    Friend WithEvents tbpImagen As System.Windows.Forms.TabPage
    Friend WithEvents tbpPreguntas As System.Windows.Forms.TabPage
    Friend WithEvents tbpVideo As System.Windows.Forms.TabPage
    Friend WithEvents PDF_region As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents btnPreguntas As System.Windows.Forms.Button
    Friend WithEvents btnInformacion As System.Windows.Forms.Button
    Friend WithEvents cbxDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents btnVideo As System.Windows.Forms.Button
    Friend WithEvents reproductor As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRespuesta As System.Windows.Forms.Label
    Friend WithEvents grpPregunta6 As System.Windows.Forms.GroupBox
    Friend WithEvents respuesta24 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta23 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta22 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta21 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpPregunta5 As System.Windows.Forms.GroupBox
    Friend WithEvents respuesta20 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta19 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta18 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta17 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpPregunta4 As System.Windows.Forms.GroupBox
    Friend WithEvents respuesta16 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta15 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta14 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta13 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpPregunta3 As System.Windows.Forms.GroupBox
    Friend WithEvents respuesta12 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta11 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta10 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta9 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpPregunta2 As System.Windows.Forms.GroupBox
    Friend WithEvents respuesta8 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta7 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta6 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpPregunta1 As System.Windows.Forms.GroupBox
    Friend WithEvents respuesta4 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta3 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta2 As System.Windows.Forms.RadioButton
    Friend WithEvents respuesta1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPregunta1 As System.Windows.Forms.Label
    Friend WithEvents btnCalificar As System.Windows.Forms.Button
    Friend WithEvents BdDataSet1 As WindowsApplication1.BDDataSet
    Friend WithEvents EstudianteTableAdapter1 As WindowsApplication1.BDDataSetTableAdapters.EstudianteTableAdapter
End Class
