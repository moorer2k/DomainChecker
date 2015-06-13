<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.metroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.LabelKeywords = New MetroFramework.Controls.MetroLabel()
        Me.TextTLD = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TextKeyWord = New MetroFramework.Controls.MetroTextBox()
        Me.ButtonLookup = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.metroTrackBar1 = New MetroFramework.Controls.MetroTrackBar()
        Me.TextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.chkReverse = New MetroFramework.Controls.MetroCheckBox()
        Me.metroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ButtonStart = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.LstBoxTaken = New System.Windows.Forms.ListBox()
        Me.LstBoxValid = New System.Windows.Forms.ListBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.metroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroTabControl1.SuspendLayout()
        Me.metroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.metroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.CustomBackground = False
        Me.MetroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light
        Me.MetroTabControl1.Location = New System.Drawing.Point(9, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(510, 279)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTabControl1.StyleManager = Nothing
        Me.MetroTabControl1.TabIndex = 15
        Me.MetroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabControl1.UseStyleColors = False
        '
        'metroTabPage1
        '
        Me.metroTabPage1.AutoScroll = True
        Me.metroTabPage1.Controls.Add(Me.LabelKeywords)
        Me.metroTabPage1.Controls.Add(Me.TextTLD)
        Me.metroTabPage1.Controls.Add(Me.MetroLabel7)
        Me.metroTabPage1.Controls.Add(Me.Button1)
        Me.metroTabPage1.Controls.Add(Me.ListBox1)
        Me.metroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.metroTabPage1.Controls.Add(Me.TextKeyWord)
        Me.metroTabPage1.Controls.Add(Me.ButtonLookup)
        Me.metroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.metroTabPage1.Controls.Add(Me.metroTrackBar1)
        Me.metroTabPage1.Controls.Add(Me.TextBox1)
        Me.metroTabPage1.Controls.Add(Me.chkReverse)
        Me.metroTabPage1.Controls.Add(Me.metroLabel1)
        Me.metroTabPage1.Controls.Add(Me.ButtonStart)
        Me.metroTabPage1.CustomBackground = False
        Me.metroTabPage1.HorizontalScrollbar = True
        Me.metroTabPage1.HorizontalScrollbarBarColor = True
        Me.metroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.metroTabPage1.HorizontalScrollbarSize = 10
        Me.metroTabPage1.Location = New System.Drawing.Point(4, 35)
        Me.metroTabPage1.Name = "metroTabPage1"
        Me.metroTabPage1.Padding = New System.Windows.Forms.Padding(25)
        Me.metroTabPage1.Size = New System.Drawing.Size(502, 240)
        Me.metroTabPage1.Style = MetroFramework.MetroColorStyle.Orange
        Me.metroTabPage1.StyleManager = Nothing
        Me.metroTabPage1.TabIndex = 1
        Me.metroTabPage1.Text = "Main"
        Me.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.metroTabPage1.VerticalScrollbar = True
        Me.metroTabPage1.VerticalScrollbarBarColor = True
        Me.metroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.metroTabPage1.VerticalScrollbarSize = 10
        '
        'LabelKeywords
        '
        Me.LabelKeywords.CustomBackground = False
        Me.LabelKeywords.CustomForeColor = False
        Me.LabelKeywords.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelKeywords.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LabelKeywords.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelKeywords.Location = New System.Drawing.Point(290, 211)
        Me.LabelKeywords.Name = "LabelKeywords"
        Me.LabelKeywords.Size = New System.Drawing.Size(209, 19)
        Me.LabelKeywords.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelKeywords.StyleManager = Nothing
        Me.LabelKeywords.TabIndex = 22
        Me.LabelKeywords.Text = "Keywords Found: 0"
        Me.LabelKeywords.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelKeywords.UseStyleColors = False
        '
        'TextTLD
        '
        Me.TextTLD.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextTLD.CustomBackground = False
        Me.TextTLD.CustomForeColor = False
        Me.TextTLD.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TextTLD.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TextTLD.Location = New System.Drawing.Point(126, 41)
        Me.TextTLD.Multiline = False
        Me.TextTLD.Name = "TextTLD"
        Me.TextTLD.SelectedText = ""
        Me.TextTLD.Size = New System.Drawing.Size(94, 22)
        Me.TextTLD.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextTLD.StyleManager = Nothing
        Me.TextTLD.TabIndex = 20
        Me.TextTLD.Text = "com"
        Me.TextTLD.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextTLD.UseStyleColors = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.CustomBackground = False
        Me.MetroLabel7.CustomForeColor = False
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel7.Location = New System.Drawing.Point(123, 23)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel7.StyleManager = Nothing
        Me.MetroLabel7.TabIndex = 19
        Me.MetroLabel7.Text = "TLD (.com etc):"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel7.UseStyleColors = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 33)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(290, 69)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(209, 132)
        Me.ListBox1.TabIndex = 17
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.CustomBackground = False
        Me.MetroLabel3.CustomForeColor = False
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel3.Location = New System.Drawing.Point(290, 23)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel3.StyleManager = Nothing
        Me.MetroLabel3.TabIndex = 16
        Me.MetroLabel3.Text = "Keyword Helper:"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel3.UseStyleColors = False
        '
        'TextKeyWord
        '
        Me.TextKeyWord.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextKeyWord.CustomBackground = False
        Me.TextKeyWord.CustomForeColor = False
        Me.TextKeyWord.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TextKeyWord.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TextKeyWord.Location = New System.Drawing.Point(290, 41)
        Me.TextKeyWord.Multiline = False
        Me.TextKeyWord.Name = "TextKeyWord"
        Me.TextKeyWord.SelectedText = ""
        Me.TextKeyWord.Size = New System.Drawing.Size(146, 22)
        Me.TextKeyWord.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextKeyWord.StyleManager = Nothing
        Me.TextKeyWord.TabIndex = 15
        Me.TextKeyWord.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextKeyWord.UseStyleColors = False
        '
        'ButtonLookup
        '
        Me.ButtonLookup.Highlight = True
        Me.ButtonLookup.Location = New System.Drawing.Point(442, 41)
        Me.ButtonLookup.Name = "ButtonLookup"
        Me.ButtonLookup.Size = New System.Drawing.Size(57, 22)
        Me.ButtonLookup.Style = MetroFramework.MetroColorStyle.Blue
        Me.ButtonLookup.StyleManager = Nothing
        Me.ButtonLookup.TabIndex = 14
        Me.ButtonLookup.Text = "Lookup"
        Me.ButtonLookup.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.CustomBackground = False
        Me.MetroLabel2.CustomForeColor = False
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel2.Location = New System.Drawing.Point(0, 69)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel2.StyleManager = Nothing
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Sockets [10]:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel2.UseStyleColors = False
        '
        'metroTrackBar1
        '
        Me.metroTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.metroTrackBar1.CustomBackground = False
        Me.metroTrackBar1.LargeChange = CType(5UI, UInteger)
        Me.metroTrackBar1.Location = New System.Drawing.Point(87, 69)
        Me.metroTrackBar1.Maximum = 50
        Me.metroTrackBar1.Minimum = 1
        Me.metroTrackBar1.MouseWheelBarPartitions = 10
        Me.metroTrackBar1.Name = "metroTrackBar1"
        Me.metroTrackBar1.Size = New System.Drawing.Size(197, 19)
        Me.metroTrackBar1.SmallChange = CType(1UI, UInteger)
        Me.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Blue
        Me.metroTrackBar1.StyleManager = Nothing
        Me.metroTrackBar1.TabIndex = 12
        Me.metroTrackBar1.Text = "metroTrackBar1"
        Me.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.metroTrackBar1.Value = 10
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.CustomBackground = False
        Me.TextBox1.CustomForeColor = False
        Me.TextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TextBox1.Location = New System.Drawing.Point(3, 41)
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(117, 22)
        Me.TextBox1.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBox1.StyleManager = Nothing
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBox1.UseStyleColors = False
        '
        'chkReverse
        '
        Me.chkReverse.AutoSize = True
        Me.chkReverse.CustomBackground = False
        Me.chkReverse.CustomForeColor = False
        Me.chkReverse.FontSize = MetroFramework.MetroLinkSize.Small
        Me.chkReverse.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.chkReverse.Location = New System.Drawing.Point(0, 103)
        Me.chkReverse.Name = "chkReverse"
        Me.chkReverse.Size = New System.Drawing.Size(95, 15)
        Me.chkReverse.Style = MetroFramework.MetroColorStyle.Blue
        Me.chkReverse.StyleManager = Nothing
        Me.chkReverse.TabIndex = 10
        Me.chkReverse.Text = "Reverse Word"
        Me.chkReverse.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkReverse.UseStyleColors = False
        '
        'metroLabel1
        '
        Me.metroLabel1.AutoSize = True
        Me.metroLabel1.CustomBackground = False
        Me.metroLabel1.CustomForeColor = False
        Me.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.metroLabel1.Location = New System.Drawing.Point(0, 23)
        Me.metroLabel1.Name = "metroLabel1"
        Me.metroLabel1.Size = New System.Drawing.Size(74, 19)
        Me.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.metroLabel1.StyleManager = Nothing
        Me.metroLabel1.TabIndex = 8
        Me.metroLabel1.Text = "First Word:"
        Me.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.metroLabel1.UseStyleColors = False
        '
        'ButtonStart
        '
        Me.ButtonStart.Enabled = False
        Me.ButtonStart.Highlight = True
        Me.ButtonStart.Location = New System.Drawing.Point(226, 41)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(58, 22)
        Me.ButtonStart.Style = MetroFramework.MetroColorStyle.Blue
        Me.ButtonStart.StyleManager = Nothing
        Me.ButtonStart.TabIndex = 6
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.LstBoxTaken)
        Me.MetroTabPage2.Controls.Add(Me.LstBoxValid)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage2.Controls.Add(Me.metroProgressBar1)
        Me.MetroTabPage2.CustomBackground = False
        Me.MetroTabPage2.HorizontalScrollbar = False
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(502, 240)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage2.StyleManager = Nothing
        Me.MetroTabPage2.TabIndex = 2
        Me.MetroTabPage2.Text = "Status"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage2.VerticalScrollbar = False
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'LstBoxTaken
        '
        Me.LstBoxTaken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstBoxTaken.FormattingEnabled = True
        Me.LstBoxTaken.Location = New System.Drawing.Point(313, 65)
        Me.LstBoxTaken.Name = "LstBoxTaken"
        Me.LstBoxTaken.Size = New System.Drawing.Size(171, 119)
        Me.LstBoxTaken.TabIndex = 13
        '
        'LstBoxValid
        '
        Me.LstBoxValid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstBoxValid.FormattingEnabled = True
        Me.LstBoxValid.Location = New System.Drawing.Point(10, 65)
        Me.LstBoxValid.Name = "LstBoxValid"
        Me.LstBoxValid.Size = New System.Drawing.Size(171, 119)
        Me.LstBoxValid.TabIndex = 12
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.CustomBackground = False
        Me.MetroLabel6.CustomForeColor = False
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel6.Location = New System.Drawing.Point(182, 191)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel6.StyleManager = Nothing
        Me.MetroLabel6.TabIndex = 11
        Me.MetroLabel6.Text = "Domains Left: 0"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel6.UseStyleColors = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.CustomBackground = False
        Me.MetroLabel5.CustomForeColor = False
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel5.Location = New System.Drawing.Point(313, 43)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel5.StyleManager = Nothing
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Invalid Domains: 0"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel5.UseStyleColors = False
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.CustomBackground = False
        Me.MetroLabel4.CustomForeColor = False
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel4.Location = New System.Drawing.Point(10, 37)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(154, 25)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel4.StyleManager = Nothing
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Valid Domains: 0"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel4.UseStyleColors = False
        '
        'metroProgressBar1
        '
        Me.metroProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.metroProgressBar1.Enabled = False
        Me.metroProgressBar1.FontSize = MetroFramework.MetroProgressBarSize.Medium
        Me.metroProgressBar1.FontWeight = MetroFramework.MetroProgressBarWeight.Light
        Me.metroProgressBar1.HideProgressText = True
        Me.metroProgressBar1.Location = New System.Drawing.Point(10, 213)
        Me.metroProgressBar1.Name = "metroProgressBar1"
        Me.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.metroProgressBar1.Size = New System.Drawing.Size(474, 19)
        Me.metroProgressBar1.Step = 1
        Me.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Blue
        Me.metroProgressBar1.StyleManager = Nothing
        Me.metroProgressBar1.TabIndex = 8
        Me.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.metroProgressBar1.Value = 1
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 353)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Moore Domain Checker"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.metroTabPage1.ResumeLayout(False)
        Me.metroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Private WithEvents metroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Private WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Private WithEvents TextKeyWord As MetroFramework.Controls.MetroTextBox
    Private WithEvents ButtonLookup As MetroFramework.Controls.MetroButton
    Private WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents metroTrackBar1 As MetroFramework.Controls.MetroTrackBar
    Private WithEvents TextBox1 As MetroFramework.Controls.MetroTextBox
    Private WithEvents chkReverse As MetroFramework.Controls.MetroCheckBox
    Private WithEvents metroLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents ButtonStart As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Private WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Private WithEvents metroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents TextTLD As MetroFramework.Controls.MetroTextBox
    Private WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LstBoxTaken As System.Windows.Forms.ListBox
    Friend WithEvents LstBoxValid As System.Windows.Forms.ListBox
    Private WithEvents LabelKeywords As MetroFramework.Controls.MetroLabel
End Class
