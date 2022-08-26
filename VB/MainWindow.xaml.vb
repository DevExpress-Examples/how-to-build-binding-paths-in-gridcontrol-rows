Imports System.Windows
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports System.Windows.Media
Imports DevExpress.Xpf.Grid

Namespace DXGridSample

    Public Partial Class MainWindow
        Inherits System.Windows.Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ViewModel
        Inherits DevExpress.Mvvm.BindableBase

        Public Property Countries As ObservableCollection(Of String)
            Get
                Return GetValue(Of System.Collections.ObjectModel.ObservableCollection(Of String))()
            End Get

            Set(ByVal value As ObservableCollection(Of String))
                SetValue(value)
            End Set
        End Property

        Public Property Items As ObservableCollection(Of DXGridSample.Item)
            Get
                Return GetValue(Of System.Collections.ObjectModel.ObservableCollection(Of DXGridSample.Item))()
            End Get

            Set(ByVal value As ObservableCollection(Of DXGridSample.Item))
                SetValue(value)
            End Set
        End Property

        Public Property HighlightVisited As Boolean
            Get
                Return GetValue(Of Boolean)()
            End Get

            Set(ByVal value As Boolean)
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            Me.Countries = New System.Collections.ObjectModel.ObservableCollection(Of String) From {"USA", "Germany", "Russia"}
            Me.Items = New System.Collections.ObjectModel.ObservableCollection(Of DXGridSample.Item)()
            Dim i As Integer = 0
            For Each country In Me.Countries
                Me.Items.Add(New DXGridSample.Item With {.Country = country, .Visits = System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)})
            Next
        End Sub
    End Class

    Public Class Item
        Inherits DevExpress.Mvvm.BindableBase

        Public Property Country As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property Visits As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property

        Public Property Color As Color
            Get
                Return GetValue(Of System.Windows.Media.Color)()
            End Get

            Set(ByVal value As Color)
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace
