<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnBrowseInput = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowseComparison = New System.Windows.Forms.Button()
        Me.txtComparison = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSemiMask = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBrowseOutput = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.numTolerance = New System.Windows.Forms.NumericUpDown()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.rdbIdentical = New System.Windows.Forms.RadioButton()
        Me.rdbDifferent = New System.Windows.Forms.RadioButton()
        Me.chkMask = New System.Windows.Forms.CheckBox()
        Me.FileLoader = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numTolerance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowseInput
        '
        Me.btnBrowseInput.Location = New System.Drawing.Point(282, 16)
        Me.btnBrowseInput.Name = "btnBrowseInput"
        Me.btnBrowseInput.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseInput.TabIndex = 2
        Me.btnBrowseInput.Text = "Browse"
        Me.btnBrowseInput.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnBrowseComparison)
        Me.GroupBox1.Controls.Add(Me.txtComparison)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBrowseInput)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load"
        '
        'txtInput
        '
        Me.txtInput.AllowDrop = True
        Me.txtInput.Location = New System.Drawing.Point(79, 19)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(197, 20)
        Me.txtInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Comparison:"
        '
        'btnBrowseComparison
        '
        Me.btnBrowseComparison.Location = New System.Drawing.Point(282, 43)
        Me.btnBrowseComparison.Name = "btnBrowseComparison"
        Me.btnBrowseComparison.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseComparison.TabIndex = 5
        Me.btnBrowseComparison.Text = "Browse"
        Me.btnBrowseComparison.UseVisualStyleBackColor = True
        '
        'txtComparison
        '
        Me.txtComparison.AllowDrop = True
        Me.txtComparison.Location = New System.Drawing.Point(79, 45)
        Me.txtComparison.Name = "txtComparison"
        Me.txtComparison.Size = New System.Drawing.Size(197, 20)
        Me.txtComparison.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input:"
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(12, 95)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(364, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(12, 246)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(364, 23)
        Me.Progress.Step = 1
        Me.Progress.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSemiMask)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnBrowseOutput)
        Me.GroupBox2.Controls.Add(Me.lblOutput)
        Me.GroupBox2.Controls.Add(Me.numTolerance)
        Me.GroupBox2.Controls.Add(Me.txtOutput)
        Me.GroupBox2.Controls.Add(Me.rdbIdentical)
        Me.GroupBox2.Controls.Add(Me.rdbDifferent)
        Me.GroupBox2.Controls.Add(Me.chkMask)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 116)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Settings"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Semi-mask:"
        '
        'txtSemiMask
        '
        Me.txtSemiMask.Location = New System.Drawing.Point(73, 84)
        Me.txtSemiMask.Name = "txtSemiMask"
        Me.txtSemiMask.Size = New System.Drawing.Size(203, 20)
        Me.txtSemiMask.TabIndex = 6
        Me.txtSemiMask.Text = "(none)"
        Me.ToolTip1.SetToolTip(Me.txtSemiMask, "Upload a mask file for the parts where their should be semi-transparency" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use on " & _
        "shadows and such.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tolerance:"
        '
        'btnBrowseOutput
        '
        Me.btnBrowseOutput.Location = New System.Drawing.Point(282, 56)
        Me.btnBrowseOutput.Name = "btnBrowseOutput"
        Me.btnBrowseOutput.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseOutput.TabIndex = 2
        Me.btnBrowseOutput.Text = "Browse"
        Me.btnBrowseOutput.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(6, 61)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "Output:"
        '
        'numTolerance
        '
        Me.numTolerance.Location = New System.Drawing.Point(293, 30)
        Me.numTolerance.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numTolerance.Name = "numTolerance"
        Me.numTolerance.Size = New System.Drawing.Size(38, 20)
        Me.numTolerance.TabIndex = 3
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(73, 58)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(203, 20)
        Me.txtOutput.TabIndex = 1
        Me.txtOutput.Text = "(same as input)"
        Me.ToolTip1.SetToolTip(Me.txtOutput, "Where to output the file, leave empty to output in the same location.")
        '
        'rdbIdentical
        '
        Me.rdbIdentical.AutoSize = True
        Me.rdbIdentical.Checked = True
        Me.rdbIdentical.Location = New System.Drawing.Point(9, 25)
        Me.rdbIdentical.Name = "rdbIdentical"
        Me.rdbIdentical.Size = New System.Drawing.Size(66, 17)
        Me.rdbIdentical.TabIndex = 3
        Me.rdbIdentical.TabStop = True
        Me.rdbIdentical.Text = "Identical"
        Me.ToolTip1.SetToolTip(Me.rdbIdentical, "Output the pixels that are identical on both images." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can use this to remove " & _
        "a background. This outputs from the input")
        Me.rdbIdentical.UseVisualStyleBackColor = True
        '
        'rdbDifferent
        '
        Me.rdbDifferent.AutoSize = True
        Me.rdbDifferent.Location = New System.Drawing.Point(81, 25)
        Me.rdbDifferent.Name = "rdbDifferent"
        Me.rdbDifferent.Size = New System.Drawing.Size(68, 17)
        Me.rdbDifferent.TabIndex = 4
        Me.rdbDifferent.Text = "Different"
        Me.ToolTip1.SetToolTip(Me.rdbDifferent, "Output the pixels that are different in one image from the other" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can use thi" & _
        "s to remove the foreground and output the background instead.")
        Me.rdbDifferent.UseVisualStyleBackColor = True
        '
        'chkMask
        '
        Me.chkMask.AutoSize = True
        Me.chkMask.Location = New System.Drawing.Point(192, 19)
        Me.chkMask.Name = "chkMask"
        Me.chkMask.Size = New System.Drawing.Size(64, 30)
        Me.chkMask.TabIndex = 4
        Me.chkMask.Text = "Output" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as Mask"
        Me.chkMask.UseVisualStyleBackColor = True
        '
        'FileLoader
        '
        Me.FileLoader.FileName = "OpenFileDialog1"
        Me.FileLoader.Filter = "All Supported Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TI" & _
    "FF;*.PNG"
        Me.FileLoader.Title = "Please choose an image..."
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 281)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Diff"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numTolerance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBrowseInput As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtComparison As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseComparison As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnBrowseOutput As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents numTolerance As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkMask As System.Windows.Forms.CheckBox
    Friend WithEvents FileLoader As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rdbDifferent As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIdentical As System.Windows.Forms.RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSemiMask As System.Windows.Forms.TextBox

End Class
