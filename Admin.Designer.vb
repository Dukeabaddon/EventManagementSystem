<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.containerPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.eventPage = New System.Windows.Forms.TabPage()
        Me.participantPage = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelSideBar = New System.Windows.Forms.Panel()
        Me.SiticoneButton2 = New Siticone.Desktop.UI.Winforms.SiticoneButton()
        Me.SiticoneButton1 = New Siticone.Desktop.UI.Winforms.SiticoneButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.label = New System.Windows.Forms.Label()
        Me.SiticoneCustomGradientPanel1 = New Siticone.Desktop.UI.Winforms.SiticoneCustomGradientPanel()
        Me.SiticoneCustomGradientPanel2 = New Siticone.Desktop.UI.Winforms.SiticoneCustomGradientPanel()
        Me.SiticoneCustomGradientPanel3 = New Siticone.Desktop.UI.Winforms.SiticoneCustomGradientPanel()
        Me.SiticoneHtmlLabel1 = New Siticone.Desktop.UI.Winforms.SiticoneHtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Available = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2DataGridView2 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.containerPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.eventPage.SuspendLayout()
        Me.participantPage.SuspendLayout()
        Me.panelSideBar.SuspendLayout()
        Me.SiticoneCustomGradientPanel1.SuspendLayout()
        Me.SiticoneCustomGradientPanel2.SuspendLayout()
        Me.SiticoneCustomGradientPanel3.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'containerPanel
        '
        Me.containerPanel.Controls.Add(Me.panelSideBar)
        Me.containerPanel.Controls.Add(Me.TabControl1)
        Me.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.containerPanel.Location = New System.Drawing.Point(0, 0)
        Me.containerPanel.Name = "containerPanel"
        Me.containerPanel.Size = New System.Drawing.Size(1422, 977)
        Me.containerPanel.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.eventPage)
        Me.TabControl1.Controls.Add(Me.participantPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1422, 977)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 1
        '
        'eventPage
        '
        Me.eventPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.eventPage.Controls.Add(Me.Guna2Button1)
        Me.eventPage.Controls.Add(Me.Guna2DataGridView1)
        Me.eventPage.Controls.Add(Me.SiticoneHtmlLabel1)
        Me.eventPage.Controls.Add(Me.SiticoneCustomGradientPanel3)
        Me.eventPage.Controls.Add(Me.SiticoneCustomGradientPanel2)
        Me.eventPage.Controls.Add(Me.SiticoneCustomGradientPanel1)
        Me.eventPage.Controls.Add(Me.label)
        Me.eventPage.Controls.Add(Me.Guna2Panel1)
        Me.eventPage.Location = New System.Drawing.Point(4, 5)
        Me.eventPage.Name = "eventPage"
        Me.eventPage.Padding = New System.Windows.Forms.Padding(3)
        Me.eventPage.Size = New System.Drawing.Size(1414, 968)
        Me.eventPage.TabIndex = 0
        Me.eventPage.Text = "TabPage1"
        '
        'participantPage
        '
        Me.participantPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.participantPage.Controls.Add(Me.Guna2DataGridView2)
        Me.participantPage.Controls.Add(Me.Label10)
        Me.participantPage.Controls.Add(Me.Guna2Panel2)
        Me.participantPage.Location = New System.Drawing.Point(4, 5)
        Me.participantPage.Name = "participantPage"
        Me.participantPage.Padding = New System.Windows.Forms.Padding(3)
        Me.participantPage.Size = New System.Drawing.Size(1414, 968)
        Me.participantPage.TabIndex = 1
        Me.participantPage.Text = "TabPage2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EventZen"
        '
        'panelSideBar
        '
        Me.panelSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.panelSideBar.Controls.Add(Me.SiticoneButton2)
        Me.panelSideBar.Controls.Add(Me.SiticoneButton1)
        Me.panelSideBar.Controls.Add(Me.Label1)
        Me.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSideBar.Location = New System.Drawing.Point(0, 0)
        Me.panelSideBar.Name = "panelSideBar"
        Me.panelSideBar.Size = New System.Drawing.Size(365, 977)
        Me.panelSideBar.TabIndex = 0
        '
        'SiticoneButton2
        '
        Me.SiticoneButton2.Animated = True
        Me.SiticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SiticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SiticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SiticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.SiticoneButton2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.SiticoneButton2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton2.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton2.Image = Global.EventManagementSystem.My.Resources.Resources.users
        Me.SiticoneButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SiticoneButton2.ImageOffset = New System.Drawing.Point(40, 0)
        Me.SiticoneButton2.ImageSize = New System.Drawing.Size(50, 50)
        Me.SiticoneButton2.Location = New System.Drawing.Point(0, 384)
        Me.SiticoneButton2.Name = "SiticoneButton2"
        Me.SiticoneButton2.Size = New System.Drawing.Size(365, 110)
        Me.SiticoneButton2.TabIndex = 2
        Me.SiticoneButton2.Text = "Registered"
        Me.SiticoneButton2.TextOffset = New System.Drawing.Point(40, 0)
        '
        'SiticoneButton1
        '
        Me.SiticoneButton1.Animated = True
        Me.SiticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SiticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SiticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SiticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.SiticoneButton1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.SiticoneButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton1.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton1.Image = Global.EventManagementSystem.My.Resources.Resources.calendar
        Me.SiticoneButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SiticoneButton1.ImageOffset = New System.Drawing.Point(40, 0)
        Me.SiticoneButton1.ImageSize = New System.Drawing.Size(50, 50)
        Me.SiticoneButton1.Location = New System.Drawing.Point(0, 268)
        Me.SiticoneButton1.Name = "SiticoneButton1"
        Me.SiticoneButton1.Size = New System.Drawing.Size(365, 110)
        Me.SiticoneButton1.TabIndex = 1
        Me.SiticoneButton1.Text = "Events"
        Me.SiticoneButton1.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoRoundedCorners = True
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 1
        Me.Guna2Panel1.BorderThickness = 5
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Black
        Me.Guna2Panel1.Location = New System.Drawing.Point(405, 20)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(5, 59)
        Me.Guna2Panel1.TabIndex = 0
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.label.Location = New System.Drawing.Point(416, 23)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(154, 52)
        Me.label.TabIndex = 1
        Me.label.Text = "Events"
        '
        'SiticoneCustomGradientPanel1
        '
        Me.SiticoneCustomGradientPanel1.BorderRadius = 16
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label2)
        Me.SiticoneCustomGradientPanel1.Controls.Add(Me.Label5)
        Me.SiticoneCustomGradientPanel1.Location = New System.Drawing.Point(380, 111)
        Me.SiticoneCustomGradientPanel1.Name = "SiticoneCustomGradientPanel1"
        Me.SiticoneCustomGradientPanel1.Size = New System.Drawing.Size(325, 175)
        Me.SiticoneCustomGradientPanel1.TabIndex = 2
        '
        'SiticoneCustomGradientPanel2
        '
        Me.SiticoneCustomGradientPanel2.BorderRadius = 16
        Me.SiticoneCustomGradientPanel2.Controls.Add(Me.Label3)
        Me.SiticoneCustomGradientPanel2.Controls.Add(Me.Label6)
        Me.SiticoneCustomGradientPanel2.Location = New System.Drawing.Point(721, 111)
        Me.SiticoneCustomGradientPanel2.Name = "SiticoneCustomGradientPanel2"
        Me.SiticoneCustomGradientPanel2.Size = New System.Drawing.Size(325, 175)
        Me.SiticoneCustomGradientPanel2.TabIndex = 3
        '
        'SiticoneCustomGradientPanel3
        '
        Me.SiticoneCustomGradientPanel3.BorderRadius = 16
        Me.SiticoneCustomGradientPanel3.Controls.Add(Me.Label4)
        Me.SiticoneCustomGradientPanel3.Controls.Add(Me.Label7)
        Me.SiticoneCustomGradientPanel3.Location = New System.Drawing.Point(1062, 111)
        Me.SiticoneCustomGradientPanel3.Name = "SiticoneCustomGradientPanel3"
        Me.SiticoneCustomGradientPanel3.Size = New System.Drawing.Size(325, 175)
        Me.SiticoneCustomGradientPanel3.TabIndex = 3
        '
        'SiticoneHtmlLabel1
        '
        Me.SiticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneHtmlLabel1.Location = New System.Drawing.Point(0, 0)
        Me.SiticoneHtmlLabel1.Name = "SiticoneHtmlLabel1"
        Me.SiticoneHtmlLabel1.Size = New System.Drawing.Size(119, 18)
        Me.SiticoneHtmlLabel1.TabIndex = 4
        Me.SiticoneHtmlLabel1.Text = "SiticoneHtmlLabel1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "EVENTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "REGISTERED"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "AVAILABLE SEAT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 159)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "10"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 159)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "24"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(289, 159)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "100"
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Available})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(380, 342)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1007, 537)
        Me.Guna2DataGridView1.TabIndex = 5
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 27
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Location"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Title"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Description"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Available
        '
        Me.Available.HeaderText = "Column5"
        Me.Available.MinimumWidth = 6
        Me.Available.Name = "Available"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoRoundedCorners = True
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderRadius = 1
        Me.Guna2Panel2.BorderThickness = 5
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Black
        Me.Guna2Panel2.Location = New System.Drawing.Point(405, 20)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(5, 59)
        Me.Guna2Panel2.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(416, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(239, 52)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Registered"
        '
        'Guna2DataGridView2
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guna2DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DataGridView2.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView2.Location = New System.Drawing.Point(380, 115)
        Me.Guna2DataGridView2.Name = "Guna2DataGridView2"
        Me.Guna2DataGridView2.RowHeadersVisible = False
        Me.Guna2DataGridView2.RowHeadersWidth = 51
        Me.Guna2DataGridView2.RowTemplate.Height = 24
        Me.Guna2DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView2.Size = New System.Drawing.Size(1007, 764)
        Me.Guna2DataGridView2.TabIndex = 6
        Me.Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView2.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 27
        Me.Guna2DataGridView2.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView2.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView2.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(1289, 911)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(98, 40)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "Save"
        '
        'Column5
        '
        Me.Column5.HeaderText = "email"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "event"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "date"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "description"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "location"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1422, 977)
        Me.Controls.Add(Me.containerPanel)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "t"
        Me.containerPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.eventPage.ResumeLayout(False)
        Me.eventPage.PerformLayout()
        Me.participantPage.ResumeLayout(False)
        Me.participantPage.PerformLayout()
        Me.panelSideBar.ResumeLayout(False)
        Me.panelSideBar.PerformLayout()
        Me.SiticoneCustomGradientPanel1.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel1.PerformLayout()
        Me.SiticoneCustomGradientPanel2.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel2.PerformLayout()
        Me.SiticoneCustomGradientPanel3.ResumeLayout(False)
        Me.SiticoneCustomGradientPanel3.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents containerPanel As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents eventPage As TabPage
    Friend WithEvents participantPage As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents SiticoneButton1 As Siticone.Desktop.UI.Winforms.SiticoneButton
    Friend WithEvents panelSideBar As Panel
    Friend WithEvents SiticoneButton2 As Siticone.Desktop.UI.Winforms.SiticoneButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents label As Label
    Friend WithEvents SiticoneCustomGradientPanel1 As Siticone.Desktop.UI.Winforms.SiticoneCustomGradientPanel
    Friend WithEvents SiticoneHtmlLabel1 As Siticone.Desktop.UI.Winforms.SiticoneHtmlLabel
    Friend WithEvents SiticoneCustomGradientPanel3 As Siticone.Desktop.UI.Winforms.SiticoneCustomGradientPanel
    Friend WithEvents SiticoneCustomGradientPanel2 As Siticone.Desktop.UI.Winforms.SiticoneCustomGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Available As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DataGridView2 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
