Module Globals

    Public PhysicalMemory As Integer = 4096
    Public PageSize As Integer = 512
    Public NumberOfFrames As Integer = Math.Ceiling(PhysicalMemory / PageSize)

End Module
