Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class clsEmp
    Inherits clsConexion
    Dim cmd As New SqlCommand


    Public Function GetEmpleados() As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("MosEmp")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function VerificarDNIEmpNuevo(usu As Integer) As DataTable


        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("VerDNIEmp")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@DNI", usu)



            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Establecemos el tiempo maximo de espera a respuesta de sql
            cmd.CommandTimeout = 9999
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function VerificarDNIEmpMod(usu As Integer, empleado As eEmp) As DataTable


        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("VerDNIModEmp")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@DNI", usu)
            cmd.Parameters.AddWithValue("@CodEmp", empleado.CodEmp)


            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Establecemos el tiempo maximo de espera a respuesta de sql
            cmd.CommandTimeout = 9999
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function GetEmpleadosCancel() As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("MosBajEmp")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function BajaEmpleados(id As Integer, id_eliminador As Integer) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("BajEmpUsu")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodEmp", id)
            cmd.Parameters.AddWithValue("@IdBaja", id_eliminador)
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        End With
    End Function

    Public Function RecEmpleados(id As Integer) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("RecEmp")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodEmp", id)
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        End With
    End Function

    Public Function InsEmp(empleado As eEmp) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("InsEmp")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@DNI", empleado.DNI)
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre)
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido)
            cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono)
            cmd.Parameters.AddWithValue("@CodPais", empleado.CodPais)
            cmd.Parameters.AddWithValue("@Email", empleado.Correo)
            cmd.Parameters.AddWithValue("@Domicilio", empleado.Domicilio)
            cmd.Parameters.AddWithValue("@IdAlta", empleado.IdAlta)



            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        End With
    End Function

    Public Function ModEmp(empleado As eEmp) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("ModEmp")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodEmp", empleado.CodEmp)
            cmd.Parameters.AddWithValue("@DNI", empleado.DNI)
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre)
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido)
            cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono)
            cmd.Parameters.AddWithValue("@CodPais", empleado.CodPais)
            cmd.Parameters.AddWithValue("@Email", empleado.Correo)
            cmd.Parameters.AddWithValue("@Domicilio", empleado.Domicilio)






            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        End With
    End Function

    Public Function BuscarEmpleados(emp As String) As DataTable


        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("BusEmp")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@Busqueda", emp)


            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Establecemos el tiempo maximo de espera a respuesta de sql
            cmd.CommandTimeout = 9999
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function
    Public Function BuscarEmpleadoBaja(emp As String) As DataTable


        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("BusEmpBaj")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@Busqueda", emp)


            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Establecemos el tiempo maximo de espera a respuesta de sql
            cmd.CommandTimeout = 9999
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

End Class
