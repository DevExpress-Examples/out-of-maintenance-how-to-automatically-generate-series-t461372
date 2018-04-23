#Region "#Model"
Namespace Bubbles
    Public Class IrisData

        Private species_Renamed As String

        Private sepalWidth_Renamed As Double

        Private sepalLength_Renamed As Double

        Private petalWidth_Renamed As Double

        Private petalLength_Renamed As Double

        Public ReadOnly Property Species() As String
            Get
                Return species_Renamed
            End Get
        End Property
        Public ReadOnly Property SepalWidth() As Double
            Get
                Return sepalWidth_Renamed
            End Get
        End Property
        Public ReadOnly Property SepalLength() As Double
            Get
                Return sepalLength_Renamed
            End Get
        End Property
        Public ReadOnly Property PetalWidth() As Double
            Get
                Return petalWidth_Renamed
            End Get
        End Property
        Public ReadOnly Property PetalLength() As Double
            Get
                Return petalLength_Renamed
            End Get
        End Property

        Public Sub New(ByVal species As String, ByVal sepalWidth As Double, ByVal sepalLength As Double, ByVal petalWidth As Double, ByVal petalLength As Double)
            Me.species_Renamed = species
            Me.sepalWidth_Renamed = sepalWidth
            Me.sepalLength_Renamed = sepalLength
            Me.petalWidth_Renamed = petalWidth
            Me.petalLength_Renamed = petalLength
        End Sub
    End Class
End Namespace
#End Region ' #Model