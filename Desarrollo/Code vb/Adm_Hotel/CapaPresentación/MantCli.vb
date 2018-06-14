Imports cn = CapaNegocio
Public Class MantCli
    Private WithEvents HOTEL As New cn.HotelCN
    Private Sub MantCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCliente()
        cargarHabit2()
        CheckBox1.Checked = True

        'If (HOTEL.ListCli).LoadDataRow = True Then
        '    MsgBox("hola")
        'End If
    End Sub
    Private Sub cargarCliente()
        dgv_cli.DataSource = HOTEL.ListCli()
    End Sub
    Private Sub cargarHabit2()
        dgv_habit.DataSource = HOTEL.ListHabita2
    End Sub
    Private Sub cargarHabit3()
        dgv_habit.DataSource = HOTEL.ListHabita3
    End Sub
    Private Sub BTN_addcli_Click(sender As Object, e As EventArgs) Handles BTN_addcli.Click
        If txt_ape.Text = "" Or txt_dni.Text = "" Or txt_nomb.Text = "" Then
            MsgBox("Complete los recuadros", MessageBoxIcon.Warning)
        Else
            Dim result As Integer = MessageBox.Show("¿Seguro quiere añadir este cliente?", "Eliminar", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                cargarCliente()
            ElseIf result = DialogResult.No Then
                cargarCliente()
            ElseIf result = DialogResult.Yes Then
                If txt_ape.Text = "" Or txt_dni.Text = "" Or txt_nomb.Text = "" Then
                    MsgBox("Complete los recuadros", MessageBoxIcon.Warning)
                Else
                    HOTEL.AddCli(txt_nomb.Text, txt_ape.Text, txt_dni.Text)
                    cargarCliente()
                    MessageBox.Show("Cliente agregado", "Exitoso")
                End If
            End If
        End If
    End Sub
    Private Sub BTN_deltcli_Click(sender As Object, e As EventArgs) Handles BTN_deltcli.Click
        If txt_ape.Text = "" Or txt_dni.Text = "" Or txt_nomb.Text = "" Then
            MessageBox.Show("Datos incorrectos", "Error!", MessageBoxButtons.OK)
        Else
            Dim result As Integer = MessageBox.Show("¿Seguro quiere agregar este cliente?", "Eliminar", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                cargarCliente()
            ElseIf result = DialogResult.No Then
                cargarCliente()
            ElseIf result = DialogResult.Yes Then
                If txt_ape.Text = "" Or txt_dni.Text = "" Or txt_nomb.Text = "" Then
                    MsgBox("Complete los recuadros", MessageBoxIcon.Warning)
                Else
                    HOTEL.DelCli(txt_dni.Text)
                    cargarCliente()
                    MessageBox.Show("Datos Eliminados", "Exitoso")
                End If
            End If
        End If
    End Sub
    Dim idc, idh As Integer
    Private Sub dgv_cli_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cli.CellClick
        Dim i As Integer
        i = dgv_cli.CurrentRow.Index
        idc = dgv_cli.Item(0, i).Value()
        txt_dni.Text = dgv_cli.Item(3, i).Value()
        txt_ape.Text = dgv_cli.Item(2, i).Value()
        txt_nomb.Text = dgv_cli.Item(1, i).Value()
    End Sub
    Private Sub dgv_habit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_habit.CellClick
        Dim i As Integer
        i = dgv_habit.CurrentRow.Index
        idh = dgv_habit.Item(0, i).Value()
        txt_habit.Text = dgv_habit.Item(1, i).Value()
    End Sub
    Private Sub BTN_updcli_Click(sender As Object, e As EventArgs) Handles BTN_updcli.Click
        Dim result As Integer = MessageBox.Show("¿Seguro quiere actualizar?", "Actualizar", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            cargarCliente()
        ElseIf result = DialogResult.No Then
            cargarCliente()
        ElseIf result = DialogResult.Yes Then
            If txt_ape.Text = "" Or txt_dni.Text = "" Or txt_nomb.Text = "" Then
                MsgBox("Complete los recuadros", MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Datos actualizados", "Exitoso")
                HOTEL.EditCli(idc, txt_nomb.Text, txt_ape.Text, txt_dni.Text)
                cargarCliente()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txt_dni.Clear()
        txt_nomb.Clear()
        txt_ape.Clear()
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

    Private Sub BTN_asig_Click(sender As Object, e As EventArgs) Handles BTN_asig.Click
        Dim result As Integer = MessageBox.Show("¿Seguro quiere actualizar?", "Actualizar", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            cargarCliente()
        ElseIf result = DialogResult.No Then
            cargarCliente()
        ElseIf result = DialogResult.Yes Then
            If txt_ape.Text = "" Or txt_dni.Text = "" Or txt_nomb.Text = "" Then
                MsgBox("Complete los recuadros", MessageBoxIcon.Warning)
            Else
                Try
                    HOTEL.AsigHabita(idh, idc)
                    cargarCliente()
                    cargarHabit2()
                    MessageBox.Show("Datos actualizados", "Exitoso")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If

    End Sub

    Private Sub BTN_deasig_Click(sender As Object, e As EventArgs) Handles BTN_deasig.Click

        Dim result As Integer = MessageBox.Show("¿Seguro quiere actualizar?", "Actualizar", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            cargarCliente()
        ElseIf result = DialogResult.No Then
            cargarCliente()
        ElseIf result = DialogResult.Yes Then
            If idh = 0 Then
                MsgBox("Complete los recuadros", MessageBoxIcon.Warning)
            Else
                Try
                    HOTEL.UnassignHabita(idh)
                    cargarHabit3()
                    MessageBox.Show("Datos actualizados", "Exitoso")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cargarHabit2()
        Else
            cargarHabit3()
        End If
    End Sub

    Private Sub btn_pago_Click(sender As Object, e As EventArgs) Handles btn_pago.Click
        MantGaraj.Show()
    End Sub
End Class
