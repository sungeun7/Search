Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        dataGridView1.DataSource = Me.PopulateDataGridView()
    End Sub

    Private Sub txtName_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyUp
        dataGridView1.DataSource = Me.PopulateDataGridView()
    End Sub

    Private Function PopulateDataGridView() As DataTable
        Dim query As String = "SELECT CustomerID, ContactName, Country FROM Customers"
        query &= " WHERE ContactName LIKE '%' + @ContactName + '%'"
        query &= " OR @ContactName = ''"
        Dim constr As String = "Data Source=.\SQL2005;Initial Catalog=Northwind;User ID=sa;Password=pass@123"
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ContactName", txtName.Text.Trim())
                Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable()
                    sda.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
End Class
