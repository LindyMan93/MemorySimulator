<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemorySim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemorySim))
        Me.physicalMemoryBox = New System.Windows.Forms.GroupBox()
        Me.frameSevenL = New System.Windows.Forms.Label()
        Me.frameSixL = New System.Windows.Forms.Label()
        Me.frameFiveL = New System.Windows.Forms.Label()
        Me.frameFourL = New System.Windows.Forms.Label()
        Me.frameThreeL = New System.Windows.Forms.Label()
        Me.frameTwoL = New System.Windows.Forms.Label()
        Me.frameOneL = New System.Windows.Forms.Label()
        Me.frameSevenButton = New System.Windows.Forms.Button()
        Me.frameSixButton = New System.Windows.Forms.Button()
        Me.frameFiveButton = New System.Windows.Forms.Button()
        Me.frameFourButton = New System.Windows.Forms.Button()
        Me.frameThreeButton = New System.Windows.Forms.Button()
        Me.frameTwoButton = New System.Windows.Forms.Button()
        Me.frameOneButton = New System.Windows.Forms.Button()
        Me.frameZeroL = New System.Windows.Forms.Label()
        Me.frameZeroButton = New System.Windows.Forms.Button()
        Me.textPageBox = New System.Windows.Forms.GroupBox()
        Me.TPTGrid = New System.Windows.Forms.DataGridView()
        Me.pNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPageBox = New System.Windows.Forms.GroupBox()
        Me.DPTGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.openFileButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.instructionsBox = New System.Windows.Forms.GroupBox()
        Me.instructions = New System.Windows.Forms.DataGridView()
        Me.procs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.physicalMemoryBox.SuspendLayout()
        Me.textPageBox.SuspendLayout()
        CType(Me.TPTGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataPageBox.SuspendLayout()
        CType(Me.DPTGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.instructionsBox.SuspendLayout()
        CType(Me.instructions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'physicalMemoryBox
        '
        Me.physicalMemoryBox.Controls.Add(Me.frameSevenL)
        Me.physicalMemoryBox.Controls.Add(Me.frameSixL)
        Me.physicalMemoryBox.Controls.Add(Me.frameFiveL)
        Me.physicalMemoryBox.Controls.Add(Me.frameFourL)
        Me.physicalMemoryBox.Controls.Add(Me.frameThreeL)
        Me.physicalMemoryBox.Controls.Add(Me.frameTwoL)
        Me.physicalMemoryBox.Controls.Add(Me.frameOneL)
        Me.physicalMemoryBox.Controls.Add(Me.frameSevenButton)
        Me.physicalMemoryBox.Controls.Add(Me.frameSixButton)
        Me.physicalMemoryBox.Controls.Add(Me.frameFiveButton)
        Me.physicalMemoryBox.Controls.Add(Me.frameFourButton)
        Me.physicalMemoryBox.Controls.Add(Me.frameThreeButton)
        Me.physicalMemoryBox.Controls.Add(Me.frameTwoButton)
        Me.physicalMemoryBox.Controls.Add(Me.frameOneButton)
        Me.physicalMemoryBox.Controls.Add(Me.frameZeroL)
        Me.physicalMemoryBox.Controls.Add(Me.frameZeroButton)
        Me.physicalMemoryBox.Location = New System.Drawing.Point(178, 12)
        Me.physicalMemoryBox.Name = "physicalMemoryBox"
        Me.physicalMemoryBox.Size = New System.Drawing.Size(171, 256)
        Me.physicalMemoryBox.TabIndex = 0
        Me.physicalMemoryBox.TabStop = False
        Me.physicalMemoryBox.Text = "Physical Memory"
        '
        'frameSevenL
        '
        Me.frameSevenL.AutoSize = True
        Me.frameSevenL.Location = New System.Drawing.Point(6, 228)
        Me.frameSevenL.Name = "frameSevenL"
        Me.frameSevenL.Size = New System.Drawing.Size(45, 13)
        Me.frameSevenL.TabIndex = 21
        Me.frameSevenL.Text = "Frame 7"
        '
        'frameSixL
        '
        Me.frameSixL.AutoSize = True
        Me.frameSixL.Location = New System.Drawing.Point(6, 199)
        Me.frameSixL.Name = "frameSixL"
        Me.frameSixL.Size = New System.Drawing.Size(45, 13)
        Me.frameSixL.TabIndex = 20
        Me.frameSixL.Text = "Frame 6"
        '
        'frameFiveL
        '
        Me.frameFiveL.AutoSize = True
        Me.frameFiveL.Location = New System.Drawing.Point(6, 170)
        Me.frameFiveL.Name = "frameFiveL"
        Me.frameFiveL.Size = New System.Drawing.Size(45, 13)
        Me.frameFiveL.TabIndex = 19
        Me.frameFiveL.Text = "Frame 5"
        '
        'frameFourL
        '
        Me.frameFourL.AutoSize = True
        Me.frameFourL.Location = New System.Drawing.Point(6, 139)
        Me.frameFourL.Name = "frameFourL"
        Me.frameFourL.Size = New System.Drawing.Size(45, 13)
        Me.frameFourL.TabIndex = 18
        Me.frameFourL.Text = "Frame 4"
        '
        'frameThreeL
        '
        Me.frameThreeL.AutoSize = True
        Me.frameThreeL.Location = New System.Drawing.Point(6, 112)
        Me.frameThreeL.Name = "frameThreeL"
        Me.frameThreeL.Size = New System.Drawing.Size(45, 13)
        Me.frameThreeL.TabIndex = 17
        Me.frameThreeL.Text = "Frame 3"
        '
        'frameTwoL
        '
        Me.frameTwoL.AutoSize = True
        Me.frameTwoL.Location = New System.Drawing.Point(6, 83)
        Me.frameTwoL.Name = "frameTwoL"
        Me.frameTwoL.Size = New System.Drawing.Size(45, 13)
        Me.frameTwoL.TabIndex = 16
        Me.frameTwoL.Text = "Frame 2"
        '
        'frameOneL
        '
        Me.frameOneL.AutoSize = True
        Me.frameOneL.Location = New System.Drawing.Point(6, 54)
        Me.frameOneL.Name = "frameOneL"
        Me.frameOneL.Size = New System.Drawing.Size(45, 13)
        Me.frameOneL.TabIndex = 15
        Me.frameOneL.Text = "Frame 1"
        '
        'frameSevenButton
        '
        Me.frameSevenButton.Enabled = False
        Me.frameSevenButton.Location = New System.Drawing.Point(57, 223)
        Me.frameSevenButton.Name = "frameSevenButton"
        Me.frameSevenButton.Size = New System.Drawing.Size(102, 23)
        Me.frameSevenButton.TabIndex = 14
        Me.frameSevenButton.UseVisualStyleBackColor = True
        '
        'frameSixButton
        '
        Me.frameSixButton.Enabled = False
        Me.frameSixButton.Location = New System.Drawing.Point(57, 194)
        Me.frameSixButton.Name = "frameSixButton"
        Me.frameSixButton.Size = New System.Drawing.Size(102, 23)
        Me.frameSixButton.TabIndex = 12
        Me.frameSixButton.UseVisualStyleBackColor = True
        '
        'frameFiveButton
        '
        Me.frameFiveButton.Enabled = False
        Me.frameFiveButton.Location = New System.Drawing.Point(57, 165)
        Me.frameFiveButton.Name = "frameFiveButton"
        Me.frameFiveButton.Size = New System.Drawing.Size(102, 23)
        Me.frameFiveButton.TabIndex = 10
        Me.frameFiveButton.UseVisualStyleBackColor = True
        '
        'frameFourButton
        '
        Me.frameFourButton.Enabled = False
        Me.frameFourButton.Location = New System.Drawing.Point(57, 136)
        Me.frameFourButton.Name = "frameFourButton"
        Me.frameFourButton.Size = New System.Drawing.Size(102, 23)
        Me.frameFourButton.TabIndex = 8
        Me.frameFourButton.UseVisualStyleBackColor = True
        '
        'frameThreeButton
        '
        Me.frameThreeButton.Enabled = False
        Me.frameThreeButton.Location = New System.Drawing.Point(57, 107)
        Me.frameThreeButton.Name = "frameThreeButton"
        Me.frameThreeButton.Size = New System.Drawing.Size(102, 23)
        Me.frameThreeButton.TabIndex = 6
        Me.frameThreeButton.UseVisualStyleBackColor = True
        '
        'frameTwoButton
        '
        Me.frameTwoButton.Enabled = False
        Me.frameTwoButton.Location = New System.Drawing.Point(57, 78)
        Me.frameTwoButton.Name = "frameTwoButton"
        Me.frameTwoButton.Size = New System.Drawing.Size(102, 23)
        Me.frameTwoButton.TabIndex = 4
        Me.frameTwoButton.UseVisualStyleBackColor = True
        '
        'frameOneButton
        '
        Me.frameOneButton.Enabled = False
        Me.frameOneButton.Location = New System.Drawing.Point(57, 49)
        Me.frameOneButton.Name = "frameOneButton"
        Me.frameOneButton.Size = New System.Drawing.Size(102, 23)
        Me.frameOneButton.TabIndex = 2
        Me.frameOneButton.UseVisualStyleBackColor = True
        '
        'frameZeroL
        '
        Me.frameZeroL.AutoSize = True
        Me.frameZeroL.Location = New System.Drawing.Point(6, 25)
        Me.frameZeroL.Name = "frameZeroL"
        Me.frameZeroL.Size = New System.Drawing.Size(45, 13)
        Me.frameZeroL.TabIndex = 1
        Me.frameZeroL.Text = "Frame 0"
        '
        'frameZeroButton
        '
        Me.frameZeroButton.Enabled = False
        Me.frameZeroButton.Location = New System.Drawing.Point(57, 20)
        Me.frameZeroButton.Name = "frameZeroButton"
        Me.frameZeroButton.Size = New System.Drawing.Size(102, 23)
        Me.frameZeroButton.TabIndex = 0
        Me.frameZeroButton.UseVisualStyleBackColor = True
        '
        'textPageBox
        '
        Me.textPageBox.Controls.Add(Me.TPTGrid)
        Me.textPageBox.Location = New System.Drawing.Point(355, 12)
        Me.textPageBox.Name = "textPageBox"
        Me.textPageBox.Size = New System.Drawing.Size(162, 130)
        Me.textPageBox.TabIndex = 1
        Me.textPageBox.TabStop = False
        Me.textPageBox.Text = "Text Page Table"
        '
        'TPTGrid
        '
        Me.TPTGrid.AllowUserToAddRows = False
        Me.TPTGrid.AllowUserToDeleteRows = False
        Me.TPTGrid.AllowUserToResizeRows = False
        Me.TPTGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TPTGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pNum, Me.fNum})
        Me.TPTGrid.Location = New System.Drawing.Point(7, 20)
        Me.TPTGrid.Name = "TPTGrid"
        Me.TPTGrid.RowHeadersVisible = False
        Me.TPTGrid.Size = New System.Drawing.Size(149, 104)
        Me.TPTGrid.TabIndex = 0
        '
        'pNum
        '
        Me.pNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.pNum.HeaderText = "Page Number"
        Me.pNum.Name = "pNum"
        Me.pNum.ReadOnly = True
        '
        'fNum
        '
        Me.fNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fNum.HeaderText = "Frame Number"
        Me.fNum.Name = "fNum"
        Me.fNum.ReadOnly = True
        '
        'dataPageBox
        '
        Me.dataPageBox.Controls.Add(Me.DPTGrid)
        Me.dataPageBox.Location = New System.Drawing.Point(355, 148)
        Me.dataPageBox.Name = "dataPageBox"
        Me.dataPageBox.Size = New System.Drawing.Size(162, 120)
        Me.dataPageBox.TabIndex = 2
        Me.dataPageBox.TabStop = False
        Me.dataPageBox.Text = "Data Page Table"
        '
        'DPTGrid
        '
        Me.DPTGrid.AllowUserToAddRows = False
        Me.DPTGrid.AllowUserToDeleteRows = False
        Me.DPTGrid.AllowUserToResizeRows = False
        Me.DPTGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DPTGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DPTGrid.Location = New System.Drawing.Point(6, 16)
        Me.DPTGrid.Name = "DPTGrid"
        Me.DPTGrid.RowHeadersVisible = False
        Me.DPTGrid.Size = New System.Drawing.Size(150, 98)
        Me.DPTGrid.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Page Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Frame Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'openFileButton
        '
        Me.openFileButton.Location = New System.Drawing.Point(12, 235)
        Me.openFileButton.Name = "openFileButton"
        Me.openFileButton.Size = New System.Drawing.Size(79, 23)
        Me.openFileButton.TabIndex = 3
        Me.openFileButton.Text = "Choose File"
        Me.openFileButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Enabled = False
        Me.nextButton.Location = New System.Drawing.Point(97, 235)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 23)
        Me.nextButton.TabIndex = 4
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'instructionsBox
        '
        Me.instructionsBox.Controls.Add(Me.instructions)
        Me.instructionsBox.Location = New System.Drawing.Point(12, 12)
        Me.instructionsBox.Name = "instructionsBox"
        Me.instructionsBox.Size = New System.Drawing.Size(160, 217)
        Me.instructionsBox.TabIndex = 5
        Me.instructionsBox.TabStop = False
        Me.instructionsBox.Text = "Instructions"
        '
        'instructions
        '
        Me.instructions.AllowUserToAddRows = False
        Me.instructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.instructions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.procs})
        Me.instructions.Location = New System.Drawing.Point(6, 17)
        Me.instructions.Name = "instructions"
        Me.instructions.ReadOnly = True
        Me.instructions.RowHeadersVisible = False
        Me.instructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.instructions.Size = New System.Drawing.Size(148, 194)
        Me.instructions.TabIndex = 0
        '
        'procs
        '
        Me.procs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.procs.HeaderText = "Processes"
        Me.procs.Name = "procs"
        Me.procs.ReadOnly = True
        Me.procs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'MemorySim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 280)
        Me.Controls.Add(Me.instructionsBox)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.openFileButton)
        Me.Controls.Add(Me.dataPageBox)
        Me.Controls.Add(Me.textPageBox)
        Me.Controls.Add(Me.physicalMemoryBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MemorySim"
        Me.Text = "Memory Simulator"
        Me.physicalMemoryBox.ResumeLayout(False)
        Me.physicalMemoryBox.PerformLayout()
        Me.textPageBox.ResumeLayout(False)
        CType(Me.TPTGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataPageBox.ResumeLayout(False)
        CType(Me.DPTGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.instructionsBox.ResumeLayout(False)
        CType(Me.instructions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents physicalMemoryBox As GroupBox
    Friend WithEvents frameSevenL As Label
    Friend WithEvents frameSixL As Label
    Friend WithEvents frameFiveL As Label
    Friend WithEvents frameFourL As Label
    Friend WithEvents frameThreeL As Label
    Friend WithEvents frameTwoL As Label
    Friend WithEvents frameOneL As Label
    Friend WithEvents frameSevenButton As Button
    Friend WithEvents frameSixButton As Button
    Friend WithEvents frameFiveButton As Button
    Friend WithEvents frameFourButton As Button
    Friend WithEvents frameThreeButton As Button
    Friend WithEvents frameTwoButton As Button
    Friend WithEvents frameOneButton As Button
    Friend WithEvents frameZeroL As Label
    Friend WithEvents frameZeroButton As Button
    Friend WithEvents textPageBox As GroupBox
    Friend WithEvents TPTGrid As DataGridView
    Friend WithEvents dataPageBox As GroupBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents openFileButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents instructionsBox As GroupBox
    Friend WithEvents instructions As DataGridView
    Friend WithEvents procs As DataGridViewTextBoxColumn
    Friend WithEvents pNum As DataGridViewTextBoxColumn
    Friend WithEvents fNum As DataGridViewTextBoxColumn
    Friend WithEvents DPTGrid As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
