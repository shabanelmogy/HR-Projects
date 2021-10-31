Imports System.Data.SqlClient

Public Class Frm_EmployeeScreen

    Dim con As New SqlConnection("server=.;database=PayrollTalent;integrated security=true")

    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Dim cmd As SqlCommand

    Private Sub Frm_EmployeeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboSort.SelectedIndex = 0
        filldatatable()
        fillcboJob()
        bindingdata()
        showposition()
    End Sub

    'Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click

    '    fillcboJob()
    '    filldatatable()
    '    bindingdata()
    '    showposition()

    'End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        cur.Position += 1
        showposition()
    End Sub

    Private Sub Btn_Previous_Click(sender As Object, e As EventArgs) Handles Btn_Previous.Click
        cur.Position -= 1
        showposition()
    End Sub

    Private Sub Btn_first_Click(sender As Object, e As EventArgs) Handles Btn_first.Click
        cur.Position = 0
        showposition()
    End Sub

    Private Sub Btn_last_Click(sender As Object, e As EventArgs) Handles Btn_last.Click
        cur.Position = cur.Count - 1
        showposition()
    End Sub

    Private Sub Cbo_Job_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Job.SelectedIndexChanged

        If String.IsNullOrEmpty(Cbo_Job.Text.Trim) Then
            ErrorProvider1.SetError(Txt_Jobid, String.Empty)
        Else
            Txt_Jobid.Text = Cbo_Job.SelectedValue.ToString
        End If

    End Sub

    Private Sub Txt_Jobid_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Jobid.KeyDown
        If e.Alt And e.KeyCode = Keys.A Then
            Cbo_Job.SelectedValue = Txt_Jobid.Text
        End If
    End Sub

    Private Sub Btn_SortAsc_Click(sender As Object, e As EventArgs) Handles Btn_SortAsc.Click
        Try
            Dim columntext As String = ""

            Select Case CboSort.Text
                Case "كود الموظف"
                    columntext = "Manualid"
                Case "اسم الموظف"
                    columntext = "empname"
            End Select

            dv.Sort = columntext
            'للوقوف على اول سجل
            cur.Position = 0
            'لاظهار الرقم
            showposition()

        Catch ex As Exception
            MsgBox("يجب عرض البيانات أولا", MessageBoxIcon.Information, "تنبيه")
        End Try

    End Sub

    Private Sub Btn_SortDes_Click(sender As Object, e As EventArgs) Handles Btn_SortDes.Click

        Dim columntext As String = ""
        Select Case CboSort.Text
            Case "كود الموظف"
                columntext = "Manualid"
                dv.Sort = "manualid desc"
            Case "اسم الموظف"
                columntext = "empname"
                dv.Sort = "empname desc"
        End Select

    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        'تعريف متغير نصى لربط اختيار من الكومبوبوكس مع التكس بوكس
        Dim columntext As String = ""
        '=====================================
        'تعريف متغير رقمى لتجنب خطأ فى التحويل بين انواع الداتا المختلفة
        'اعطاءه قيمة -1 لاظهار رسالة للقيم الغير موجودة
        '=====================================
        Dim intcolumn As Integer = -1

        '=====================================
        'الترتيب قبل البحث
        '=====================================
        Select Case CboSort.Text
            Case "كود الموظف"
                columntext = "Manualid"

            Case "اسم الموظف"
                columntext = "empname"

        End Select
        dv.Sort = columntext
        '=====================================
        'البحث 
        '=====================================
        Select Case columntext
            Case "Manualid"
                intcolumn = dv.Find(Convert.ToInt32(Txt_Search.Text))
                'intcolumn = dv.Find(CInt(Txt_Search.Text))

            Case "empname"
                intcolumn = dv.Find(Convert.ToString(Txt_Search.Text))
                'intcolumn = dv.Find(CType(Txt_Search.Text, String))

        End Select
        '=====================================
        'اختبار القيم الموجودة والغير موجودة
        '=====================================
        If intcolumn = -1 Then
            MsgBox("لا يوجد نتائج للبحث", MessageBoxIcon.Information, "تنبيه")
        Else
            cur.Position = intcolumn
        End If

        showposition()

    End Sub

    Sub filldatatable()

        Dim strSearch As String = "Select *,empinfo.name as empname ,dep.name as DepName,div.name as DivName ,job.name as JobName ,job.id as Jobid, A1 from empinfo                                   
                                   left join dep on empinfo.dep=dep.id
                                   left join div on empinfo.div=div.id
                                   left join job on empinfo.job=job.id"

        dt = New DataTable
        da = New SqlDataAdapter(strSearch, con)
        da.Fill(dt)
        dv = New DataView(dt)
        cur = CType(Me.BindingContext(dv), CurrencyManager)

    End Sub

    Sub fillcboJob()

        dt = New DataTable
        da = New SqlDataAdapter("select * from job", con)
        da.Fill(dt)

        Cbo_Job.DataSource = dt
        Cbo_Job.ValueMember = "Id"
        Cbo_Job.DisplayMember = "name"

    End Sub

    Sub bindingdata()
        Txt_ManualId.DataBindings.Clear()
        TxtName.DataBindings.Clear()
        Cbo_Dep.DataBindings.Clear()
        Cbo_Div.DataBindings.Clear()
        Txt_Jobid.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        Cbo_Job.DataBindings.Clear()
        Txt_A1.DataBindings.Clear()

        Txt_ManualId.DataBindings.Add("text", dv, "manualid")
        TxtName.DataBindings.Add("text", dv, "empname")
        Cbo_Dep.DataBindings.Add("text", dv, "DepName")
        Cbo_Div.DataBindings.Add("text", dv, "DivName")
        Txt_Jobid.DataBindings.Add("text", dv, "job")
        DateTimePicker1.DataBindings.Add("value", dv, "indate")
        Cbo_Job.DataBindings.Add("selectedvalue", dv, "job")
        Txt_A1.DataBindings.Add("text", dv, "A1")
    End Sub

    Sub showposition()
        Txt_Position.Text = cur.Position + 1 & " Of " & cur.Count
    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click

        'لحذف القيم المربوطة فى databinding
        clearbindingdata()
        Txt_ManualId.Text = ""
        TxtName.Text = String.Empty
        Cbo_Dep.Text = ""
        Cbo_Div.Text = ""
        Cbo_branch.Text = ""
        Txt_A1.Text = ""

        Cbo_Job.SelectedIndex = 0
        Txt_Jobid.Text = Cbo_Job.SelectedValue
        DateTimePicker1.Value = Date.Now.ToString("dd/MM/yyyy")
        Txt_Position.Text = "إضافة سجل جديد"

        Txt_ManualId.Select()

    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

        If TxtName.Text = "" Then
            TxtName.Select()
            MsgBox("لابد من إدخال إسم الموظف", vbYes, "تحذير")
            Exit Sub
        End If

        If IsNumeric(Txt_A1.Text) = False Then
            Txt_A1.Select()
            Txt_A1.SelectAll()
            MsgBox("قيمة الراتب غير صالحة")
            Exit Sub
        End If

        dt = New DataTable
        da = New SqlDataAdapter("select name from empinfo where name = '" & TxtName.Text & "'", con)
        da.Fill(dt)
        dv = New DataView(dt)
        cur = CType(Me.BindingContext(dv), CurrencyManager)

        If cur.Count <> 0 Then
            TxtName.Select()
            MsgBox("إسم الموظف مكرر", vbYes, "تحذير")
            Exit Sub
        End If


        cmd = New SqlCommand("if not exists (select manualid from empinfo where manualid=@manualid)
                              begin insert into empinfo (manualid,name,job,indate,a1) 
                              select @manualid,@name,@job,@indate,@a1 where @manualid > 0 and @name <> '' end ", con)

        With cmd.Parameters
            .AddWithValue("@manualid", Txt_ManualId.Text).DbType = DbType.Int32
            .AddWithValue("@name", TxtName.Text).DbType = DbType.String
            .AddWithValue("@job", Txt_Jobid.Text).DbType = DbType.Int32
            .AddWithValue("@indate", DateTimePicker1.Value).DbType = DbType.DateTime
            .AddWithValue("@a1", Txt_A1.Text).DbType = DbType.Double
        End With

        'للتحقق من غلق اى اتصال مفتوح مسبقا
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("تم تحديث البيانات بنجاح", MessageBoxIcon.Information, "تحديث بيانات")
        con.Close()

        Frm_EmployeeScreen_Load(Nothing, Nothing)
        showposition()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        'حفظ موقع السجل فى متغير
        Dim posit As Integer = cur.Position
        cmd = New SqlCommand("update empinfo set name=@name,job=@job,indate=@indate,a1=@a1
                              where manualid=@manualid", con)

        With cmd.Parameters
            .AddWithValue("@manualid", Txt_ManualId.Text).DbType = DbType.Int32
            .AddWithValue("@name", TxtName.Text).DbType = DbType.String
            .AddWithValue("@job", Txt_Jobid.Text).DbType = DbType.Int32
            .AddWithValue("@indate", DateTimePicker1.Value).DbType = DbType.DateTime
            .AddWithValue("@A1", Txt_A1.Text).DbType = DbType.Double
        End With

        'للتحقق من غلق اى اتصال مفتوح مسبقا
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("تم تحديث البيانات بنجاح", MessageBoxIcon.Information, "تحديث بيانات")
        con.Close()

        Frm_EmployeeScreen_Load(Nothing, Nothing)
        'اختيار نفس موقع السجل
        cur.Position = posit
        showposition()

    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click

        Dim posit As Integer = cur.Position
        cmd = New SqlCommand("Delete From Empinfo Where manualid=@manualid", con)
        'cmd = New SqlCommand("Delete From Empinfo Where manualid= " cint(Txt_ManualId.text), con)

        With cmd.Parameters
            .AddWithValue("@manualid", Txt_ManualId.Text).DbType = DbType.Int32
        End With

        'للتحقق من غلق اى اتصال مفتوح مسبقا
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
        Dim curmanualid As Integer = CInt(Txt_ManualId.Text)
        If MsgBox("سيتم حذف بيانات الموظف رقم" & curmanualid, MessageBoxIcon.Warning + vbYesNo, "حذف البيانات") = vbYes Then

            cmd.ExecuteNonQuery()
            MsgBox("تم حذف البيانات بنجاح", MessageBoxIcon.Information, "حذف بيانات")
            con.Close()
        End If

        Frm_EmployeeScreen_Load(Nothing, Nothing)
        showposition()

    End Sub

    Sub clearbindingdata()

        Txt_ManualId.DataBindings.Clear()
        TxtName.DataBindings.Clear()
        Cbo_Dep.DataBindings.Clear()
        Cbo_Div.DataBindings.Clear()
        Txt_Jobid.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        Cbo_Job.DataBindings.Clear()
        Txt_A1.DataBindings.Clear()

    End Sub

    Private Sub Txt_Jobid_TextChanged(sender As Object, e As EventArgs) Handles Txt_Jobid.TextChanged

    End Sub

    'Sub formatdata()
    '    TextBox1.Text = Format(TextBox1.Text, "short date")
    'End Sub

End Class
