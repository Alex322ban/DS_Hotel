Imports System.Data.SqlClient

Public Class HotelCD
    Private cn As New Conexion
    Public Function AddCliente(ByVal nomb As String, ByVal ape As String, ByVal dni As String)
        Dim da As New SqlDataAdapter("P0001", cn.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.AddWithValue("@NOMB", nomb)
        da.SelectCommand.Parameters.AddWithValue("@APE", ape)
        da.SelectCommand.Parameters.AddWithValue("@DNI", dni)

        Dim tb As New DataTable
        da.Fill(tb)

        Return tb
    End Function

    Public Function UpdateCliente(ByVal idc As Integer, ByVal nomb As String, ByVal ape As String, ByVal dni As String)
        Dim da As New SqlDataAdapter("P0002", cn.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@IDC", idc)
        da.SelectCommand.Parameters.AddWithValue("@NOMB", nomb)
        da.SelectCommand.Parameters.AddWithValue("@APE", ape)
        da.SelectCommand.Parameters.AddWithValue("@DNI", dni)

        Dim tb As New DataTable
        da.Fill(tb)

        Return tb
    End Function

    Public Function DeleteCliente(ByVal dell As String)
        Dim da As New SqlDataAdapter("P0003", cn.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.AddWithValue("@DNI", dell)

        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function

    Public Function AddVehiculoG(ByVal SLOT As Integer, ByVal PLACA As String, ByVal DNI As String)
        Dim da As New SqlDataAdapter("P0004", cn.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure


        da.SelectCommand.Parameters.AddWithValue("@SLOT", SLOT)
        da.SelectCommand.Parameters.AddWithValue("@PLACA", PLACA)
        da.SelectCommand.Parameters.AddWithValue("@DNI", DNI)

        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function

    Public Function DropVehiculoG(ByVal SLOT As Integer)
        Dim da As New SqlDataAdapter("P0005", cn.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.AddWithValue("@SLOT", SLOT)

        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function

    Public Function AssignHabitacion(ByVal IDH As Integer, ByVal IDC As Integer)
        Dim da As New SqlDataAdapter("P0006", cn.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.AddWithValue("@IDH", IDH)
        da.SelectCommand.Parameters.AddWithValue("@IDC", IDC)

        Dim tb As New DataTable
        da.Fill(tb)
        Return tb

    End Function
    Public Function UnassignHabitacion(ByVal IDH As Integer)
        Dim da As New SqlDataAdapter("P0007", cn.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.AddWithValue("@IDH", IDH)

        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function
    Public Function EnableHabitacion(ByVal IDH As Integer)

        Dim da As New SqlDataAdapter("P0008", cn.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.AddWithValue("@IDH", IDH)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function
    Public Function ListCliente() As DataTable
        Dim da As New SqlDataAdapter("P0009", cn.getCN)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function

    Public Function ListHabitacion() As DataTable
        Dim da As New SqlDataAdapter("P0010", cn.getCN)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function
    Public Function ListHabitacion2() As DataTable
        Dim da As New SqlDataAdapter("P0013", cn.getCN)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function
    Public Function ListHabitacion3() As DataTable
        Dim da As New SqlDataAdapter("P0014", cn.getCN)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function

    Public Function ListGaraje() As DataTable
        Dim da As New SqlDataAdapter("P0011", cn.getCN)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function

    Public Function ListInventario() As DataTable
        Dim da As New SqlDataAdapter("P0012", cn.getCN)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function

    '    Public Function Consultar


End Class
