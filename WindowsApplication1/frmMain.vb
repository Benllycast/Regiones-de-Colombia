Imports System.IO

Public Class frmMain
    Const REGION_CARIBE As Integer = 0
    Const REGION_ANDINA As Integer = 1
    Const REGION_PACIFICO As Integer = 2
    Const REGION_ORINOQUIA As Integer = 3
    Const REGION_AMAZONIA As Integer = 4

    'ruta del proyecto = C:\ruta\del\proyecto\carpeta\de\Resources
    Public Shared RUTA_DEL_PROYECTO As String = Application.StartupPath & "/Resources/"
    Public Shared ID_ESTUDIANTE As Integer = 0
    Public Shared ADMIN As Boolean = False

    Private Function crearRegion(ByVal region As Integer) As frmRegion
        Dim aux As frmRegion
        aux = New frmRegion()
        aux.Text = obtenerTitulo(region)
        'aux.txtInformacion.Text = obtenerInformacioDeRegion(region)
        'aux.PDF_region.src = RUTA_DEL_PROYECTO & "bolivar.pdf"
        'System.Console.WriteLine("========= RUTA: " & aux.PDF_region.src)
        aux.tbpImagen.BackgroundImage = obtenerMapa(region)
        aux.tbpImagen.BackgroundImageLayout = ImageLayout.Stretch
        Return aux
    End Function

    Private Function obtenerTitulo(ByVal region As Integer) As String
        Select Case region
            Case REGION_CARIBE
                Return "Region Caribe"
            Case REGION_ANDINA
                Return "Region Andina"
            Case REGION_PACIFICO
                Return "Region Pacifica"
            Case REGION_ORINOQUIA
                Return "Region Orinoquia"
            Case REGION_AMAZONIA
                Return "Region Amazonia"
            Case Else
                Return "no hay region"
        End Select
    End Function

    Private Function obtenerInformacioDeRegion(ByVal region As Integer) As String
        Select Case region
            Case REGION_CARIBE
                Return Global.WindowsApplication1.My.Resources.Resources.caribe
            Case REGION_ANDINA
                Return Global.WindowsApplication1.My.Resources.Resources.info_andina
            Case REGION_PACIFICO
                Return Global.WindowsApplication1.My.Resources.Resources.info_pacifico
            Case REGION_ORINOQUIA
                Return Global.WindowsApplication1.My.Resources.Resources.info_orinoquia
            Case REGION_AMAZONIA
                Return Global.WindowsApplication1.My.Resources.Resources.info_amazonas
            Case Else
                Return "no hay informacion de la region"
        End Select
    End Function

    Private Function obtenerMapa(ByVal region As Integer) As Bitmap
        Select Case region
            Case REGION_CARIBE
                Return Global.WindowsApplication1.My.Resources.Resources.atlantico
            Case REGION_ANDINA
                Return Global.WindowsApplication1.My.Resources.Resources.andina
            Case REGION_PACIFICO
                Return Global.WindowsApplication1.My.Resources.Resources.pacifica
            Case REGION_ORINOQUIA
                Return Global.WindowsApplication1.My.Resources.Resources.rorinoquia
            Case REGION_AMAZONIA
                Return Global.WindowsApplication1.My.Resources.Resources.amazonas
            Case Else
                Return Global.WindowsApplication1.My.Resources.Resources.Regiones_naturales_de_Colombia
        End Select
    End Function

    Private Sub openFormRegionCaribe(sender As Object, e As EventArgs) Handles btnCaribe.Click
        'definicion de variable del formulario de la region caribe
        'definicion: nombre + tipo = valor
        Dim formulario As frmRegion = New frmRegion

        ' para mostrar el formulario.
        formulario.Show(Me)
    End Sub

    Private Sub testSesion(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sesion As InicioSesion
        Try
            sesion = New InicioSesion
            'sesion.Parent = Me
            sesion.ShowDialog(Me)
            'sesion.Visible = True
        Catch ex As Exception
            MessageBox.Show(Me, "Nose puede Conectar a la Base de datos", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString())
        End Try

    End Sub

    Private Sub eventLogout(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmMain.ADMIN = False
        frmMain.ID_ESTUDIANTE = 0
        Me.btnCaribe.Enabled = False
        Me.btnLogin.Enabled = True
        Me.btnLogout.Enabled = False
        Me.btnEvaluaciones.Enabled = False

    End Sub

    Private Sub btnEvaluaciones_Click(sender As Object, e As EventArgs) Handles btnEvaluaciones.Click
        Dim formEvaluacion As frmEvaluaciones = New frmEvaluaciones
        formEvaluacion.Visible = True
    End Sub
End Class