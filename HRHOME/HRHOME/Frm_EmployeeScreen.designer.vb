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
        Me.Txt_Jobid = New System.Windows.Forms.TextBox()
        Me.Cbo_Job = New System.Windows.Forms.ComboBox()
        Me.PayrollTalentDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cbo_Dep = New System.Windows.Forms.ComboBox()
        Me.Cbo_Div = New System.Windows.Forms.ComboBox()
        Me.Cbo_branch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tab_Control1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PayrollTalentDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollTalentDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollTalentDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Control1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TxtName)
        Me.Panel1.Controls.Add(Me.Txt_ManualId)
        Me.Panel1.Location = New System.Drawing.Point(133, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 37)
        Me.Panel1.TabIndex = 0
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtName.Location = New System.Drawing.Point(89, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtName.Size = New System.Drawing.Size(511, 27)
        Me.TxtName.TabIndex = 2
        '
        'Txt_ManualId
        '
        Me.Txt_ManualId.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_ManualId.Location = New System.Drawing.Point(607, 5)
        Me.Txt_ManualId.Name = "Txt_ManualId"
        Me.Txt_ManualId.Size = New System.Drawing.Size(107, 27)
        Me.Txt_ManualId.TabIndex = 1
        Me.Txt_ManualId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Jobid
        '
        Me.Txt_Jobid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txt_Jobid.Location = New System.Drawing.Point(234, 118)
        Me.Txt_Jobid.Name = "Txt_Jobid"
        Me.Txt_Jobid.Size = New System.Drawing.Size(36, 22)
        Me.Txt_Jobid.TabIndex = 7
        '
        'Cbo_Job
        '
        Me.Cbo_Job.DataSource = Me.PayrollTalentDataSetBindingSource1
        Me.Cbo_Job.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Job.FormattingEnabled = True
        Me.Cbo_Job.Location = New System.Drawing.Point(3, 118)
        Me.Cbo_Job.Name = "Cbo_Job"
        Me.Cbo_Job.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cbo_Job.Size = New System.Drawing.Size(223, 23)
        Me.Cbo_Job.TabIndex = 1
        '
        'Cbo_Dep
        '
        Me.Cbo_Dep.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Dep.FormattingEnabled = True
        Me.Cbo_Dep.Location = New System.Drawing.Point(3, 59)
        Me.Cbo_Dep.Name = "Cbo_Dep"
        Me.Cbo_Dep.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cbo_Dep.Size = New System.Drawing.Size(223, 23)
        Me.Cbo_Dep.TabIndex = 1
        '
        'Cbo_Div
        '
        Me.Cbo_Div.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Div.FormattingEnabled = True
        Me.Cbo_Div.Location = New System.Drawing.Point(3, 90)
        Me.Cbo_Div.Name = "Cbo_Div"
        Me.Cbo_Div.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cbo_Div.Size = New System.Drawing.Size(223, 23)
        Me.Cbo_Div.TabIndex = 2
        '
        'Cbo_branch
        '
        Me.Cbo_branch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cbo_branch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_branch.FormattingEnabled = True
        Me.Cbo_branch.Location = New System.Drawing.Point(3, 27)
        Me.Cbo_branch.Name = "Cbo_branch"
        Me.Cbo_branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cbo_branch.Size = New System.Drawing.Size(223, 23)
        Me.Cbo_branch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(312, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "الفــرع"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(310, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "الوظيفة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(319, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "القسم"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(315, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "الإدارة"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(181, 150)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(89, 24)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(291, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "تاريخ التعيين"
        '
        'Btn_last
        '
        Me.Btn_last.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_last.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_last.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_last.ForeColor = System.Drawing.Color.White
        Me.Btn_last.Location = New System.Drawing.Point(207, 2)
        Me.Btn_last.Name = "Btn_last"
        Me.Btn_last.Size = New System.Drawing.Size(39, 27)
        Me.Btn_last.TabIndex = 2
        Me.Btn_last.Text = "|<"
        Me.Btn_last.UseVisualStyleBackColor = False
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Next.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.ForeColor = System.Drawing.Color.White
        Me.btn_Next.Location = New System.Drawing.Point(252, 2)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(39, 27)
        Me.btn_Next.TabIndex = 3
        Me.btn_Next.Text = "<"
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'Btn_Previous
        '
        Me.Btn_Previous.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Previous.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Previous.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Previous.ForeColor = System.Drawing.Color.White
        Me.Btn_Previous.Location = New System.Drawing.Point(607, 2)
        Me.Btn_Previous.Name = "Btn_Previous"
        Me.Btn_Previous.Size = New System.Drawing.Size(39, 27)
        Me.Btn_Previous.TabIndex = 4
        Me.Btn_Previous.Text = ">"
        Me.Btn_Previous.UseVisualStyleBackColor = False
        '
        'Btn_first
        '
        Me.Btn_first.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_first.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_first.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_first.ForeColor = System.Drawing.Color.White
        Me.Btn_first.Location = New System.Drawing.Point(659, 2)
        Me.Btn_first.Name = "Btn_first"
        Me.Btn_first.Size = New System.Drawing.Size(39, 27)
        Me.Btn_first.TabIndex = 5
        Me.Btn_first.Text = ">|"
        Me.Btn_first.UseVisualStyleBackColor = False
        '
        'Txt_Position
        '
        Me.Txt_Position.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Position.ForeColor = System.Drawing.Color.Crimson
        Me.Txt_Position.Location = New System.Drawing.Point(299, 4)
        Me.Txt_Position.Name = "Txt_Position"
        Me.Txt_Position.Size = New System.Drawing.Size(301, 24)
        Me.Txt_Position.TabIndex = 6
        Me.Txt_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_SortAsc
        '
        Me.Btn_SortAsc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_SortAsc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SortAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SortAsc.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SortAsc.ForeColor = System.Drawing.Color.White
        Me.Btn_SortAsc.Location = New System.Drawing.Point(660, 53)
        Me.Btn_SortAsc.Name = "Btn_SortAsc"
        Me.Btn_SortAsc.Size = New System.Drawing.Size(39, 25)
        Me.Btn_SortAsc.TabIndex = 7
        Me.Btn_SortAsc.Text = "ترتيب تصاعدى"
        Me.Btn_SortAsc.UseVisualStyleBackColor = False
        '
        'CboSort
        '
        Me.CboSort.FormattingEnabled = True
        Me.CboSort.Items.AddRange(New Object() {"كود الموظف", "اسم الموظف", "الفرع", "الإدارة", "القسم", "الوظيفة", "تاريخ التعيين"})
        Me.CboSort.Location = New System.Drawing.Point(436, 56)
        Me.CboSort.Name = "CboSort"
        Me.CboSort.Size = New System.Drawing.Size(166, 21)
        Me.CboSort.TabIndex = 8
        '
        'Btn_SortDes
        '
        Me.Btn_SortDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_SortDes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SortDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SortDes.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SortDes.ForeColor = System.Drawing.Color.White
        Me.Btn_SortDes.Location = New System.Drawing.Point(608, 54)
        Me.Btn_SortDes.Name = "Btn_SortDes"
        Me.Btn_SortDes.Size = New System.Drawing.Size(39, 25)
        Me.Btn_SortDes.TabIndex = 9
        Me.Btn_SortDes.Text = "ترتيب تنازلى"
        Me.Btn_SortDes.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Search.ForeColor = System.Drawing.Color.White
        Me.Btn_Search.Location = New System.Drawing.Point(394, 53)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(39, 25)
        Me.Btn_Search.TabIndex = 10
        Me.Btn_Search.Text = "Button3"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Location = New System.Drawing.Point(207, 56)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(186, 20)
        Me.Txt_Search.TabIndex = 11
        '
        'Btn_New
        '
        Me.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_New.Location = New System.Drawing.Point(630, 468)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(98, 42)
        Me.Btn_New.TabIndex = 12
        Me.Btn_New.Text = "جديد"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(477, 468)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(98, 42)
        Me.Btn_Add.TabIndex = 13
        Me.Btn_Add.Text = "إضافة"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(326, 468)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(98, 42)
        Me.Btn_Update.TabIndex = 14
        Me.Btn_Update.Text = "تعديل"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'Btn_delete
        '
        Me.Btn_delete.Location = New System.Drawing.Point(176, 468)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Size = New System.Drawing.Size(98, 42)
        Me.Btn_delete.TabIndex = 15
        Me.Btn_delete.Text = "Button1"
        Me.Btn_delete.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Btn_last)
        Me.Panel3.Controls.Add(Me.btn_Next)
        Me.Panel3.Controls.Add(Me.Btn_Previous)
        Me.Panel3.Controls.Add(Me.Btn_first)
        Me.Panel3.Controls.Add(Me.Txt_Position)
        Me.Panel3.Controls.Add(Me.CboSort)
        Me.Panel3.Controls.Add(Me.Btn_SortDes)
        Me.Panel3.Controls.Add(Me.Btn_SortAsc)
        Me.Panel3.Controls.Add(Me.Btn_Search)
        Me.Panel3.Controls.Add(Me.Txt_Search)
        Me.Panel3.Location = New System.Drawing.Point(133, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(720, 100)
        Me.Panel3.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Label6"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 138)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'tab_Control1
        '
        Me.tab_Control1.Controls.Add(Me.TabPage1)
        Me.tab_Control1.Controls.Add(Me.TabPage2)
        Me.tab_Control1.Location = New System.Drawing.Point(3, 144)
        Me.tab_Control1.Name = "tab_Control1"
        Me.tab_Control1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tab_Control1.RightToLeftLayout = True
        Me.tab_Control1.SelectedIndex = 0
        Me.tab_Control1.Size = New System.Drawing.Size(850, 323)
        Me.tab_Control1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LavenderBlush
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(842, 297)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Cbo_Job)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Txt_Jobid)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Cbo_Div)
        Me.GroupBox1.Controls.Add(Me.Cbo_Dep)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Cbo_branch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(470, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 282)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات وظيفية"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(842, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "تاريخ التأمين"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(322, 33)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.Size = New System.Drawing.Size(142, 24)
        Me.DateTimePicker2.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(169, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "تاريخ الميلاد"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(3, 149)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker3.Size = New System.Drawing.Size(98, 24)
        Me.DateTimePicker3.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(269, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 19)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "التسجيل بالتأمينات"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(270, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 19)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "مدد تأمينية سابقة"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(181, 185)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 23)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TextBox2.Location = New System.Drawing.Point(234, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(36, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TextBox3.Location = New System.Drawing.Point(234, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(36, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TextBox4.Location = New System.Drawing.Point(234, 27)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 22)
        Me.TextBox4.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(101, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 19)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "الرقم التأمينى"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(3, 184)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(98, 23)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(3, 217)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(266, 25)
        Me.TextBox6.TabIndex = 9
        '
        'Frm_EmployeeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(853, 513)
        Me.Controls.Add(Me.tab_Control1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Btn_delete)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_New)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_EmployeeScreen"
        Me.Text = "تسجيل موظف جديد"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PayrollTalentDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollTalentDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollTalentDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Control1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tab_Control1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label12 As Label
End Class
