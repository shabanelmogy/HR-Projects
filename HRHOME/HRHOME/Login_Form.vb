Imports System.Data.SqlClient

Public Class Login_Form
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub
    Private Sub login()
        If txt_Username.Text = "" Then
            MessageBox.Show("يجب ادخال اسم المستخدم حتى تستطيع الدخول", "تنبيه")
            txt_Username.Focus()
            Exit Sub
        End If
        If Txt_password.Text = "" Then
            MessageBox.Show("يجب ادخال كلمة السر حتى تستطيع الدخول", "تنبيه")
            Txt_password.Focus()
            Exit Sub
        End If
        Dim newdir As String = System.Windows.Forms.Application.StartupPath
        Dim conn As SqlConnection = New SqlConnection("Server=.; Database=payrolltalent; Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * From NewUser Where username=@username and password=@password ", conn)
        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = Trim(txt_Username.Text)
        cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = Trim(Txt_password.Text)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count <= 0 Then
            MessageBox.Show("خطأ فى اسم المستخدم او كلمة السر")
        Else
            frm_Mainform.Show()
            frm_Mainform.Enabled = True
            Me.Hide()
            frm_Mainform.Label3.Text = table.Rows(0)(1)
            ' صلاحيات المدير 
            Dim previlage As String = CStr(table.Rows(0)(3))
            If previlage = "مدير" Then
                frm_Mainform.btn_Users.Enabled = True
            End If
        End If
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        login()
    End Sub

    Private Sub txt_Username_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Username.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_password.Select()
        End If
    End Sub

    Private Sub Txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Login.PerformClick()
        End If
    End Sub
End Class