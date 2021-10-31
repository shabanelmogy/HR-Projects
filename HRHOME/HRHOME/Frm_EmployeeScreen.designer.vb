<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_EmployeeScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Txt_ManualId = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txt_A1 = New System.Windows.Forms.TextBox()
        Me.Txt_Jobid = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbo_Job = New System.Windows.Forms.ComboBox()
        Me.PayrollTalentDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cbo_Dep = New System.Windows.Forms.ComboBox()
        Me.Cbo_Div = New System.Windows.Forms.ComboBox()
        Me.Cbo_branch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_last = New System.Windows.Forms.Button()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.Btn_Previous = New System.Windows.Forms.Button()
        Me.Btn_first = New System.Windows.Forms.Button()
        Me.Txt_Position = New System.Windows.Forms.TextBox()
        Me.PayrollTalentDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrollTalentDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_SortAsc = New System.Windows.Forms.Button()
        Me.CboSort = New System.Windows.Forms.ComboBox()
        Me.Btn_SortDes = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_delete = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PayrollTalentDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollTalentDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollTalentDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.TxtName)
        Me.Panel1.Controls.Add(Me.Txt_ManualId)
        Me.Panel1.Location = New System.Drawing.Point(3, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 39)
        Me.Panel1.TabIndex = 0
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtName.Location = New System.Drawing.Point(4, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtName.Size = New System.Drawing.Size(497, 27)
        Me.TxtName.TabIndex = 2
        '
        'Txt_ManualId
        '
        Me.Txt_ManualId.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_ManualId.Location = New System.Drawing.Point(508, 5)
        Me.Txt_ManualId.Name = "Txt_ManualId"
        Me.Txt_ManualId.Size = New System.Drawing.Size(107, 27)
        Me.Txt_ManualId.TabIndex = 1
        Me.Txt_ManualId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Txt_A1)
        Me.Panel2.Controls.Add(Me.Txt_Jobid)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Cbo_Job)
        Me.Panel2.Controls.Add(Me.Cbo_Dep)
        Me.Panel2.Controls.Add(Me.Cbo_Div)
        Me.Panel2.Controls.Add(Me.Cbo_branch)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(3, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(627, 122)
        Me.Panel2.TabIndex = 0
        '
        'Txt_A1
        '
        Me.Txt_A1.Location = New System.Drawing.Point(189, 90)
        Me.Txt_A1.Name = "Txt_A1"
        Me.Txt_A1.Size = New System.Drawing.Size(49, 20)
        Me.Txt_A1.TabIndex = 3
        '
        'Txt_Jobid
        '
        Me.Txt_Jobid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txt_Jobid.Location = New System.Drawing.Point(188, 44)
        Me.Txt_Jobid.Name = "Txt_Jobid"
        Me.Txt_Jobid.Size = New System.Drawing.Size(50, 22)
        Me.Txt_Jobid.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(406, 86)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(113, 24)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(524, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "تاريخ التعيين"
        '
        'Cbo_Job
        '
        Me.Cbo_Job.DataSource = Me.PayrollTalentDataSetBindingSource1
        Me.Cbo_Job.FormattingEnabled = True
        Me.Cbo_Job.Location = New System.Drawing.Point(4, 44)
        Me.Cbo_Job.Name = "Cbo_Job"
        Me.Cbo_Job.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cbo_Job.Size = New System.Drawing.Size(178, 21)
        Me.Cbo_Job.TabIndex = 1
        '
        'Cbo_Dep
        '
        Me.Cbo_Dep.FormattingEnabled = True
        Me.Cbo_Dep.Location = New System.Drawing.Point(4, 9)
        Me.Cbo_Dep.Name = "Cbo_Dep"
        Me.Cbo_Dep.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cbo_Dep.Size = New System.Drawing.Size(234, 21)
        Me.Cbo_Dep.TabIndex = 1
        '
        'Cbo_Div
        '
        Me.Cbo_Div.FormattingEnabled = True
        Me.Cbo_Div.Location = New System.Drawing.Point(302, 43)
        Me.Cbo_Div.Name = "Cbo_Div"
        Me.Cbo_Div.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cbo_Div.Size = New System.Drawing.Size(217, 21)
        Me.Cbo_Div.TabIndex = 2
        '
        'Cbo_branch
        '
        Me.Cbo_branch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cbo_branch.FormattingEnabled = True
        Me.Cbo_branch.Location = New System.Drawing.Point(302, 8)
        Me.Cbo_branch.Name = "Cbo_branch"
        Me.Cbo_branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cbo_branch.Size = New System.Drawing.Size(217, 21)
        Me.Cbo_branch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(559, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "الفــرع"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(244, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "الوظيفة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(560, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "القسم"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(244, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "الإدارة"
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.Location = New System.Drawing.Point(511, 5)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(119, 28)
        Me.Btn_Save.TabIndex = 1
        Me.Btn_Save.Text = "عرض البيانات"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Btn_last
        '
        Me.Btn_last.BackColor = System.Drawing.Color.Lavender
        Me.Btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_last.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_last.Location = New System.Drawing.Point(104, 275)
        Me.Btn_last.Name = "Btn_last"
        Me.Btn_last.Size = New System.Drawing.Size(39, 23)
        Me.Btn_last.TabIndex = 2
        Me.Btn_last.Text = "|<"
        Me.Btn_last.UseVisualStyleBackColor = False
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.Lavender
        Me.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Next.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.Location = New System.Drawing.Point(149, 275)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(39, 23)
        Me.btn_Next.TabIndex = 3
        Me.btn_Next.Text = "<"
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'Btn_Previous
        '
        Me.Btn_Previous.BackColor = System.Drawing.Color.Lavender
        Me.Btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Previous.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Previous.Location = New System.Drawing.Point(366, 275)
        Me.Btn_Previous.Name = "Btn_Previous"
        Me.Btn_Previous.Size = New System.Drawing.Size(39, 23)
        Me.Btn_Previous.TabIndex = 4
        Me.Btn_Previous.Text = ">"
        Me.Btn_Previous.UseVisualStyleBackColor = False
        '
        'Btn_first
        '
        Me.Btn_first.BackColor = System.Drawing.Color.Lavender
        Me.Btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_first.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_first.Location = New System.Drawing.Point(411, 275)
        Me.Btn_first.Name = "Btn_first"
        Me.Btn_first.Size = New System.Drawing.Size(39, 23)
        Me.Btn_first.TabIndex = 5
        Me.Btn_first.Text = ">|"
        Me.Btn_first.UseVisualStyleBackColor = False
        '
        'Txt_Position
        '
        Me.Txt_Position.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Position.Location = New System.Drawing.Point(194, 275)
        Me.Txt_Position.Name = "Txt_Position"
        Me.Txt_Position.Size = New System.Drawing.Size(166, 24)
        Me.Txt_Position.TabIndex = 6
        Me.Txt_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_SortAsc
        '
        Me.Btn_SortAsc.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_SortAsc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SortAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SortAsc.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SortAsc.ForeColor = System.Drawing.Color.White
        Me.Btn_SortAsc.Location = New System.Drawing.Point(313, 213)
        Me.Btn_SortAsc.Name = "Btn_SortAsc"
        Me.Btn_SortAsc.Size = New System.Drawing.Size(96, 25)
        Me.Btn_SortAsc.TabIndex = 7
        Me.Btn_SortAsc.Text = "ترتيب تصاعدى"
        Me.Btn_SortAsc.UseVisualStyleBackColor = False
        '
        'CboSort
        '
        Me.CboSort.FormattingEnabled = True
        Me.CboSort.Items.AddRange(New Object() {"كود الموظف", "اسم الموظف", "الفرع", "الإدارة", "القسم", "الوظيفة", "تاريخ التعيين"})
        Me.CboSort.Location = New System.Drawing.Point(104, 215)
        Me.CboSort.Name = "CboSort"
        Me.CboSort.Size = New System.Drawing.Size(203, 21)
        Me.CboSort.TabIndex = 8
        '
        'Btn_SortDes
        '
        Me.Btn_SortDes.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SortDes.Location = New System.Drawing.Point(416, 215)
        Me.Btn_SortDes.Name = "Btn_SortDes"
        Me.Btn_SortDes.Size = New System.Drawing.Size(84, 23)
        Me.Btn_SortDes.TabIndex = 9
        Me.Btn_SortDes.Text = "ترتيب تنازلى"
        Me.Btn_SortDes.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.Location = New System.Drawing.Point(313, 242)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(96, 25)
        Me.Btn_Search.TabIndex = 10
        Me.Btn_Search.Text = "Button3"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Txt_Search
        '
        Me.Txt_Search.Location = New System.Drawing.Point(104, 245)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(203, 20)
        Me.Txt_Search.TabIndex = 11
        '
        'Btn_New
        '
        Me.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_New.Location = New System.Drawing.Point(532, 331)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(98, 23)
        Me.Btn_New.TabIndex = 12
        Me.Btn_New.Text = "جديد"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(428, 331)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(98, 23)
        Me.Btn_Add.TabIndex = 13
        Me.Btn_Add.Text = "إضافة"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(324, 331)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(98, 23)
        Me.Btn_Update.TabIndex = 14
        Me.Btn_Update.Text = "تعديل"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'Btn_delete
        '
        Me.Btn_delete.Location = New System.Drawing.Point(220, 331)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Size = New System.Drawing.Size(98, 23)
        Me.Btn_delete.TabIndex = 15
        Me.Btn_delete.Text = "Button1"
        Me.Btn_delete.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(637, 366)
        Me.Controls.Add(Me.Btn_delete)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_New)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Btn_SortDes)
        Me.Controls.Add(Me.CboSort)
        Me.Controls.Add(Me.Btn_SortAsc)
        Me.Controls.Add(Me.Txt_Position)
        Me.Controls.Add(Me.Btn_first)
        Me.Controls.Add(Me.Btn_Previous)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.Btn_last)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "تسجيل موظف جديد"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PayrollTalentDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollTalentDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollTalentDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Txt_ManualId As TextBox
    Friend WithEvents Cbo_Job As ComboBox
    Friend WithEvents Cbo_Dep As ComboBox
    Friend WithEvents Cbo_Div As ComboBox
    Friend WithEvents Cbo_branch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Btn_last As Button
    Friend WithEvents btn_Next As Button
    Friend WithEvents Btn_Previous As Button
    Friend WithEvents Btn_first As Button
    Friend WithEvents Txt_Position As TextBox
    Friend WithEvents PayrollTalentDataSetBindingSource As BindingSource

    Friend WithEvents PayrollTalentDataSetBindingSource1 As BindingSource

    Friend WithEvents PayrollTalentDataSet2BindingSource As BindingSource
    Friend WithEvents Txt_Jobid As TextBox
    Friend WithEvents Btn_SortAsc As Button
    Friend WithEvents CboSort As ComboBox
    Friend WithEvents Btn_SortDes As Button
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Btn_New As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Txt_A1 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
