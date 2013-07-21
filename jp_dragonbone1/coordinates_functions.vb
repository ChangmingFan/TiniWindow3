Public Class coordinates_functions
    'this form does not show

    'functions originate from http://www.java2s.com/Tutorial/VB/0140__Development/Convertrectangular3Dcoordinatestocylindricalcoordinates.htm

    'and have been modified by J.P. Denoyer

    Public Shared Function RectToCylinder(ByVal pointA As Point2d, Optional ByVal returnradians As Boolean = False) _
                  As Point2d
        ' ----- Convert rectangular 2d coordinates to
        '       cylindrical coordinates.
        Dim rho As Double
        Dim theta As Double

        rho = Math.Sqrt(pointA.X ^ 2 + pointA.Y ^ 2)


        theta = Math.Atan2(pointA.Y, pointA.X)
        If Not returnradians Then
            theta *= 180 / Math.PI
        End If

        Return New Point2d(rho, theta)
    End Function

    Public Shared Function RectToCylinder(ByVal pointA As PointF, Optional ByVal returnradians As Boolean = False) _
                  As PointF
        ' ----- Convert rectangular 2d coordinates to
        '       cylindrical coordinates.
        Dim rho As Double
        Dim theta As Double

        rho = Math.Sqrt(pointA.X ^ 2 + pointA.Y ^ 2)


        theta = Math.Atan2(pointA.Y, pointA.X)
        If Not returnradians Then
            theta *= 180 / Math.PI
        End If

        Return New PointF(rho, theta)
    End Function
    Public Shared Function RectToCylinder(ByVal pointA As Point, Optional ByVal returnradians As Boolean = False) _
                  As Point
        ' ----- Convert rectangular 2d coordinates to
        '       cylindrical coordinates.
        Dim rho As Double
        Dim theta As Double

        rho = Math.Sqrt(pointA.X ^ 2 + pointA.Y ^ 2)


        theta = Math.Atan2(pointA.Y, pointA.X)

        If Not returnradians Then
            theta *= 180.0 / Math.PI
        End If

        Return New Point(rho, theta)
    End Function

    Public Shared Function RectToCylinder(ByVal pointA As Point3D, Optional ByVal returnradians As Boolean = False) _
              As Point3D
        ' ----- Convert rectangular 3D coordinates to
        '       cylindrical coordinates.
        Dim rho As Double
        Dim theta As Double

        rho = Math.Sqrt(pointA.X ^ 2 + pointA.Y ^ 2)
        theta = Math.Atan2(pointA.Y, pointA.X)
        If Not returnradians Then
            theta *= 180 / Math.PI
        End If

        Return New Point3D(rho, theta, pointA.Z)
    End Function

    Public Shared Function CylinderToRect(ByVal pointA As Point2d, Optional ByVal radianspassed As Boolean = False) _
          As Point2d
        ' ----- Convert cylindrical coordinates to
        '       rectangular 2D coordinates.
        Dim x As Double
        Dim y As Double

        Dim cos As Double = Math.Cos(pointA.Y)
        Dim sin As Double = Math.Sin(pointA.Y)

        If radianspassed Then
            cos = Math.Cos(pointA.Y)
            sin = Math.Sin(pointA.Y)
        Else

            cos = Math.Cos(Math.PI / 180 * pointA.Y)
            sin = Math.Sin(Math.PI / 180 * pointA.Y)
        End If

        x = pointA.X * cos 'Math.Cos(pointA.Y)
        y = pointA.X * sin 'Math.Sin(pointA.Y)
        Return New Point2d(x, y)
    End Function
    Public Shared Function CylinderToRect(ByVal pointA As Point, Optional ByVal radianspassed As Boolean = False) _
          As Point
        ' ----- Convert cylindrical coordinates to
        '       rectangular 2D coordinates.
        Dim x As Double
        Dim y As Double
        If radianspassed Then
            x = pointA.X * Math.Cos(pointA.Y)
            y = pointA.X * Math.Sin(pointA.Y)
        Else
            x = pointA.X * Math.Cos(Math.PI / 180.0 * pointA.Y)
            y = pointA.X * Math.Sin(Math.PI / 180.0 * pointA.Y)
        End If


        Return New Point(x, y)
    End Function

    Public Shared Function CylinderToRect(ByVal pointA As PointF, Optional ByVal radianspassed As Boolean = False) _
          As PointF
        ' ----- Convert cylindrical coordinates to
        '       rectangular 2D coordinates.
        Dim x As Double
        Dim y As Double
        If radianspassed Then
            x = pointA.X * Math.Cos(pointA.Y)
            y = pointA.X * Math.Sin(pointA.Y)
        Else
            x = pointA.X * Math.Cos(Math.PI / 180.0 * pointA.Y)
            y = pointA.X * Math.Sin(Math.PI / 180.0 * pointA.Y)
        End If
        Return New PointF(x, y)
    End Function
    Public Shared Function CylinderToRect(ByVal pointA As Point3D, Optional ByVal radianspassed As Boolean = False) _
          As Point3D
        ' ----- Convert cylindrical coordinates to
        '       rectangular 3D coordinates.
        Dim x As Double
        Dim y As Double
        If radianspassed Then
            x = pointA.X * Math.Cos(pointA.Y)
            y = pointA.X * Math.Sin(pointA.Y)
        Else
            x = pointA.X * Math.Cos(Math.PI / 180.0 * pointA.Y)
            y = pointA.X * Math.Sin(Math.PI / 180.0 * pointA.Y)
        End If
        
        Return New Point3D(x, y, pointA.Z)
    End Function



    ''functions below this point use radians because I havnt yet bothered to modify





    Public Shared Function RectToSphere(ByVal pointA As Point3D) _
          As Point3D
        ' ----- Convert rectangular 3D coordinates to
        '       spherical coordinates.
        Dim rho As Double
        Dim theta As Double
        Dim phi As Double

        rho = Math.Sqrt(pointA.X ^ 2 + pointA.Y ^ 2 + _
           pointA.Z ^ 2)
        theta = Math.Atan2(pointA.Y, pointA.X)
        phi = Math.Acos(pointA.Z / Math.Sqrt( _
           pointA.X ^ 2 + pointA.Y ^ 2 + pointA.Z ^ 2))
        Return New Point3D(rho, theta, phi)
    End Function

    Public Shared Function SphereToRect(ByVal pointA As Point3D) _
          As Point3D
        ' ----- Convert spherical coordinates to
        '       rectangular 3D coordinates.
        Dim x As Double
        Dim y As Double
        Dim z As Double

        x = pointA.X * Math.Cos(pointA.Y) * Math.Sin(pointA.Z)
        y = pointA.X * Math.Sin(pointA.Y) * Math.Sin(pointA.Z)
        z = pointA.X * Math.Cos(pointA.Z)
        Return New Point3D(x, y, z)
    End Function

    Public Shared Function CylinderToSphere(ByVal pointA As Point3D) _
          As Point3D
        ' ----- Convert cylindrical coordinates to
        '       spherical coordinates.
        Dim rho As Double
        Dim theta As Double
        Dim phi As Double

        rho = Math.Sqrt(pointA.X ^ 2 + pointA.Z ^ 2)
        theta = pointA.Y
        phi = Math.Acos(pointA.Z / _
           Math.Sqrt(pointA.X ^ 2 + pointA.Z ^ 2))
        Return New Point3D(rho, theta, phi)
    End Function

    Public Shared Function SphereToCylinder(ByVal pointA As Point3D) _
          As Point3D
        ' ----- Convert spherical coordinates to
        '       cylindrical coordinates.
        Dim rho As Double
        Dim theta As Double
        Dim z As Double

        rho = pointA.X * Math.Sin(pointA.Z)
        theta = pointA.Y
        z = pointA.X * Math.Cos(pointA.Z)
        Return New Point3D(rho, theta, z)
    End Function

    
   
    
End Class


Public Class Point3D
    Public X As Double
    Public Y As Double
    Public Z As Double

    Public Sub New(ByVal xPoint As Double, _
          ByVal yPoint As Double, ByVal zPoint As Double)
        Me.X = xPoint
        Me.Y = yPoint
        Me.Z = zPoint
    End Sub

    Public Overrides Function Tostring() As String
        Return "{X=" & X & ",Y=" & Y & ",Z=" & Z & "}"
    End Function
End Class

Public Class Point2d
    'this differs from standard point in that x and y are double rather then int
    Public X As Double
    Public Y As Double


    Public Sub New(ByVal xPoint As Double, _
          ByVal yPoint As Double)
        Me.X = xPoint
        Me.Y = yPoint

    End Sub

    Public Overrides Function Tostring() As String
        Return "{X=" & X & ",Y=" & Y & "}"
    End Function
End Class
