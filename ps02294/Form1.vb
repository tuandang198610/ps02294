Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmdn
    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim ketnoi As String = "workstation id=ps02294.mssql.somee.com;packet size=4096;user id=tuan02294;pwd=bmwklt89;data source=ps02294.mssql.somee.com;persist security info=False;initial catalog=ps02294"
        Dim lienket As SqlConnection = New SqlConnection(ketnoi)
        Dim sqladapter As New SqlDataAdapter("select * from NhanVien where user='" & txtdangnhap.Text & "' and password='" & txtpassword.Text & "' ", lienket)
        Dim tb As New DataTable

        Try
            lienket.Open()
            sqladapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("chuc mung dang nhap thanh cong")
                frmmain.Show()
                Me.Hide()

            Else
                MessageBox.Show("khong dung tai khoan")

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
