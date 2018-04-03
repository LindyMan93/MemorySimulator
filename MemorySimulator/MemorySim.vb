Public Class MemorySim

    Dim PhysicalMemoryFrames As LinkedList(Of Frame) = New LinkedList(Of Frame)
    Dim AllPossibleFrames As ArrayList = New ArrayList()
    Dim AllProcesses As ArrayList = New ArrayList()
    Dim framePtr As Integer

    Public Sub On_Load() Handles Me.Load

        Dim p0 As Process = New Process(0, 1044, 940)
        Dim p1 As Process = New Process(1, 536, 256)
        Dim p0h As Process = New Process(0, "Halt")
        Dim p2 As Process = New Process(2, 437, 128)
        Dim p3 As Process = New Process(3, 434, 414)
        Dim p2h As Process = New Process(2, "Halt")
        Dim p4 As Process = New Process(4, 972, 278)
        Dim p3h As Process = New Process(3, "Halt")
        Dim p1h As Process = New Process(1, "Halt")
        Dim p4h As Process = New Process(4, "Halt")

        AllProcesses.Add(p0)
        AllProcesses.Add(p1)
        AllProcesses.Add(p0h)
        AllProcesses.Add(p2)
        AllProcesses.Add(p3)
        AllProcesses.Add(p2h)
        AllProcesses.Add(p4)
        AllProcesses.Add(p3h)
        AllProcesses.Add(p1h)
        AllProcesses.Add(p4h)

        For Each process As Process In AllProcesses

            Dim tempTextTable As ArrayList = process.TextPageTable
            Dim tempDataTable As ArrayList = process.DataPageTable

            For Each frame As Frame In tempTextTable

                AllPossibleFrames.Add(frame)

            Next

            For Each frame As Frame In tempDataTable

                AllPossibleFrames.Add(frame)

            Next

            If process.ProcessText.Contains("Halt") Then
                Dim tempFrame As Frame = New Frame(process.ProcessID)
                AllPossibleFrames.Add(tempFrame)
            End If

        Next

        'MsgBox("P0 -- Text Pages: " & p0.TextPages & " Data Pages: " & p0.DataPages)
        'MsgBox("P1 -- Text Pages: " & p1.TextPages & " Data Pages: " & p1.DataPages)

        For Each process As Process In AllProcesses

            instructions.Rows.Add(process.ProcessText)

        Next


    End Sub

    Public Sub On_Next_Click() Handles nextButton.Click

        Dim frameToExecute As Frame = AllPossibleFrames.Item(0)
        Dim deleteFrames As ArrayList = New ArrayList()

        If frameToExecute.FrameText.Contains("Halt") Then

            For Each frame As Frame In PhysicalMemoryFrames

                If frame.ProcessID = frameToExecute.ProcessID Then

                    'PhysicalMemoryFrames.Remove(frame)
                    deleteFrames.Add(frame)

                End If

            Next

            For Each frame As Frame In deleteFrames

                PhysicalMemoryFrames.Remove(frame)

            Next

        Else

            PhysicalMemoryFrames.AddFirst(frameToExecute)
            'framePtr = framePtr -1

        End If

        AllPossibleFrames.RemoveAt(0)
        updateButtons()
        If AllPossibleFrames.Count() < 1 Then
            nextButton.Enabled = False
        End If
        Dim framePtr = 0
        For Each frame As Frame In PhysicalMemoryFrames

            frame.FrameNumber() = framePtr

        Next

    End Sub

    Public Sub updateButtons()

        Try
            frameZeroButton.Text = PhysicalMemoryFrames(7).FrameText
        Catch ex As Exception
            frameZeroButton.Text = ""
        End Try

        Try
            frameOneButton.Text = PhysicalMemoryFrames(6).FrameText
        Catch ex As Exception
            frameOneButton.Text = ""
        End Try

        Try
            frameTwoButton.Text = PhysicalMemoryFrames(5).FrameText
        Catch ex As Exception
            frameTwoButton.Text = ""
        End Try

        Try
            frameThreeButton.Text = PhysicalMemoryFrames(4).FrameText
        Catch ex As Exception
            frameThreeButton.Text = ""
        End Try

        Try
            frameFourButton.Text = PhysicalMemoryFrames(3).FrameText
        Catch ex As Exception
            frameFourButton.Text = ""
        End Try

        Try
            frameFiveButton.Text = PhysicalMemoryFrames(2).FrameText
        Catch ex As Exception
            frameFiveButton.Text = ""
        End Try

        Try
            frameSixButton.Text = PhysicalMemoryFrames(1).FrameText
        Catch ex As Exception
            frameSixButton.Text = ""
        End Try

        Try
            frameSevenButton.Text = PhysicalMemoryFrames(0).FrameText
        Catch ex As Exception
            frameSevenButton.Text = ""
        End Try


    End Sub

    Public Sub FrameZeroButton_Click() Handles frameZeroButton.Click

        Dim selectedProcID = PhysicalMemoryFrames(7).ProcessID
        TPTGrid.Rows.Clear()
        DPTGrid.Rows.Clear()

        For Each process As Process In AllProcesses

            If process.ProcessID = selectedProcID Then

                For Each frame As Frame In process.TextPageTable
                    TPTGrid.Rows.Add(New Object() {frame.Page, frame.FrameNumber})
                Next
                For Each frame As Frame In process.DataPageTable
                    DPTGrid.Rows.Add(New Object() {frame.Page, frame.FrameNumber})
                Next

            End If

        Next

    End Sub

    Public Sub ShowPageTables(ProcessID As Integer)



    End Sub

End Class
