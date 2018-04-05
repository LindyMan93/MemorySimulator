Imports System.IO

''' <summary>
''' 
''' Author: Nathan Lindenbaum
''' Date: 4/1/2018
''' Assignment: Project 3 Memory Simulator
''' File: MemorySim.vb
''' 
''' Description:
''' 
''' This class handles all functions of the GUI. It will update all aspects of
''' of the GUI based on user actions. It shows all loaded instructions (Processes).
''' 
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class MemorySim

    Dim PhysicalMemoryFrames As LinkedList(Of Frame) = New LinkedList(Of Frame)
    Dim AllPossibleFrames As ArrayList = New ArrayList()
    Dim AllProcesses As ArrayList = New ArrayList()
    Dim framePtr As Integer

    ''' <summary>
    ''' This process is called after a user selected file has been parsed.
    ''' it will take each process in AllProcesses and create all required
    ''' frames for the processes.
    ''' </summary>
    Public Sub CreateProcesses()

        ' iterate thru each process and create a frame without
        ' a frame number
        For Each process As Process In AllProcesses

            Dim tempTextTable As ArrayList = process.TextPageTable
            Dim tempDataTable As ArrayList = process.DataPageTable

            For Each frame As Frame In tempTextTable

                AllPossibleFrames.Add(frame)

            Next

            For Each frame As Frame In tempDataTable

                AllPossibleFrames.Add(frame)

            Next

            ' Using overloaded constructor to create halt process.
            If process.ProcessText.Contains("Halt") Then
                Dim tempFrame As Frame = New Frame(process.ProcessID)
                AllPossibleFrames.Add(tempFrame)
            End If

        Next

        ' Adding processes to GUI to see all have loaded correctly
        For Each process As Process In AllProcesses

            instructions.Rows.Add(process.ProcessText)

        Next

    End Sub

    ''' <summary>
    ''' This is called when the hits the next button. It will load
    ''' the a frame from AllPossibleFrames into the linkedlist of
    ''' PhysicalMemoryFrames. It adds it to the first spot, which
    ''' really means it will be added to frame 7
    ''' </summary>
    Public Sub On_Next_Click() Handles nextButton.Click

        ' Getting most recent frame
        Dim frameToExecute As Frame = AllPossibleFrames.Item(0)
        ' Creating arraylist of frames to delete
        Dim deleteFrames As ArrayList = New ArrayList()
        ' Creating arraylist of processes to delete
        Dim deleteProc As ArrayList = New ArrayList()

        ' If the process is a halt command it will find all
        ' frames of the same process and add it to the 
        ' deleteframes arraylist
        If frameToExecute.FrameText.Contains("Halt") Then

            For Each frame As Frame In PhysicalMemoryFrames

                If frame.ProcessID = frameToExecute.ProcessID Then

                    'PhysicalMemoryFrames.Remove(frame)
                    deleteFrames.Add(frame)

                End If

            Next

            ' remove all frames in PhysicalMemoryFrames that are
            ' equal to the frame in deleteFrames
            For Each frame As Frame In deleteFrames

                PhysicalMemoryFrames.Remove(frame)

            Next

            For Each process As Process In AllProcesses

                If process.ProcessID = frameToExecute.ProcessID Then

                    deleteProc.Add(process)

                End If

            Next

            ' Removing processes from user visibility
            For Each process As Process In deleteProc

                AllProcesses.Remove(process)

            Next

            instructions.Rows.Clear()
            For Each process As Process In AllProcesses

                instructions.Rows.Add(process.ProcessText)

            Next

            ' If the process is not a halt command, add it to frame 7
        Else

            PhysicalMemoryFrames.AddFirst(frameToExecute)
            'framePtr = framePtr -1

        End If

        ' remove this frame from the frame list
        AllPossibleFrames.RemoveAt(0)

        ' update the frame buttons
        updateButtons()

        ' if there are no frames to be loaded disable
        ' disable the next button
        If AllPossibleFrames.Count() < 1 Then
            nextButton.Enabled = False
        End If

        ' This sets the frame number in each of the processes
        ' page tables.
        Dim framePtr = 7
        For Each frame As Frame In PhysicalMemoryFrames

            frame.FrameNumber() = framePtr
            framePtr = framePtr - 1

        Next

    End Sub

    ''' <summary>
    ''' Opens a OpenFileDialog to select file.
    ''' </summary>
    Public Sub OpenFile_Click() Handles openFileButton.Click

        OpenFileDialog.ShowDialog()

    End Sub

    ''' <summary>
    ''' Once the user has selected a file, send to ReadFile.
    ''' </summary>
    Private Sub OpenFileDialog_FileOk() Handles OpenFileDialog.FileOk

        'MsgBox(OpenFileDialog.FileName)
        Dim filePath As String = OpenFileDialog.FileName
        ReadFile(filePath)

    End Sub

    ''' <summary>
    ''' Reads the file selected by user and adds each possible process
    ''' to AllProcesses.
    ''' </summary>
    ''' <param name="Path">The path.</param>
    Public Sub ReadFile(Path As String)
        Dim line As String
        Dim lineParts() As String
        Dim sr As StreamReader = New StreamReader(Path)
        Do While sr.Peek() >= 0
            'MsgBox(sr.ReadLine())
            line = sr.ReadLine()

            ' Split line into parts
            lineParts = line.Split()

            ' If line is halt command
            If lineParts.Count() = 2 Then

                'MsgBox(lineParts(0) & " " & lineParts(1))
                Dim temp As Process = New Process(Convert.ToInt32(lineParts(0)), lineParts(1))
                AllProcesses.Add(temp)

                ' if line is regular process
            ElseIf lineParts.Count() = 3 Then

                'MsgBox(lineParts(0) & " " & lineParts(1) & " " & lineParts(2))
                Dim temp As Process = New Process(Convert.ToInt32(lineParts(0)), Convert.ToInt32(lineParts(1)), Convert.ToInt32(lineParts(2)))
                AllProcesses.Add(temp)

            Else

                MsgBox("Unable to Add Process: " & line)

            End If


        Loop
        sr.Close()

        ' If there has been processes loaded, then enable the next button
        If AllProcesses.Count() > 0 Then

            CreateProcesses()
            nextButton.Enabled = True

        End If

    End Sub

    ' All Frame Button Methods
#Region "Frame Button Methods"
    ''' <summary>
    ''' Updates the text shown on the frame buttons. When a frame is loaded
    ''' into a certain button, it will reflect that by showing the frame text
    ''' on the button. Clicking the buttons will allow the user to see each 
    ''' page table.
    ''' </summary>
    Public Sub updateButtons()

        ' Try to get text of frame in PhysicalMemoryFrames
        ' if it doesnt exist disable button and clear text
        ' else set text to correct frame text and enable button
        '
        ' This process is the same for each frame.
        Try
            frameZeroButton.Text = PhysicalMemoryFrames(7).FrameText
            frameZeroButton.Enabled = True
        Catch ex As Exception
            frameZeroButton.Text = ""
            frameZeroButton.Enabled = False
        End Try

        Try
            frameOneButton.Text = PhysicalMemoryFrames(6).FrameText
            frameOneButton.Enabled = True
        Catch ex As Exception
            frameOneButton.Text = ""
            frameOneButton.Enabled = False
        End Try

        Try
            frameTwoButton.Text = PhysicalMemoryFrames(5).FrameText
            frameTwoButton.Enabled = True
        Catch ex As Exception
            frameTwoButton.Text = ""
            frameTwoButton.Enabled = False
        End Try

        Try
            frameThreeButton.Text = PhysicalMemoryFrames(4).FrameText
            frameThreeButton.Enabled = True
        Catch ex As Exception
            frameThreeButton.Text = ""
            frameThreeButton.Enabled = False
        End Try

        Try
            frameFourButton.Text = PhysicalMemoryFrames(3).FrameText
            frameFourButton.Enabled = True
        Catch ex As Exception
            frameFourButton.Text = ""
            frameFourButton.Enabled = False
        End Try

        Try
            frameFiveButton.Text = PhysicalMemoryFrames(2).FrameText
            frameFiveButton.Enabled = True
        Catch ex As Exception
            frameFiveButton.Text = ""
            frameFiveButton.Enabled = False
        End Try

        Try
            frameSixButton.Text = PhysicalMemoryFrames(1).FrameText
            frameSixButton.Enabled = True
        Catch ex As Exception
            frameSixButton.Text = ""
            frameSixButton.Enabled = False
        End Try

        Try
            frameSevenButton.Text = PhysicalMemoryFrames(0).FrameText
            frameSevenButton.Enabled = True
        Catch ex As Exception
            frameSevenButton.Text = ""
            frameSevenButton.Enabled = False
        End Try


    End Sub

    ''' <summary>
    ''' On button click update page tables to current process page tables.
    ''' 
    ''' This process is used for all frame buttons.
    ''' </summary>
    Public Sub FrameZeroButton_Click() Handles frameZeroButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(7).ProcessID
        ShowPageTables(selectedProcID)

    End Sub

    Public Sub FrameOneButton_Click() Handles frameOneButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(6).ProcessID
        ShowPageTables(selectedProcID)

    End Sub

    Public Sub FrameTwoButton_Click() Handles frameTwoButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(5).ProcessID
        ShowPageTables(selectedProcID)

    End Sub

    Public Sub FrameThreeButton_Click() Handles frameThreeButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(4).ProcessID
        ShowPageTables(selectedProcID)

    End Sub

    Public Sub FrameFourButton_Click() Handles frameFourButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(3).ProcessID
        ShowPageTables(selectedProcID)

    End Sub

    Public Sub FrameFiveButton_Click() Handles frameFiveButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(2).ProcessID
        ShowPageTables(selectedProcID)

    End Sub

    Public Sub FrameSixButton_Click() Handles frameSixButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(1).ProcessID
        ShowPageTables(selectedProcID)

    End Sub

    Public Sub FrameSevenButton_Click() Handles frameSevenButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(0).ProcessID
        ShowPageTables(selectedProcID)

    End Sub

    Public Sub ShowPageTables(ProcessID As Integer)

        TPTGrid.Rows.Clear()
        DPTGrid.Rows.Clear()

        For Each process As Process In AllProcesses

            If process.ProcessID = ProcessID Then

                For Each frame As Frame In process.TextPageTable
                    TPTGrid.Rows.Add(New Object() {frame.Page, frame.FrameNumber})
                Next
                For Each frame As Frame In process.DataPageTable
                    DPTGrid.Rows.Add(New Object() {frame.Page, frame.FrameNumber})
                Next

            End If

        Next

    End Sub

    Private Sub MemorySim_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class
