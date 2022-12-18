#Region "#Model"
Namespace Bubbles

    Public Class IrisData

        Private speciesField As String

        Private sepalWidthField As Double

        Private sepalLengthField As Double

        Private petalWidthField As Double

        Private petalLengthField As Double

        Public ReadOnly Property Species As String
            Get
                Return speciesField
            End Get
        End Property

        Public ReadOnly Property SepalWidth As Double
            Get
                Return sepalWidthField
            End Get
        End Property

        Public ReadOnly Property SepalLength As Double
            Get
                Return sepalLengthField
            End Get
        End Property

        Public ReadOnly Property PetalWidth As Double
            Get
                Return petalWidthField
            End Get
        End Property

        Public ReadOnly Property PetalLength As Double
            Get
                Return petalLengthField
            End Get
        End Property

        Public Sub New(ByVal species As String, ByVal sepalWidth As Double, ByVal sepalLength As Double, ByVal petalWidth As Double, ByVal petalLength As Double)
            speciesField = species
            sepalWidthField = sepalWidth
            sepalLengthField = sepalLength
            petalWidthField = petalWidth
            petalLengthField = petalLength
        End Sub
    End Class
End Namespace
#End Region  ' #Model
