Public Class Trabajador

    Private id As String
    Private contrasenia As String
    Private nombre As String
    Private edad As Integer
    Private antiguedad As Integer
    Private departamento As Integer
    Private vacaciones As Integer
    Private sueldo As Double

    'Constructor
    Public Sub New()
        Me.id = ""
        Me.contrasenia = ""
        Me.nombre = ""
        Me.edad = 0
        Me.antiguedad = 0
        Me.departamento = 0
        Me.vacaciones = 0
        Me.sueldo = 0
    End Sub

    Public Sub New(id As String, contrasenia As String, nombre As String,
            edad As Integer, antiguedad As Integer, departamento As Integer)
        Me.id = id
        Me.contrasenia = contrasenia
        Me.nombre = nombre
        Me.edad = edad
        Me.antiguedad = antiguedad
        Me.departamento = departamento
    End Sub

    'Como los getters y setters en Java
    Public Property propId() As String
        Get
            Return Me.id
        End Get
        Set(value As String)
            Me.id = value
        End Set
    End Property

    Public Property propContrasenia() As String
        Get
            Return Me.contrasenia
        End Get
        Set(value As String)
            Me.contrasenia = value
        End Set
    End Property

    Public Property propNombre() As String
        Get
            Return Me.nombre
        End Get
        Set(value As String)
            Me.nombre = value
        End Set
    End Property

    Public Property propEdad() As Integer
        Get
            Return Me.edad
        End Get
        Set(value As Integer)
            Me.edad = value
        End Set
    End Property

    Public Property propAntiguedad() As Integer
        Get
            Return Me.antiguedad
        End Get
        Set(value As Integer)
            Me.antiguedad = value
        End Set
    End Property

    Public Property propDepartamento() As Integer
        Get
            Return Me.departamento
        End Get
        Set(value As Integer)
            Me.departamento = value
        End Set
    End Property

    Public Property propSueldo() As Integer
        Get
            Return Me.sueldo
        End Get
        Set(value As Integer)
            Me.sueldo = value
        End Set
    End Property

    Public Property propVacaciones() As Integer
        Get
            Return Me.vacaciones
        End Get
        Set(value As Integer)
            Me.vacaciones = value
        End Set
    End Property



    'FUNCIONES DEL SUELDO Y DE LAS VACACIONES
    Public Sub calculaSueldo()
        Dim porcentaje As Double
        Select Case Me.edad
            Case 18 To 50
                porcentaje = 5
            Case 51 To 60
                porcentaje = 10
            Case 61 To 80
                porcentaje = 15
        End Select

        Me.sueldo = 1500 + porcentaje / 100 * 1500
    End Sub

    Public Sub calculaVacaciones()
        If Me.antiguedad < 7 Then
            vacaciones = 15
        Else
            Select Case Me.departamento
                Case 1
                    vacaciones = 20
                Case 2
                    vacaciones = 25
                Case 3
                    vacaciones = 30
            End Select
        End If
    End Sub

End Class

