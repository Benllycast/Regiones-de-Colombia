Public Class frmNuevoUsuario

    Private Sub frmNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdDataSet1.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.BdDataSet1.Usuarios)
        'TODO: This line of code loads data into the 'BdDataSet1.Estudiante' table. You can move, or remove it, as needed.
        Me.EstudianteTableAdapter.Fill(Me.BdDataSet1.Estudiante)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim identificacion, grado, id As Integer
        Dim nombre, apellidos, usuario, clave As String

        nombre = txtNombre.Text.Trim()
        apellidos = txtApellidos.Text.Trim()
        usuario = txtUsuario.Text.Trim()
        clave = txtClave.Text.Trim()

        Try
            identificacion = Integer.Parse(txtIdentificacion.Text.Trim())
            grado = Integer.Parse(txtGrado.Text.Trim())
        Catch ex As Exception
            MessageBox.Show("Identificacion y Grado son Numericos")
            Console.WriteLine("=====" & ex.ToString)
        End Try

        If txtIdentificacion.Text.Trim.Length = 0 Or nombre.Length = 0 Or apellidos.Length = 0 Or txtGrado.Text.Trim.Length = 0 Or usuario.Length = 0 Or clave.Length = 0 Then
            MessageBox.Show(Me, "rellene todos los campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Try
            'codigo de la insercion de datos
            EstudianteTableAdapter.Insert(identificacion, nombre, apellidos, grado, -1)
            id = EstudianteTableAdapter.estudianteGetId(identificacion)
            UsuariosTableAdapter.Insert(usuario, clave, id)
        Catch ex As Exception
            MessageBox.Show(Me, "Error al agregar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine("=====" & ex.ToString)
            Return
        End Try

        MessageBox.Show(Me, "Usuario agregado")
        Me.Close()

    End Sub
End Class