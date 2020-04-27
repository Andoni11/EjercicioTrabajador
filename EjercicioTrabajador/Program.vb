Imports System

Module Main

    Dim listadelTrabajador As New List(Of Trabajador)

    Sub Main()

        Dim id = ""
        Dim contrasenia As String
        Dim nombre As String
        Dim Text As String
        Dim edad As Integer
        Dim antiguedad As Integer
        Dim departamento As Integer
        Dim pos As Integer
        Dim miT, nuevoT As Trabajador

        Dim textFileStream As New IO.FileStream("C:\Users\andon\Trabajadores.txt", IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, IO.FileShare.None)
        Dim myFileWriter As New IO.StreamWriter(textFileStream)

        While id <> "stop"
            text = ""
            contrasenia = ""
            nombre = ""
            edad = 0
            antiguedad = 0
            departamento = 0

            Console.Clear()
            Console.Write("Introduzca el usuario: ")
            id = Console.ReadLine()
            Console.Clear()

            If id <> "stop" Then
                pos = buscaTrabajador(id)
                If pos <> -1 Then
                    miT = listadelTrabajador(pos)

                    While contrasenia <> miT.propContrasenia
                        Console.Write("Introduzca la contraseña: ")
                        contrasenia = Console.ReadLine()

                        If contrasenia <> miT.propContrasenia Then
                            Console.Write(vbCrLf & "Contraseña incorrecta." &
                                          vbCrLf & vbCrLf)

                        End If

                    End While

                    Console.Clear()
                    text &= "Usuario: " & miT.propId & vbCrLf &
                        "Contraseña: " & miT.propContrasenia & vbCrLf &
                        "Nombre: " & miT.propNombre & vbCrLf &
                        "Edad: " & miT.propEdad & vbCrLf &
                        "Antigüedad: " & miT.propAntiguedad & vbCrLf &
                        "Departamento: " & miT.propDepartamento & vbCrLf &
                        "Sueldo: " & miT.propSueldo & vbCrLf &
                        "Vacaciones: " & miT.propVacaciones & vbCrLf

                    Console.Write(text & vbCrLf &
                                  "Enter para seguir...")
                    myFileWriter.WriteLine(text)

                    Console.ReadLine()
                Else
                    Console.WriteLine("El usuario no existe.")
                    Console.WriteLine("Introduzca los campos requeridos." &
                                      vbCrLf)
                    While contrasenia = ""
                        Console.Write("Introduzca una contraseña: ")
                        contrasenia = Console.ReadLine()
                    End While

                    While nombre = ""
                        Console.Write("Introduzca su nombre completo: ")
                        nombre = Console.ReadLine()
                    End While

                    While edad < 18 Or edad > 80
                        Console.Write("Introduzca su edad: ")
                        edad = Console.ReadLine()
                        If edad > 0 And edad < 18 Then
                            Console.WriteLine("La edad de trabajar debe " &
                                              "ser mínmo 18.")
                        End If
                    End While

                    While antiguedad < 2 Or antiguedad > 30
                        Console.Write("Introduzca su antigüedad en la  empresa: ")
                        antiguedad = Console.ReadLine()
                    End While

                    While departamento < 1 Or departamento > 3
                        Console.WriteLine("Introduzca su departamento: " &
                                      vbCrLf & "1. Atención al cliente" &
                                      vbCrLf & "2. Logística" &
                                      vbCrLf & "3. Gerencia")
                        departamento = Console.ReadLine()
                    End While

                    nuevoT = New Trabajador(id, contrasenia, nombre,
                            edad, antiguedad, departamento)

                    nuevoT.calculaSueldo()
                    nuevoT.calculaVacaciones()

                    listadelTrabajador.Add(nuevoT)

                End If
            End If

        End While

        myFileWriter.Close()
        textFileStream.Close()

    End Sub

    Function buscaTrabajador(id As String) As Integer
        Dim index As Integer = 0
        For Each trabajador In listadelTrabajador
            If trabajador.propId().Equals(id) Then
                Return index
            End If
            index += 1
        Next

        Return -1
    End Function

End Module

