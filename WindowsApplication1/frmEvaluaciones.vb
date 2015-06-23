Public Class frmEvaluaciones

    Private Sub frmEvaluaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDDataSet.Estudiante' table. You can move, or remove it, as needed.
        Me.EstudianteTableAdapter.Fill(Me.BDDataSet.Estudiante)


    End Sub
End Class