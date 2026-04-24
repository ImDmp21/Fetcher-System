<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainInterface
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.hiddenID = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonOUT = New System.Windows.Forms.Button()
        Me.PicProfile = New System.Windows.Forms.PictureBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MIName = New System.Windows.Forms.TextBox()
        Me.MIGrade = New System.Windows.Forms.TextBox()
        Me.MIGuardian = New System.Windows.Forms.TextBox()
        Me.MILRN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MIDataTable = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MISearchBar = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MIDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.hiddenID)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.ButtonEdit)
        Me.Panel2.Controls.Add(Me.ButtonOUT)
        Me.Panel2.Controls.Add(Me.PicProfile)
        Me.Panel2.Location = New System.Drawing.Point(39, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 285)
        Me.Panel2.TabIndex = 10
        '
        'hiddenID
        '
        Me.hiddenID.AutoSize = True
        Me.hiddenID.Location = New System.Drawing.Point(38, 232)
        Me.hiddenID.Name = "hiddenID"
        Me.hiddenID.Size = New System.Drawing.Size(28, 23)
        Me.hiddenID.TabIndex = 12
        Me.hiddenID.Text = "ID"
        Me.hiddenID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.hiddenID.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.System.My.Resources.Resources.account__1_
        Me.PictureBox5.Location = New System.Drawing.Point(429, 217)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.System.My.Resources.Resources.edit_text__1_
        Me.PictureBox2.Location = New System.Drawing.Point(677, 220)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(729, 220)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(139, 35)
        Me.ButtonEdit.TabIndex = 10
        Me.ButtonEdit.Text = "Edit Info"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonOUT
        '
        Me.ButtonOUT.Location = New System.Drawing.Point(482, 219)
        Me.ButtonOUT.Name = "ButtonOUT"
        Me.ButtonOUT.Size = New System.Drawing.Size(139, 35)
        Me.ButtonOUT.TabIndex = 4
        Me.ButtonOUT.Text = "Out"
        Me.ButtonOUT.UseVisualStyleBackColor = True
        '
        'PicProfile
        '
        Me.PicProfile.Image = Global.System.My.Resources.Resources.default_profile
        Me.PicProfile.Location = New System.Drawing.Point(42, 45)
        Me.PicProfile.Name = "PicProfile"
        Me.PicProfile.Size = New System.Drawing.Size(120, 120)
        Me.PicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicProfile.TabIndex = 1
        Me.PicProfile.TabStop = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(243, 69)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(67, 25)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LRN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grade/Section:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Guardian's Contact:"
        '
        'MIName
        '
        Me.MIName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MIName.Location = New System.Drawing.Point(318, 66)
        Me.MIName.Name = "MIName"
        Me.MIName.Size = New System.Drawing.Size(648, 30)
        Me.MIName.TabIndex = 6
        '
        'MIGrade
        '
        Me.MIGrade.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MIGrade.Location = New System.Drawing.Point(390, 157)
        Me.MIGrade.Name = "MIGrade"
        Me.MIGrade.Size = New System.Drawing.Size(576, 30)
        Me.MIGrade.TabIndex = 7
        '
        'MIGuardian
        '
        Me.MIGuardian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MIGuardian.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MIGuardian.Location = New System.Drawing.Point(427, 205)
        Me.MIGuardian.Name = "MIGuardian"
        Me.MIGuardian.Size = New System.Drawing.Size(539, 30)
        Me.MIGuardian.TabIndex = 8
        '
        'MILRN
        '
        Me.MILRN.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MILRN.Location = New System.Drawing.Point(318, 113)
        Me.MILRN.Name = "MILRN"
        Me.MILRN.Size = New System.Drawing.Size(648, 30)
        Me.MILRN.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.MILRN)
        Me.GroupBox1.Controls.Add(Me.MIGuardian)
        Me.GroupBox1.Controls.Add(Me.MIGrade)
        Me.GroupBox1.Controls.Add(Me.MIName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabelName)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(72, 393)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1042, 364)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student's Info"
        '
        'MIDataTable
        '
        Me.MIDataTable.AllowUserToAddRows = False
        Me.MIDataTable.AllowUserToDeleteRows = False
        Me.MIDataTable.AllowUserToOrderColumns = True
        Me.MIDataTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MIDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MIDataTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.MIDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MIDataTable.Location = New System.Drawing.Point(59, 115)
        Me.MIDataTable.Name = "MIDataTable"
        Me.MIDataTable.ReadOnly = True
        Me.MIDataTable.RowHeadersWidth = 51
        Me.MIDataTable.RowTemplate.Height = 24
        Me.MIDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MIDataTable.Size = New System.Drawing.Size(1084, 256)
        Me.MIDataTable.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MISearchBar)
        Me.Panel1.Location = New System.Drawing.Point(45, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(970, 40)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleName = "MISearchBar"
        Me.PictureBox1.Image = Global.System.My.Resources.Resources.search3
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MISearchBar
        '
        Me.MISearchBar.AccessibleName = ""
        Me.MISearchBar.Location = New System.Drawing.Point(40, 4)
        Me.MISearchBar.Multiline = True
        Me.MISearchBar.Name = "MISearchBar"
        Me.MISearchBar.Size = New System.Drawing.Size(922, 32)
        Me.MISearchBar.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(0, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1180, 85)
        Me.Panel3.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.System.My.Resources.Resources.user_add2
        Me.PictureBox3.Location = New System.Drawing.Point(1047, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'MainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1180, 816)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MIDataTable)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "MainInterface"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MIDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonOUT As Button
    Friend WithEvents PicProfile As PictureBox
    Friend WithEvents LabelName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MIName As TextBox
    Friend WithEvents MIGrade As TextBox
    Friend WithEvents MIGuardian As TextBox
    Friend WithEvents MILRN As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MIDataTable As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MISearchBar As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents hiddenID As Label
End Class
