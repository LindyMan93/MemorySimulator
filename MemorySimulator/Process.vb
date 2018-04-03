Public Class Process

    Private pID As Integer
    Private totaltextSize As Integer
    Private totaldataSize As Integer
    Private haltCommand As String = ""
    Private TextPagesRequired As Integer
    Private DataPagesRequired As Integer
    Private tPageTable As ArrayList = New ArrayList()
    Private dPageTable As ArrayList = New ArrayList()

    Public ReadOnly Property TextPageTable As ArrayList
        Get
            Return tPageTable
        End Get
    End Property

    Public ReadOnly Property DataPageTable As ArrayList
        Get
            Return dPageTable
        End Get
    End Property

    Public ReadOnly Property ProcessText As String
        Get
            If haltCommand.Equals("") Then
                Return pID & " " & totaltextSize & " " & totaldataSize
            Else
                Return pID & " " & haltCommand
            End If
        End Get
    End Property

    Public ReadOnly Property ProcessID() As Integer
        Get
            Return pID
        End Get
    End Property

    Public ReadOnly Property TextPages As Integer
        Get
            Return TextPagesRequired
        End Get
    End Property

    Public ReadOnly Property DataPages As Integer
        Get
            Return DataPagesRequired
        End Get
    End Property

    Public ReadOnly Property TextSize As Integer
        Get
            Return totaltextSize
        End Get
    End Property

    Public ReadOnly Property DataSize As Integer
        Get
            Return totaldataSize
        End Get
    End Property

    Public Sub New(ProcessID As Integer, TextSize As Integer, DataSize As Integer)

        pID = ProcessID
        totaltextSize = TextSize
        totaldataSize = DataSize

        TextPagesRequired = Math.Ceiling(totaltextSize / PageSize)
        DataPagesRequired = Math.Ceiling(totaldataSize / PageSize)

        For textFrame As Integer = 0 To TextPagesRequired - 1

            Dim temp As Frame = New Frame(pID, "Text", textFrame)
            TextPageTable.Add(temp)

        Next

        For dataFrame As Integer = 0 To DataPagesRequired - 1

            Dim temp As Frame = New Frame(pID, "Data", dataFrame)
            DataPageTable.Add(temp)

        Next

    End Sub

    Public Sub New(ProcessID As Integer, Command As String)

        pID = ProcessID
        haltCommand = Command

    End Sub

End Class

Public Class Frame

    Private pID As Integer
    Private Segment As String
    Private pageNumber As Integer
    Private frame As Integer
    Private fText As String

    Public Sub New(ProcessID As String, PageTableType As String, PageTableIndex As Integer)

        pID = ProcessID
        pageNumber = PageTableIndex

        If (PageTableType.Equals("Text")) Then

            Segment = "Text"

        End If

        If (PageTableType.Equals("Data")) Then

            Segment = "Data"

        End If

        fText = "P" & pID & " " & Segment & " " & pageNumber

    End Sub

    Public Sub New(ProcessID As String)

        pID = ProcessID
        fText = pID & " Halt"

    End Sub

    Public ReadOnly Property Page
        Get
            Return pageNumber
        End Get
    End Property

    Public ReadOnly Property ProcessID As Integer
        Get
            Return pID
        End Get
    End Property

    Public Property FrameNumber As Integer
        Get
            Return frame
        End Get
        Set(value As Integer)
            frame = value
        End Set
    End Property

    Public ReadOnly Property FrameText As String
        Get
            Return fText
        End Get
    End Property

End Class
