Public MustInherit Class ShapeBase
    Implements IIdentifiable


    Private _id As Integer
    Private _isDirty As Boolean
    Private _renderingProvider As IRenderingProvider

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public ReadOnly Property IsDirty() As Boolean
        Get
            Return _isDirty
        End Get
    End Property

    Public WriteOnly Property RenderingProvider() As IRenderingProvider
        Set(ByVal value As IRenderingProvider)
            _renderingProvider = value
        End Set
    End Property

    Public Sub New()
        Me.New(New DefaultRenderingProvider())
    End Sub

    Public Sub New(provider As IRenderingProvider)
        Console.WriteLine(String.Format("Constructor ({0}, provider = {1}) [ShapeBase]", Me.GetType().Name, provider.GetType().Name))

        Me.RenderingProvider = provider
    End Sub

    Shared Sub New()
        Console.WriteLine()
        Console.WriteLine("Constructor - Static [ShapeBase]")
        Console.WriteLine()
    End Sub

    Protected Overrides Sub Finalize()
        ' clean up
    End Sub

    Public MustOverride Sub Fill(colorName As String)

    Public Overridable Sub Draw()
        Me._renderingProvider.Render()
    End Sub

    Public Overridable Function Identify() As String Implements IIdentifiable.Identify
        Return "Identify [ShapeBase]"
    End Function
End Class
