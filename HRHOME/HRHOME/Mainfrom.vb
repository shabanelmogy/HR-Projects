Public Class frm_Mainform
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lbl_Date.Text = Now.Date.ToString("ddd d/MMM/yyyy")
        Me.lbl_Time.Text = TimeOfDay.ToString("T")
    End Sub

    Private Sub frm_Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.Enabled = False
        Login_Form.Show()
    End Sub

    Private Sub btn_Users_Click(sender As Object, e As EventArgs) Handles btn_Users.Click
        'frm_users.Show()
        With frm_users
            .TopLevel = False
            Panel2.Controls.Add(frm_users)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With frm_DashBoard
            .TopLevel = False
            Panel2.Controls.Add(frm_DashBoard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Employees_Click(sender As Object, e As EventArgs) Handles btn_Employees.Click
        With Frm_EmployeeScreen
            .TopLevel = False
            Panel2.Controls.Add(Frm_EmployeeScreen)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
