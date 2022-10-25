Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(My.Settings.CadenaConexion)
        Dim sql As String = "SELECT ID, Pri_nombre, Seg_nombre, Pri_apellido, Seg_apellido, Telefono, Celular, Direccion, Email, Fecha_nacimiento, Observaciones FROM Alumnos"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Alumnos")

            Me.DataGridView1.DataSource = ds.Tables("Alumnos")

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
