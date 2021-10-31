Imports System.Data.SqlClient

Public Class frm_users

    Private Sub InsertData()

        Dim username As String = userTbx.Text
        Dim password As String = passTbx.Text
        Dim prevBox As String = cbo_Users.Text
        Dim newdir As String = System.Windows.Forms.Application.StartupPath
        Dim query As String = "Insert into newuser (username,password,prevbox) values (@username , @password , @prevBox)"
        Using conn As SqlConnection = New SqlConnection("Server=.; Database=payrolltalent; Integrated Security=True")

            Using cmd As SqlCommand = New SqlCommand(query, conn)
                With cmd.Parameters
                    .AddWithValue("@username", username).DbType = DbType.String
                    .AddWithValue("@password", password).DbType = DbType.String
                    .AddWithValue("@prevBox", prevBox).DbType = DbType.String
                End With

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

        End Using
    End Sub

    Private Sub Reset_All_Controls()
        For Each ctrl As Control In Panel1.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""
            End If
            ' do similar for other controls you want to clear
        Next


        'Dim ctl As Control
        'For Each ctl In Panel1.Controls
        '    Select Case TypeName(ctl)
        '        Case "TextBox"
        '            ctl.Text = ""
        '        Case "CheckBox", "RadioButton"
        '            ctl.Text = ""
        '    End Select
        'Next ctl
        'DataGridView1.ClearSelection()
        ''PictureBox1.Image = Nothing 
    End Sub
    Private Sub show_DataGridView()

        Dim query As String = "Select id,username,password,prevbox From newuser "
        Using conn As SqlConnection = New SqlConnection("Server=.; Database=payrolltalent; Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, conn)
                Using sda As New SqlDataAdapter
                    cmd.Connection = conn
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
        DGV_config()

    End Sub
    Private Sub DGV_config()
        With DataGridView1
            ''اخفاء العواميد 
            '.Columns(0).Visible = False

            '' اتساع كل عمود 
            .Columns(0).Width = 50
            .Columns(1).Width = 250
            .Columns(2).Width = 250
            .Columns(3).Width = 250

            ' اختيار الصف بالكامل 
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            ' منع المستخدم من ادخال صف جديد 
            .AllowUserToAddRows = False

            'نص رؤوس الاعمدة 
            .Columns(0).HeaderText = "الكود"
            .Columns(1).HeaderText = "اسم المستخدم"
            .Columns(2).HeaderText = "كلمة السر"
            .Columns(3).HeaderText = "الرتبة"

            'تغيير تنسيق الخليه بناءا على قيمتها 
            'For i As Integer = 0 To .Rows.Count - 1 
            'If .Rows(i).Cells(4).Value < 20 Then 
            '.Rows(i).Cells(4).Style.ForeColor = Color.Red 
            '.Rows(i).Cells(4).Style.BackColor = Color.Red 
            '.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Yellow 
            'End If 
            'Next 
        End With
    End Sub

    Private Sub user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frm_Mainform.Enabled = False
        show_DataGridView()
    End Sub

    Private Sub btn_Adduser_Click(sender As Object, e As EventArgs) Handles btn_Adduser.Click
        InsertData()
        show_DataGridView()
        Reset_All_Controls()

    End Sub

    Private Sub user_form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'frm_Mainform.Enabled = True
    End Sub

    Private Sub updateData()

        Dim usercode As String = txt_Code.Text
        Dim username As String = userTbx.Text
        Dim password As String = passTbx.Text
        Dim prevBox As String = cbo_Users.Text


        Dim query As String = "update NewUser Set username= @username , password= @password , prevBox= @prevBox Where id= @id"
        Using conn As SqlConnection = New SqlConnection("Server=.; Database=payrolltalent; Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, conn)

                With cmd.Parameters
                    .AddWithValue("Id", usercode)
                    .AddWithValue("@username", username)
                    .AddWithValue("@password", password)
                    .AddWithValue("@prevBox", prevBox)
                End With

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub

    Private Sub searchData()

        Dim username As String = userTbx.Text
        Dim query As String = "Select * From newuser Where username LIKE '%' + @username + '%' "
        Using conn As SqlConnection = New SqlConnection("Server=.; Database=payrolltalent; Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    'Private Sub deleteData()
    '    Dim newdir As String = System.Windows.Forms.Application.StartupPath
    '    Dim userid As String = txt_Code.Text
    '    Dim query As String = "Delete Newuser Where id =@id "
    '    Using conn As SqlConnection = New SqlConnection("Server=shaban; Database=payrolltalent; Integrated Security=True")
    '        Using cmd As SqlCommand = New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@id", userid)
    '            conn.Open()
    '            cmd.ExecuteNonQuery()
    '            conn.Close()
    '        End Using
    '    End Using
    'End Sub

    Private Sub btn_SaveUpdate_Click(sender As Object, e As EventArgs) Handles btn_SaveUpdate.Click
        updateData()
        Reset_All_Controls()
        show_DataGridView()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        searchData()
    End Sub

    ' Use at DataGridView_SelectionChanged
    Private Sub from_DataGridView()
        Dim iRowIndex As Integer
        For i As Integer = 0 To DataGridView1.SelectedCells.Count - 1
            iRowIndex = DataGridView1.SelectedCells.Item(i).RowIndex
            txt_Code.Text = DataGridView1.Rows(iRowIndex).Cells(0).Value
            userTbx.Text = DataGridView1.Rows(iRowIndex).Cells(1).Value
            passTbx.Text = DataGridView1.Rows(iRowIndex).Cells(2).Value
            cbo_Users.Text = DataGridView1.Rows(iRowIndex).Cells(3).Value
        Next
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        from_DataGridView()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class


