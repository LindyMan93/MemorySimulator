''' <summary>
''' 
''' Author: Nathan Lindenbaum
''' Date: 4/3/2018
''' Assignment: Project 3 Memory Simulator
''' File: Process.vb
''' 
''' Description:
''' 
''' This class is used to create each process. It also has a helper class Frame
''' to create each frame required by the process.
''' 
''' </summary>
Public Class Process

    Private pID As Integer
    Private totaltextSize As Integer
    Private totaldataSize As Integer
    Private haltCommand As String = ""
    Private TextPagesRequired As Integer
    Private DataPagesRequired As Integer
    Private tPageTable As ArrayList = New ArrayList()
    Private dPageTable As ArrayList = New ArrayList()

    ''' <summary>
    ''' Returns the arraylist of the textpagetable to the user.
    ''' </summary>
    ''' <value>
    ''' The text page table.
    ''' </value>
    Public ReadOnly Property TextPageTable As ArrayList
        Get
            Return tPageTable
        End Get
    End Property

    ''' <summary>
    ''' Returns the arraylist of the datapagetable to the user.
    ''' </summary>
    ''' <value>
    ''' The data page table.
    ''' </value>
    Public ReadOnly Property DataPageTable As ArrayList
        Get
            Return dPageTable
        End Get
    End Property

    ''' <summary>
    ''' Returns the information about the process.
    ''' ProcessID - Text Size - Data Size
    ''' </summary>
    ''' <value>
    ''' The process text.
    ''' </value>
    Public ReadOnly Property ProcessText As String
        Get
            If haltCommand.Equals("") Then
                Return pID & " " & totaltextSize & " " & totaldataSize
            Else
                Return pID & " " & haltCommand
            End If
        End Get
    End Property

    ''' <summary>
    ''' Gets the process identifier.
    ''' </summary>
    ''' <value>
    ''' The process identifier.
    ''' </value>
    Public ReadOnly Property ProcessID() As Integer
        Get
            Return pID
        End Get
    End Property

    ''' <summary>
    ''' Returns the number of frames required for this process's 
    ''' text.
    ''' </summary>
    ''' <value>
    ''' The text pages.
    ''' </value>
    Public ReadOnly Property TextPages As Integer
        Get
            Return TextPagesRequired
        End Get
    End Property

    ''' <summary>
    ''' Returns the number of frames required for this process's 
    ''' data.
    ''' </summary>
    ''' <value>
    ''' The data pages.
    ''' </value>
    Public ReadOnly Property DataPages As Integer
        Get
            Return DataPagesRequired
        End Get
    End Property

    ''' <summary>
    ''' Gets the size of the text.
    ''' </summary>
    ''' <value>
    ''' The size of the text.
    ''' </value>
    Public ReadOnly Property TextSize As Integer
        Get
            Return totaltextSize
        End Get
    End Property

    ''' <summary>
    ''' Gets the size of the data.
    ''' </summary>
    ''' <value>
    ''' The size of the data.
    ''' </value>
    Public ReadOnly Property DataSize As Integer
        Get
            Return totaldataSize
        End Get
    End Property


    ''' <summary>
    ''' Initializes a new instance of the <see cref="Process"/> class for a 
    ''' standard process.
    ''' </summary>
    ''' <param name="ProcessID">The process identifier.</param>
    ''' <param name="TextSize">Size of the text.</param>
    ''' <param name="DataSize">Size of the data.</param>
    Public Sub New(ProcessID As Integer, TextSize As Integer, DataSize As Integer)

        pID = ProcessID
        totaltextSize = TextSize
        totaldataSize = DataSize

        ' Round amount of pages up
        TextPagesRequired = Math.Ceiling(totaltextSize / PageSize)
        DataPagesRequired = Math.Ceiling(totaldataSize / PageSize)

        ' Create new frame for each required text frame
        For textFrame As Integer = 0 To TextPagesRequired - 1

            Dim temp As Frame = New Frame(pID, "Text", textFrame)
            TextPageTable.Add(temp)

        Next

        ' Create new frame for each required data frame
        For dataFrame As Integer = 0 To DataPagesRequired - 1

            Dim temp As Frame = New Frame(pID, "Data", dataFrame)
            DataPageTable.Add(temp)

        Next

    End Sub

    ''' <summary>
    ''' Initializes a new instance of the <see cref="Process"/> class
    ''' for a halt process.
    ''' </summary>
    ''' <param name="ProcessID">The process identifier.</param>
    ''' <param name="Command">The command.</param>
    Public Sub New(ProcessID As Integer, Command As String)

        pID = ProcessID
        haltCommand = Command

    End Sub

End Class

''' <summary>
''' 
''' Author: Nathan Lindenbaum
''' Date: 4/3/2018
''' Assignment: Project 3 Memory Simulator
''' File: Process.vb
''' 
''' Description:
''' 
''' This class is used to create each frame required for a process. 
''' 
''' </summary>
Public Class Frame

    Private pID As Integer
    Private Segment As String
    Private pageNumber As Integer
    Private frame As Integer = -1
    Private fText As String

    ''' <summary>
    ''' Initializes a new instance of the <see cref="Frame"/> class for a standard process.
    ''' </summary>
    ''' <param name="ProcessID">The process identifier.</param>
    ''' <param name="PageTableType">Type of the page table.</param>
    ''' <param name="PageTableIndex">Index of the page table.</param>
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

    ''' <summary>
    ''' Initializes a new instance of the <see cref="Frame"/> class for a halt process.
    ''' </summary>
    ''' <param name="ProcessID">The process identifier.</param>
    Public Sub New(ProcessID As String)

        pID = ProcessID
        fText = pID & " Halt"

    End Sub

    ''' <summary>
    ''' Returns this frames page number.
    ''' </summary>
    ''' <value>
    ''' The page.
    ''' </value>
    Public ReadOnly Property Page
        Get
            Return pageNumber
        End Get
    End Property

    ''' <summary>
    ''' Gets the process identifier.
    ''' </summary>
    ''' <value>
    ''' The process identifier.
    ''' </value>
    Public ReadOnly Property ProcessID As Integer
        Get
            Return pID
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the frame number for the frame.
    ''' </summary>
    ''' <value>
    ''' The frame number.
    ''' </value>
    Public Property FrameNumber As Integer
        Get
            Return frame
        End Get
        Set(value As Integer)
            frame = value
        End Set
    End Property

    ''' <summary>
    ''' Gets the frame text.
    ''' </summary>
    ''' <value>
    ''' The frame text.
    ''' </value>
    Public ReadOnly Property FrameText As String
        Get
            Return fText
        End Get
    End Property

End Class
