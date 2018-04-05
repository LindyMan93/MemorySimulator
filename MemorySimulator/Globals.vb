''' <summary>
''' 
''' Author: Nathan Lindenbaum
''' Date: 4/1/2018
''' Assignment: Project 3 Memory Simulator
''' File: Globals.vb
''' 
''' Description:
''' 
''' This Module is used to set values for how large the "Memory"
''' can be. 
''' 
''' </summary>
Module Globals

    Public PhysicalMemory As Integer = 4096
    Public PageSize As Integer = 512
    Public NumberOfFrames As Integer = Math.Ceiling(PhysicalMemory / PageSize)

End Module
