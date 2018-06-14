Imports CapaDatos
Public Class HotelCN
    Private hotel As New HotelCD

    Public Function ListCli() As DataTable
        Return hotel.ListCliente
    End Function
    Public Function AddCli(ByVal nomb As String, ByVal ape As String, ByVal dni As String)
        Return hotel.AddCliente(nomb, ape, dni)
    End Function
    Public Function DelCli(ByVal dni As String)
        Return hotel.DeleteCliente(dni)
    End Function
    Public Function EditCli(ByVal idc As Integer, ByVal nomb As String, ByVal ape As String, ByVal dni As String)
        Return hotel.UpdateCliente(idc, nomb, ape, dni)
    End Function
    Public Function ListGaraj() As DataTable
        Return hotel.ListGaraje
    End Function
    Public Function AddVehiG(ByVal slot As Integer, ByVal placa As String, ByVal dni As String)
        Return hotel.AddVehiculoG(slot, placa, dni)
    End Function
    Public Function ListHabita() As DataTable
        Return hotel.ListHabitacion
    End Function
    Public Function ListHabita2() As DataTable
        Return hotel.ListHabitacion2
    End Function
    Public Function ListHabita3() As DataTable
        Return hotel.ListHabitacion3
    End Function
    Public Function AsigHabita(ByVal IDH, ByVal IDC)
        Return hotel.AssignHabitacion(IDH, IDC)
    End Function
    Public Function UnassignHabita(ByVal IDH)
        Return hotel.UnassignHabitacion(IDH)
    End Function
    Public Function EnableHabita(ByVal IDH)
        Return hotel.EnableHabitacion(IDH)
    End Function
End Class
