Public Class frmRegion

    Const region_caribe As Integer = 0
    Const guajira As Integer = 1
    Const cesar As Integer = 2
    Const magdalena As Integer = 3
    Const atlantico As Integer = 4
    Const bolivar As Integer = 5
    Const sucre As Integer = 6
    Const cordoba As Integer = 7


    Private Sub tbpVideo_Click(sender As Object, e As EventArgs) Handles tbpVideo.Click

    End Sub

    'procedimiento para abrir los PDF.
    Private Sub btnInformacion_Click(sender As Object, e As EventArgs) Handles btnInformacion.Click

        'se obtine la seleccion del combobox
        Dim seleccion As Integer = cbxDepartamentos.SelectedIndex

        If seleccion >= 0 Then
            Select Case seleccion
                Case region_caribe
                    PDF_region.src = frmMain.RUTA_DEL_PROYECTO & "region_caribe.pdf"
                Case guajira
                    PDF_region.src = frmMain.RUTA_DEL_PROYECTO & "guajira.pdf"
                Case cesar
                    PDF_region.src = frmMain.RUTA_DEL_PROYECTO & "cesar.pdf"
                Case magdalena
                    PDF_region.src = frmMain.RUTA_DEL_PROYECTO & "magdalena.pdf"
                Case atlantico
                    PDF_region.src = frmMain.RUTA_DEL_PROYECTO & "atlantico.pdf"
                Case bolivar
                    PDF_region.src = frmMain.RUTA_DEL_PROYECTO & "bolivar.pdf"
                Case sucre
                    PDF_region.src = frmMain.RUTA_DEL_PROYECTO & "sucre.pdf"
                Case cordoba
                    PDF_region.src = frmMain.RUTA_DEL_PROYECTO & "cordoba.pdf"
            End Select
            'con esta llamada se abre el archivo PDF
            PDF_region.Refresh()

            'se muestra la pestaña donde se muestra el PDF
            tbpMain.SelectedTab = tbpInformacion
        End If
    End Sub

    'subrutina para mostrar el video de la region.
    Private Sub reproducirVideo(sender As Object, e As EventArgs) Handles btnVideo.Click
        Dim seleccion As Integer = cbxDepartamentos.SelectedIndex
        If seleccion >= 0 Then
            Select Case seleccion
                Case region_caribe
                    reproductor.URL = frmMain.RUTA_DEL_PROYECTO & "video_caribe.mp4"
                Case guajira
                    reproductor.URL = frmMain.RUTA_DEL_PROYECTO & "video_guajira.mp4"
                Case cesar
                    reproductor.URL = frmMain.RUTA_DEL_PROYECTO & "video_cesar.mp4"
                Case magdalena
                    reproductor.URL = frmMain.RUTA_DEL_PROYECTO & "video_magdalena.mp4"
                Case atlantico
                    reproductor.URL = frmMain.RUTA_DEL_PROYECTO & "video_atlantico.mp4"
                Case bolivar
                    reproductor.URL = frmMain.RUTA_DEL_PROYECTO & "video_bolivar.mp4"
                Case sucre
                    reproductor.URL = frmMain.RUTA_DEL_PROYECTO & "video_sucre.mp4"
                Case cordoba
                    reproductor.URL = frmMain.RUTA_DEL_PROYECTO & "video_cordoba.mp4"
            End Select
            'muestra la pestaña de video
            tbpMain.SelectedTab = tbpVideo

            'reproduce el video
            reproductor.Refresh()
            reproductor.Ctlcontrols.play()
        End If
    End Sub

    'si se produce un cambio de pestaña ejecuta esta rutina
    Private Sub tbpVideoDeseleccionado(sender As Object, e As TabControlEventArgs) Handles tbpMain.Deselected
        reproductor.Ctlcontrols.pause()
    End Sub

    ' subrutina para calificar preguntas
    Private Sub calificarPreguntas(sender As Object, e As EventArgs) Handles btnCalificar.Click
        Dim preguntas_buenas As Integer = 0

        'desabilitamos todas las preguntas para que no se puedan modificar
        grpPregunta1.Enabled = False
        grpPregunta2.Enabled = False
        grpPregunta3.Enabled = False
        grpPregunta4.Enabled = False
        grpPregunta5.Enabled = False
        grpPregunta6.Enabled = False
        btnCalificar.Enabled = False

        'colocamos el fonodo de todas las respuesta en rojo (malo) por defecto
        respuesta1.BackColor = Color.Red
        respuesta2.BackColor = Color.Red
        respuesta3.BackColor = Color.Red
        respuesta4.BackColor = Color.Red

        respuesta5.BackColor = Color.Red
        respuesta6.BackColor = Color.Red
        respuesta7.BackColor = Color.Red
        respuesta8.BackColor = Color.Red

        respuesta9.BackColor = Color.Red
        respuesta10.BackColor = Color.Red
        respuesta11.BackColor = Color.Red
        respuesta12.BackColor = Color.Red

        respuesta13.BackColor = Color.Red
        respuesta14.BackColor = Color.Red
        respuesta15.BackColor = Color.Red
        respuesta16.BackColor = Color.Red

        respuesta17.BackColor = Color.Red
        respuesta18.BackColor = Color.Red
        respuesta19.BackColor = Color.Red
        respuesta20.BackColor = Color.Red

        respuesta21.BackColor = Color.Red
        respuesta22.BackColor = Color.Red
        respuesta23.BackColor = Color.Red
        respuesta24.BackColor = Color.Red
        
        'comprobamos que las respuestas seleccionadas son las correctas
        If respuesta3.Checked Then
            'si selecciona la respuesta correcta, aumentamos el numero de preguntas buenas
            preguntas_buenas += 1
            'cambiamos el color de fondo de verde
            respuesta3.BackColor = Color.Green
        End If

        'igual que el anterior
        If respuesta7.Checked Then
            preguntas_buenas += 1
            respuesta7.BackColor = Color.Green
        End If

        If respuesta12.Checked Then
            preguntas_buenas += 1
            respuesta12.BackColor = Color.Green
        End If

        If respuesta15.Checked Then
            preguntas_buenas += 1
            respuesta15.BackColor = Color.Green
        End If

        If respuesta19.Checked Then
            preguntas_buenas += 1
            respuesta19.BackColor = Color.Green
        End If

        If respuesta21.Checked Then
            preguntas_buenas += 1
            respuesta21.BackColor = Color.Green
        End If

        lblRespuesta.Text = "Total de respuestas correctas: " & preguntas_buenas.ToString
        EstudianteTableAdapter1.UpdateEvaluacion(preguntas_buenas, frmMain.ID_ESTUDIANTE)

    End Sub

    Private Sub realizarCuestionario(sender As Object, e As EventArgs) Handles btnPreguntas.Click
        tbpMain.SelectedTab = tbpPreguntas
    End Sub

    Private Sub checkEvaluacion(sender As Object, e As TabControlCancelEventArgs) Handles tbpMain.Selecting
        Dim idEstudiante As Integer = frmMain.ID_ESTUDIANTE
        If (tbpMain.SelectedTab Is tbpPreguntas) And (EstudianteTableAdapter1.getResutadoEvaluacion(idEstudiante) >= 0) Then
            grpPregunta1.Enabled = False
            grpPregunta2.Enabled = False
            grpPregunta3.Enabled = False
            grpPregunta4.Enabled = False
            grpPregunta5.Enabled = False
            grpPregunta6.Enabled = False
            btnCalificar.Enabled = False
            MessageBox.Show("ya ha realizado el examen")
        End If
    End Sub
End Class