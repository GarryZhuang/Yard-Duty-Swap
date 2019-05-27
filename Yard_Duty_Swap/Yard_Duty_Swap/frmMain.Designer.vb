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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTeacher1 = New System.Windows.Forms.Label()
        Me.lblTeacher2 = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblDuty1 = New System.Windows.Forms.Label()
        Me.txtDay1 = New System.Windows.Forms.TextBox()
        Me.txtDay2 = New System.Windows.Forms.TextBox()
        Me.txtDuty1 = New System.Windows.Forms.TextBox()
        Me.txtDuty2 = New System.Windows.Forms.TextBox()
        Me.txtLocation2 = New System.Windows.Forms.TextBox()
        Me.txtLocation1 = New System.Windows.Forms.TextBox()
        Me.lblDuty2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbxSwapDay = New System.Windows.Forms.CheckBox()
        Me.cbxSwapDuty = New System.Windows.Forms.CheckBox()
        Me.cbxSwapDuty2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift", 24.25!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(22, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(244, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Yard Duty Swap"
        '
        'lblTeacher1
        '
        Me.lblTeacher1.AutoSize = True
        Me.lblTeacher1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacher1.ForeColor = System.Drawing.Color.White
        Me.lblTeacher1.Location = New System.Drawing.Point(43, 134)
        Me.lblTeacher1.Name = "lblTeacher1"
        Me.lblTeacher1.Size = New System.Drawing.Size(85, 23)
        Me.lblTeacher1.TabIndex = 1
        Me.lblTeacher1.Text = "Teacher 1"
        '
        'lblTeacher2
        '
        Me.lblTeacher2.AutoSize = True
        Me.lblTeacher2.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacher2.ForeColor = System.Drawing.Color.White
        Me.lblTeacher2.Location = New System.Drawing.Point(39, 210)
        Me.lblTeacher2.Name = "lblTeacher2"
        Me.lblTeacher2.Size = New System.Drawing.Size(89, 23)
        Me.lblTeacher2.TabIndex = 2
        Me.lblTeacher2.Text = "Teacher 2"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(173, 104)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(41, 23)
        Me.lblDay.TabIndex = 3
        Me.lblDay.Text = "Day"
        '
        'lblDuty1
        '
        Me.lblDuty1.AutoSize = True
        Me.lblDuty1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuty1.ForeColor = System.Drawing.Color.White
        Me.lblDuty1.Location = New System.Drawing.Point(369, 104)
        Me.lblDuty1.Name = "lblDuty1"
        Me.lblDuty1.Size = New System.Drawing.Size(48, 23)
        Me.lblDuty1.TabIndex = 4
        Me.lblDuty1.Text = "Duty"
        '
        'txtDay1
        '
        Me.txtDay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay1.Location = New System.Drawing.Point(134, 130)
        Me.txtDay1.Name = "txtDay1"
        Me.txtDay1.Size = New System.Drawing.Size(120, 31)
        Me.txtDay1.TabIndex = 6
        '
        'txtDay2
        '
        Me.txtDay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay2.Location = New System.Drawing.Point(134, 206)
        Me.txtDay2.Name = "txtDay2"
        Me.txtDay2.Size = New System.Drawing.Size(120, 31)
        Me.txtDay2.TabIndex = 7
        '
        'txtDuty1
        '
        Me.txtDuty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuty1.Location = New System.Drawing.Point(333, 130)
        Me.txtDuty1.Name = "txtDuty1"
        Me.txtDuty1.Size = New System.Drawing.Size(120, 31)
        Me.txtDuty1.TabIndex = 8
        '
        'txtDuty2
        '
        Me.txtDuty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuty2.Location = New System.Drawing.Point(333, 206)
        Me.txtDuty2.Name = "txtDuty2"
        Me.txtDuty2.Size = New System.Drawing.Size(120, 31)
        Me.txtDuty2.TabIndex = 9
        '
        'txtLocation2
        '
        Me.txtLocation2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation2.Location = New System.Drawing.Point(530, 206)
        Me.txtLocation2.Name = "txtLocation2"
        Me.txtLocation2.Size = New System.Drawing.Size(120, 31)
        Me.txtLocation2.TabIndex = 12
        '
        'txtLocation1
        '
        Me.txtLocation1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation1.Location = New System.Drawing.Point(530, 130)
        Me.txtLocation1.Name = "txtLocation1"
        Me.txtLocation1.Size = New System.Drawing.Size(120, 31)
        Me.txtLocation1.TabIndex = 11
        '
        'lblDuty2
        '
        Me.lblDuty2.AutoSize = True
        Me.lblDuty2.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuty2.ForeColor = System.Drawing.Color.White
        Me.lblDuty2.Location = New System.Drawing.Point(553, 104)
        Me.lblDuty2.Name = "lblDuty2"
        Me.lblDuty2.Size = New System.Drawing.Size(82, 23)
        Me.lblDuty2.TabIndex = 10
        Me.lblDuty2.Text = "Location"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(12, 310)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 51)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(530, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 51)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cbxSwapDay
        '
        Me.cbxSwapDay.AutoSize = True
        Me.cbxSwapDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSwapDay.ForeColor = System.Drawing.Color.White
        Me.cbxSwapDay.Location = New System.Drawing.Point(134, 243)
        Me.cbxSwapDay.Name = "cbxSwapDay"
        Me.cbxSwapDay.Size = New System.Drawing.Size(128, 29)
        Me.cbxSwapDay.TabIndex = 15
        Me.cbxSwapDay.Text = "Swap Day"
        Me.cbxSwapDay.UseVisualStyleBackColor = True
        '
        'cbxSwapDuty
        '
        Me.cbxSwapDuty.AutoSize = True
        Me.cbxSwapDuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSwapDuty.ForeColor = System.Drawing.Color.White
        Me.cbxSwapDuty.Location = New System.Drawing.Point(333, 243)
        Me.cbxSwapDuty.Name = "cbxSwapDuty"
        Me.cbxSwapDuty.Size = New System.Drawing.Size(134, 29)
        Me.cbxSwapDuty.TabIndex = 16
        Me.cbxSwapDuty.Text = "Swap Duty"
        Me.cbxSwapDuty.UseVisualStyleBackColor = True
        '
        'cbxSwapDuty2
        '
        Me.cbxSwapDuty2.AutoSize = True
        Me.cbxSwapDuty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSwapDuty2.ForeColor = System.Drawing.Color.White
        Me.cbxSwapDuty2.Location = New System.Drawing.Point(530, 243)
        Me.cbxSwapDuty2.Name = "cbxSwapDuty2"
        Me.cbxSwapDuty2.Size = New System.Drawing.Size(134, 29)
        Me.cbxSwapDuty2.TabIndex = 17
        Me.cbxSwapDuty2.Text = "Swap Duty"
        Me.cbxSwapDuty2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 373)
        Me.Controls.Add(Me.cbxSwapDuty2)
        Me.Controls.Add(Me.cbxSwapDuty)
        Me.Controls.Add(Me.cbxSwapDay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtLocation2)
        Me.Controls.Add(Me.txtLocation1)
        Me.Controls.Add(Me.lblDuty2)
        Me.Controls.Add(Me.txtDuty2)
        Me.Controls.Add(Me.txtDuty1)
        Me.Controls.Add(Me.txtDay2)
        Me.Controls.Add(Me.txtDay1)
        Me.Controls.Add(Me.lblDuty1)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblTeacher2)
        Me.Controls.Add(Me.lblTeacher1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "Yard Duty Swap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTeacher1 As Label
    Friend WithEvents lblTeacher2 As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblDuty1 As Label
    Friend WithEvents txtDay1 As TextBox
    Friend WithEvents txtDay2 As TextBox
    Friend WithEvents txtDuty1 As TextBox
    Friend WithEvents txtDuty2 As TextBox
    Friend WithEvents txtLocation2 As TextBox
    Friend WithEvents txtLocation1 As TextBox
    Friend WithEvents lblDuty2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cbxSwapDay As CheckBox
    Friend WithEvents cbxSwapDuty As CheckBox
    Friend WithEvents cbxSwapDuty2 As CheckBox
End Class
