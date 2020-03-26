Public Class Form1
    Dim configHelper As ConfigReadHelper
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = Nothing


        configHelper = New ConfigReadHelper
        configHelper.ResultTableName = "Test"
        configHelper.ConfigFilePath = "./Test/ConfigSample.conf"
        DataGridView1.DataSource = configHelper.ResultTable

        TextBox1.Text = configHelper.ExecutionLog
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        configHelper.SaveConfigFromDictToFile()
    End Sub
End Class
