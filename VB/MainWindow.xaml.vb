Imports System.Windows
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports System.Windows.Media
Imports DevExpress.Xpf.Grid

Namespace DXGridSample
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class ViewModel
		Inherits BindableBase

		Public Property Countries() As ObservableCollection(Of String)
			Get
				Return GetValue(Of ObservableCollection(Of String))()
			End Get
			Set(ByVal value As ObservableCollection(Of String))
				SetValue(value)
			End Set
		End Property
		Public Property Items() As ObservableCollection(Of Item)
			Get
				Return GetValue(Of ObservableCollection(Of Item))()
			End Get
			Set(ByVal value As ObservableCollection(Of Item))
				SetValue(value)
			End Set
		End Property
		Public Property HighlightVisited() As Boolean
			Get
				Return GetValue(Of Boolean)()
			End Get
			Set(ByVal value As Boolean)
				SetValue(value)
			End Set
		End Property
		Public Sub New()
			Countries = New ObservableCollection(Of String) From {"USA", "Germany", "Russia"}
			Items = New ObservableCollection(Of Item)()
			Dim i As Integer = 0
			For Each country In Countries
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: Items.Add(new Item { Country = country, Visits = i++ });
				Items.Add(New Item With {
					.Country = country,
					.Visits = i
				})
				i += 1
			Next country
		End Sub
	End Class
	Public Class Item
		Inherits BindableBase

		Public Property Country() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
		Public Property Visits() As Integer
			Get
				Return GetValue(Of Integer)()
			End Get
			Set(ByVal value As Integer)
				SetValue(value)
			End Set
		End Property
		Public Property Color() As Color
			Get
				Return GetValue(Of Color)()
			End Get
			Set(ByVal value As Color)
				SetValue(value)
			End Set
		End Property
	End Class
End Namespace