Imports cn = CapaNegocio

Public Class MantHabit
    Private WithEvents HOTEL As New cn.HotelCN
    Private Sub MantHabit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_HOTELDataSet2.ESTADOI' table. You can move, or remove it, as needed.
        Me.ESTADOITableAdapter.Fill(Me.DB_HOTELDataSet2.ESTADOI)
        CargarHabitacion()
    End Sub
    Sub CargarHabitacion()
        dgv_habit.DataSource = HOTEL.ListHabita()
    End Sub
    Dim idh As Integer
    Private Sub dgv_habit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_habit.CellClick
        Dim i As Integer
        i = dgv_habit.CurrentRow.Index
        idh = dgv_habit.Item(0, i).Value()
        CB_slot.Text = dgv_habit.Item(1, i).Value()
        txt_habitaN.Text = dgv_habit.Item(2, i).Value()

    End Sub
    Private Sub btn_liberar_Click(sender As Object, e As EventArgs) Handles btn_liberar.Click
        HOTEL.EnableHabita(idh)
        CargarHabitacion()
    End Sub
End Class