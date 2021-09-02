#Region "#Model"
Namespace Bubbles
	Public Class IrisData
'INSTANT VB NOTE: The field species was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private species_Conflict As String
'INSTANT VB NOTE: The field sepalWidth was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private sepalWidth_Conflict As Double
'INSTANT VB NOTE: The field sepalLength was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private sepalLength_Conflict As Double
'INSTANT VB NOTE: The field petalWidth was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private petalWidth_Conflict As Double
'INSTANT VB NOTE: The field petalLength was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private petalLength_Conflict As Double

		Public ReadOnly Property Species() As String
			Get
				Return species_Conflict
			End Get
		End Property
		Public ReadOnly Property SepalWidth() As Double
			Get
				Return sepalWidth_Conflict
			End Get
		End Property
		Public ReadOnly Property SepalLength() As Double
			Get
				Return sepalLength_Conflict
			End Get
		End Property
		Public ReadOnly Property PetalWidth() As Double
			Get
				Return petalWidth_Conflict
			End Get
		End Property
		Public ReadOnly Property PetalLength() As Double
			Get
				Return petalLength_Conflict
			End Get
		End Property

		Public Sub New(ByVal species As String, ByVal sepalWidth As Double, ByVal sepalLength As Double, ByVal petalWidth As Double, ByVal petalLength As Double)
			Me.species_Conflict = species
			Me.sepalWidth_Conflict = sepalWidth
			Me.sepalLength_Conflict = sepalLength
			Me.petalWidth_Conflict = petalWidth
			Me.petalLength_Conflict = petalLength
		End Sub
	End Class
End Namespace
#End Region ' #Model