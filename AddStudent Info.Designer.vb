<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInfo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.DisplayLRN = New System.Windows.Forms.TextBox()
        Me.DisplayGuardian = New System.Windows.Forms.TextBox()
        Me.DisplayGrade = New System.Windows.Forms.TextBox()
        Me.DisplayName = New System.Windows.Forms.TextBox()
        Me.DiplayGuardian = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.PicProfile = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GenerateQR = New System.Windows.Forms.Button()
        Me.qrCodeImageBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qrCodeImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.qrCodeImageBox)
        Me.GroupBox1.Controls.Add(Me.GenerateQR)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonUpload)
        Me.GroupBox1.Controls.Add(Me.DisplayLRN)
        Me.GroupBox1.Controls.Add(Me.DisplayGuardian)
        Me.GroupBox1.Controls.Add(Me.DisplayGrade)
        Me.GroupBox1.Controls.Add(Me.DisplayName)
        Me.GroupBox1.Controls.Add(Me.DiplayGuardian)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabelName)
        Me.GroupBox1.Controls.Add(Me.PicProfile)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(62, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1132, 328)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student's Info"
        '
        'ButtonSave
        '
        Me.ButtonSave.Enabled = False
        Me.ButtonSave.Location = New System.Drawing.Point(698, 269)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(105, 35)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonUpload
        '
        Me.ButtonUpload.Location = New System.Drawing.Point(56, 215)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(90, 36)
        Me.ButtonUpload.TabIndex = 9
        Me.ButtonUpload.Text = "Upload"
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'DisplayLRN
        '
        Me.DisplayLRN.Location = New System.Drawing.Point(273, 119)
        Me.DisplayLRN.Multiline = True
        Me.DisplayLRN.Name = "DisplayLRN"
        Me.DisplayLRN.Size = New System.Drawing.Size(530, 26)
        Me.DisplayLRN.TabIndex = 7
        '
        'DisplayGuardian
        '
        Me.DisplayGuardian.Location = New System.Drawing.Point(387, 221)
        Me.DisplayGuardian.Name = "DisplayGuardian"
        Me.DisplayGuardian.Size = New System.Drawing.Size(416, 30)
        Me.DisplayGuardian.TabIndex = 8
        '
        'DisplayGrade
        '
        Me.DisplayGrade.Location = New System.Drawing.Point(345, 168)
        Me.DisplayGrade.Name = "DisplayGrade"
        Me.DisplayGrade.Size = New System.Drawing.Size(458, 30)
        Me.DisplayGrade.TabIndex = 7
        '
        'DisplayName
        '
        Me.DisplayName.Location = New System.Drawing.Point(273, 66)
        Me.DisplayName.Name = "DisplayName"
        Me.DisplayName.Size = New System.Drawing.Size(530, 30)
        Me.DisplayName.TabIndex = 6
        '
        'DiplayGuardian
        '
        Me.DiplayGuardian.AutoSize = True
        Me.DiplayGuardian.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiplayGuardian.Location = New System.Drawing.Point(195, 224)
        Me.DiplayGuardian.Name = "DiplayGuardian"
        Me.DiplayGuardian.Size = New System.Drawing.Size(177, 25)
        Me.DiplayGuardian.TabIndex = 5
        Me.DiplayGuardian.Text = "Guardian's Contact:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grade/Section:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LRN:"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(196, 66)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(67, 25)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PicProfile
        '
        Me.PicProfile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicProfile.Image = Global.System.My.Resources.Resources.default_profile
        Me.PicProfile.Location = New System.Drawing.Point(40, 66)
        Me.PicProfile.Name = "PicProfile"
        Me.PicProfile.Size = New System.Drawing.Size(120, 120)
        Me.PicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicProfile.TabIndex = 1
        Me.PicProfile.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(23, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1213, 398)
        Me.Panel1.TabIndex = 10
        '
        'GenerateQR
        '
        Me.GenerateQR.Location = New System.Drawing.Point(460, 269)
        Me.GenerateQR.Name = "GenerateQR"
        Me.GenerateQR.Size = New System.Drawing.Size(171, 35)
        Me.GenerateQR.TabIndex = 10
        Me.GenerateQR.Text = "Generate QR Code"
        Me.GenerateQR.UseVisualStyleBackColor = True
        '
        'qrCodeImageBox
        '
        Me.qrCodeImageBox.Location = New System.Drawing.Point(838, 66)
        Me.qrCodeImageBox.Name = "qrCodeImageBox"
        Me.qrCodeImageBox.Size = New System.Drawing.Size(250, 238)
        Me.qrCodeImageBox.TabIndex = 11
        Me.qrCodeImageBox.TabStop = False
        '
        'StudentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StudentInfo"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qrCodeImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents DisplayLRN As TextBox
    Friend WithEvents DisplayGuardian As TextBox
    Friend WithEvents DisplayGrade As TextBox
    Friend WithEvents DisplayName As TextBox
    Friend WithEvents DiplayGuardian As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents PicProfile As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GenerateQR As Button
    Friend WithEvents qrCodeImageBox As PictureBox
End Class
