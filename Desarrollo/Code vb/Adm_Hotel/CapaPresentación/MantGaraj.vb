Imports cn = CapaNegocio
Public Class MantGaraj
    Private WithEvents HOTEL As New cn.HotelCN
    Private Sub MantGaraj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_slot.DropDownStyle = ComboBoxStyle.DropDownList
        'TODO: This line of code loads data into the 'DB_HOTELDataSet1.LISTCBSLOT' table. You can move, or remove it, as needed.
        'Me.LISTCBSLOTTableAdapter.Fill(Me.DB_HOTELDataSet1.LISTCBSLOT)
        ''TODO: This line of code loads data into the 'DB_HOTELDataSet.GARAJE' table. You can move, or remove it, as needed.
        'Me.GARAJETableAdapter.Fill(Me.DB_HOTELDataSet.GARAJE)
        CargarGaraj()
    End Sub
    Sub CargarGaraj()
        dgv_garaj.DataSource = HOTEL.ListGaraj
    End Sub
    Private Sub btn_Añadir_Click(sender As Object, e As EventArgs) Handles btn_Añadir.Click
        If txt_placa.Text = "" Or txt_dni.Text = "" Or CB_slot.Text = "" Then
            MsgBox("Complete los recuadros", MessageBoxIcon.Warning)
        Else
            HOTEL.AddVehiG(CB_slot.Text, txt_placa.Text, txt_dni.Text)
            CargarGaraj()
        End If
    End Sub

    Private Sub txt_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dni.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If Char.IsSeparator(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txt_dni_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_dni.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_placa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_placa.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class