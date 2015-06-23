Public Class InicioSesion

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usuario, clave As String
        Dim idEstudiante As Integer
        Dim main As frmMain

        usuario = txtUsuario.Text
        clave = txtClave.Text
        If UsuariosTableAdapter.ScalarQueryLogin(usuario, clave) > 0 Then
            idEstudiante = UsuariosTableAdapter.getIdEstudiante(usuario, clave)
            frmMain.ID_ESTUDIANTE = idEstudiante
            
            main = Me.Owner
            main.btnCaribe.Enabled = True
            main.btnLogout.Enabled = True
            main.btnLogin.Enabled = False
            If String.Compare(usuario, "Admin") = 0 Then
                frmMain.ADMIN = True
                main.btnEvaluaciones.Enabled = True
            End If
            MessageBox.Show("Login sastiffactorio")
            Me.Close()
        Else
            MessageBox.Show("Usuario o Clave incorrectos. Verifique que exista el usuario.")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDDataSet.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.BDDataSet.Usuarios)
        'TODO: This line of code loads data into the 'BDDataSet.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.BDDataSet.Usuarios)

    End Sub

    Private Sub agregarUsuario(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Dim formulario As frmNuevoUsuario
        formulario = New frmNuevoUsuario
        formulario.Visible = True

    End Sub
End Class
