Imports System.Data
Imports System.Data.SqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conectar As New SqlConnection("data source=(local)\SQLEXPRESS;initial catalog=DB_HOTEL; integrated security=yes")
            conectar.Open()

            Dim comando As New SqlCommand("sesion", conectar)
            Dim reader As SqlDataReader

            comando.CommandType = 4
            With comando.Parameters
                .AddWithValue("@USR", TextBox1.Text.ToUpper)
                .AddWithValue("@PASS", TextBox2.Text.ToUpper)
            End With
            reader = comando.ExecuteReader
            tip = TextBox1.Text
            If reader.HasRows = True Then
                Me.Hide()
                FormPrincipal.Show()
            Else
                MsgBox("Error, ingrese datos nuevamente")
            End If
            conectar.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class