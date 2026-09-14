<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainF))
        StartLoopButton = New Button()
        ClearButton = New Button()
        QueryRichTextBox = New TextBox()
        MessageGroupBox = New GroupBox()
        MACheckBox = New CheckBox()
        StopLoopButton = New Button()
        ModelListBox2 = New ListBox()
        Label2 = New Label()
        ModelListBox = New ListBox()
        Label1 = New Label()
        AboutLabel = New Label()
        LogoPictureBox = New PictureBox()
        ResponseGroupBox = New GroupBox()
        ResponseRichTextBox1 = New RichTextBox()
        GroupBox1 = New GroupBox()
        ResponseRichTextBox2 = New RichTextBox()
        StatePictureBox = New PictureBox()
        TupleGroupBox = New GroupBox()
        AlignmentPictureBox = New PictureBox()
        ReasoningGroupBox = New GroupBox()
        ReasoningPictureBox = New PictureBox()
        ReasoningRichTextBox = New RichTextBox()
        MessageGroupBox.SuspendLayout()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        ResponseGroupBox.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(StatePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        TupleGroupBox.SuspendLayout()
        CType(AlignmentPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        ReasoningGroupBox.SuspendLayout()
        CType(ReasoningPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StartLoopButton
        ' 
        StartLoopButton.BackColor = Color.Green
        StartLoopButton.FlatAppearance.BorderColor = Color.Black
        StartLoopButton.FlatAppearance.MouseDownBackColor = Color.White
        StartLoopButton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        StartLoopButton.FlatStyle = FlatStyle.Flat
        StartLoopButton.Font = New Font("Segoe UI", 9F)
        StartLoopButton.ForeColor = Color.White
        StartLoopButton.Location = New Point(382, 234)
        StartLoopButton.Name = "StartLoopButton"
        StartLoopButton.Size = New Size(100, 25)
        StartLoopButton.TabIndex = 6
        StartLoopButton.Text = "Start"
        StartLoopButton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Black
        ClearButton.FlatAppearance.BorderColor = Color.Black
        ClearButton.FlatAppearance.MouseDownBackColor = Color.White
        ClearButton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Segoe UI", 9F)
        ClearButton.ForeColor = Color.White
        ClearButton.Location = New Point(594, 234)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(100, 25)
        ClearButton.TabIndex = 8
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' QueryRichTextBox
        ' 
        QueryRichTextBox.BackColor = Color.White
        QueryRichTextBox.BorderStyle = BorderStyle.None
        QueryRichTextBox.Font = New Font("Segoe UI", 9F)
        QueryRichTextBox.ForeColor = Color.Black
        QueryRichTextBox.Location = New Point(6, 30)
        QueryRichTextBox.Multiline = True
        QueryRichTextBox.Name = "QueryRichTextBox"
        QueryRichTextBox.Size = New Size(688, 155)
        QueryRichTextBox.TabIndex = 0
        ' 
        ' MessageGroupBox
        ' 
        MessageGroupBox.BackColor = Color.White
        MessageGroupBox.Controls.Add(MACheckBox)
        MessageGroupBox.Controls.Add(StopLoopButton)
        MessageGroupBox.Controls.Add(ModelListBox2)
        MessageGroupBox.Controls.Add(Label2)
        MessageGroupBox.Controls.Add(ModelListBox)
        MessageGroupBox.Controls.Add(Label1)
        MessageGroupBox.Controls.Add(QueryRichTextBox)
        MessageGroupBox.Controls.Add(StartLoopButton)
        MessageGroupBox.Controls.Add(ClearButton)
        MessageGroupBox.FlatStyle = FlatStyle.Flat
        MessageGroupBox.Font = New Font("Segoe UI", 9F)
        MessageGroupBox.ForeColor = Color.Black
        MessageGroupBox.Location = New Point(12, 576)
        MessageGroupBox.Name = "MessageGroupBox"
        MessageGroupBox.Size = New Size(700, 265)
        MessageGroupBox.TabIndex = 0
        MessageGroupBox.TabStop = False
        MessageGroupBox.Text = "Query"
        ' 
        ' MACheckBox
        ' 
        MACheckBox.AutoSize = True
        MACheckBox.Location = New Point(285, 238)
        MACheckBox.Name = "MACheckBox"
        MACheckBox.Size = New Size(91, 19)
        MACheckBox.TabIndex = 1
        MACheckBox.Text = "Multi-Agent"
        MACheckBox.UseVisualStyleBackColor = True
        ' 
        ' StopLoopButton
        ' 
        StopLoopButton.BackColor = Color.Red
        StopLoopButton.FlatAppearance.BorderColor = Color.Black
        StopLoopButton.FlatAppearance.MouseDownBackColor = Color.White
        StopLoopButton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        StopLoopButton.FlatStyle = FlatStyle.Flat
        StopLoopButton.Font = New Font("Segoe UI", 9F)
        StopLoopButton.ForeColor = Color.White
        StopLoopButton.Location = New Point(488, 234)
        StopLoopButton.Name = "StopLoopButton"
        StopLoopButton.Size = New Size(100, 25)
        StopLoopButton.TabIndex = 7
        StopLoopButton.Text = "Stop"
        StopLoopButton.UseVisualStyleBackColor = False
        ' 
        ' ModelListBox2
        ' 
        ModelListBox2.FormattingEnabled = True
        ModelListBox2.ItemHeight = 15
        ModelListBox2.Location = New Point(488, 194)
        ModelListBox2.Name = "ModelListBox2"
        ModelListBox2.Size = New Size(206, 34)
        ModelListBox2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(432, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 4
        Label2.Text = "Model 2"
        ' 
        ' ModelListBox
        ' 
        ModelListBox.FormattingEnabled = True
        ModelListBox.ItemHeight = 15
        ModelListBox.Location = New Point(220, 194)
        ModelListBox.Name = "ModelListBox"
        ModelListBox.Size = New Size(206, 34)
        ModelListBox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(164, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 2
        Label1.Text = "Model 1"
        ' 
        ' AboutLabel
        ' 
        AboutLabel.AutoSize = True
        AboutLabel.Font = New Font("Segoe UI", 9F)
        AboutLabel.ForeColor = Color.Black
        AboutLabel.Location = New Point(930, 859)
        AboutLabel.Name = "AboutLabel"
        AboutLabel.Size = New Size(266, 60)
        AboutLabel.TabIndex = 5
        AboutLabel.Text = "IDRA Reconstruction Auditor" & vbCrLf & "© 2026 Copyright Oranyx Labs/Elliot Monteverde" & vbCrLf & "All Rights Reserved" & vbCrLf & "GNU General Public License v3.0"
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(1281, 847)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(137, 81)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        LogoPictureBox.TabIndex = 25
        LogoPictureBox.TabStop = False
        ' 
        ' ResponseGroupBox
        ' 
        ResponseGroupBox.BackColor = Color.White
        ResponseGroupBox.Controls.Add(ResponseRichTextBox1)
        ResponseGroupBox.Font = New Font("Segoe UI", 9F)
        ResponseGroupBox.ForeColor = Color.Black
        ResponseGroupBox.Location = New Point(12, 34)
        ResponseGroupBox.Name = "ResponseGroupBox"
        ResponseGroupBox.Size = New Size(700, 265)
        ResponseGroupBox.TabIndex = 1
        ResponseGroupBox.TabStop = False
        ResponseGroupBox.Text = "Model 1 Response"
        ' 
        ' ResponseRichTextBox1
        ' 
        ResponseRichTextBox1.BackColor = Color.White
        ResponseRichTextBox1.BorderStyle = BorderStyle.None
        ResponseRichTextBox1.Font = New Font("Segoe UI", 9F)
        ResponseRichTextBox1.ForeColor = Color.Black
        ResponseRichTextBox1.Location = New Point(6, 30)
        ResponseRichTextBox1.Name = "ResponseRichTextBox1"
        ResponseRichTextBox1.ReadOnly = True
        ResponseRichTextBox1.Size = New Size(688, 229)
        ResponseRichTextBox1.TabIndex = 0
        ResponseRichTextBox1.Text = ""
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(ResponseRichTextBox2)
        GroupBox1.Font = New Font("Segoe UI", 9F)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 305)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(700, 265)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Model 2 Response"
        ' 
        ' ResponseRichTextBox2
        ' 
        ResponseRichTextBox2.BackColor = Color.White
        ResponseRichTextBox2.BorderStyle = BorderStyle.None
        ResponseRichTextBox2.Font = New Font("Segoe UI", 9F)
        ResponseRichTextBox2.ForeColor = Color.Black
        ResponseRichTextBox2.Location = New Point(6, 30)
        ResponseRichTextBox2.Name = "ResponseRichTextBox2"
        ResponseRichTextBox2.ReadOnly = True
        ResponseRichTextBox2.Size = New Size(688, 229)
        ResponseRichTextBox2.TabIndex = 0
        ResponseRichTextBox2.Text = ""
        ' 
        ' StatePictureBox
        ' 
        StatePictureBox.Location = New Point(6, 22)
        StatePictureBox.Name = "StatePictureBox"
        StatePictureBox.Size = New Size(341, 235)
        StatePictureBox.TabIndex = 27
        StatePictureBox.TabStop = False
        ' 
        ' TupleGroupBox
        ' 
        TupleGroupBox.Controls.Add(AlignmentPictureBox)
        TupleGroupBox.Controls.Add(StatePictureBox)
        TupleGroupBox.Location = New Point(718, 576)
        TupleGroupBox.Name = "TupleGroupBox"
        TupleGroupBox.Size = New Size(700, 265)
        TupleGroupBox.TabIndex = 4
        TupleGroupBox.TabStop = False
        TupleGroupBox.Text = "State Tuple and Alignment"
        ' 
        ' AlignmentPictureBox
        ' 
        AlignmentPictureBox.Location = New Point(353, 22)
        AlignmentPictureBox.Name = "AlignmentPictureBox"
        AlignmentPictureBox.Size = New Size(341, 235)
        AlignmentPictureBox.TabIndex = 28
        AlignmentPictureBox.TabStop = False
        ' 
        ' ReasoningGroupBox
        ' 
        ReasoningGroupBox.Controls.Add(ReasoningPictureBox)
        ReasoningGroupBox.Controls.Add(ReasoningRichTextBox)
        ReasoningGroupBox.Location = New Point(718, 34)
        ReasoningGroupBox.Name = "ReasoningGroupBox"
        ReasoningGroupBox.Size = New Size(699, 536)
        ReasoningGroupBox.TabIndex = 3
        ReasoningGroupBox.TabStop = False
        ReasoningGroupBox.Text = "Latent Reasoning and Chain of Thought"
        ' 
        ' ReasoningPictureBox
        ' 
        ReasoningPictureBox.Location = New Point(6, 327)
        ReasoningPictureBox.Name = "ReasoningPictureBox"
        ReasoningPictureBox.Size = New Size(687, 200)
        ReasoningPictureBox.TabIndex = 30
        ReasoningPictureBox.TabStop = False
        ' 
        ' ReasoningRichTextBox
        ' 
        ReasoningRichTextBox.BackColor = Color.White
        ReasoningRichTextBox.BorderStyle = BorderStyle.None
        ReasoningRichTextBox.Font = New Font("Segoe UI", 9F)
        ReasoningRichTextBox.ForeColor = Color.Black
        ReasoningRichTextBox.Location = New Point(6, 22)
        ReasoningRichTextBox.Name = "ReasoningRichTextBox"
        ReasoningRichTextBox.ReadOnly = True
        ReasoningRichTextBox.Size = New Size(688, 299)
        ReasoningRichTextBox.TabIndex = 0
        ReasoningRichTextBox.Text = ""
        ' 
        ' MainF
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1429, 939)
        Controls.Add(ReasoningGroupBox)
        Controls.Add(TupleGroupBox)
        Controls.Add(GroupBox1)
        Controls.Add(ResponseGroupBox)
        Controls.Add(LogoPictureBox)
        Controls.Add(AboutLabel)
        Controls.Add(MessageGroupBox)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "MainF"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "IDRA | Interpretability Driven Reasoning Architecture Reconstruction Auditor"
        MessageGroupBox.ResumeLayout(False)
        MessageGroupBox.PerformLayout()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResponseGroupBox.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(StatePictureBox, ComponentModel.ISupportInitialize).EndInit()
        TupleGroupBox.ResumeLayout(False)
        CType(AlignmentPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ReasoningGroupBox.ResumeLayout(False)
        CType(ReasoningPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StartLoopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents QueryRichTextBox As TextBox
    Friend WithEvents MessageGroupBox As GroupBox
    Friend WithEvents AboutLabel As Label
    Friend WithEvents StatePictureBox As PictureBox
    Friend WithEvents StateGroupBox As GroupBox
    Friend WithEvents UpdatePictureBox As PictureBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents AlignmentPictureBox As PictureBox
    Friend WithEvents UpdateGroupBox As GroupBox
    Friend WithEvents AlignmentGroupBox As GroupBox
    Friend WithEvents ResponseGroupBox As GroupBox
    Friend WithEvents ResponseRichTextBox1 As RichTextBox
    Friend WithEvents AnalysisGroupBox As GroupBox
    Friend WithEvents AnalysisRichTextBox As RichTextBox
    Friend WithEvents AnalysisButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ModelListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ResponseRichTextBox2 As RichTextBox
    Friend WithEvents ModelListBox2 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StopLoopButton As Button
    Friend WithEvents MACheckBox As CheckBox
    Friend WithEvents TupleGroupBox As GroupBox
    Friend WithEvents ReasoningGroupBox As GroupBox
    Friend WithEvents ReasoningRichTextBox As RichTextBox
    Friend WithEvents ReasoningPictureBox As PictureBox

End Class
