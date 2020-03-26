Public Class Form1
    Private configHelper As ConfigHelper
    Private dictConfig As Dictionary(Of String, ConfigLine)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadConfig()
        MsgBox(dictConfig(mapKey1).ConfigVALUE)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'write
        configHelper.SaveConfigFromDictToFile()

        'refresh
        ReadConfig()
    End Sub

    Sub ReadConfig()
        DataGridView1.DataSource = Nothing
        dictConfig = New Dictionary(Of String, ConfigLine)

        configHelper = New ConfigHelper
        configHelper.ResultTableName = CONST_CONFIG_TABLENAME
        configHelper.ConfigFilePath = CONST_CONFIG_FILE_PATCH
        DataGridView1.DataSource = configHelper.ResultTable
        dictConfig = configHelper.dictConfigKeyWordAsKeyDetailAsValue
        TextBox1.Text = configHelper.ExecutionLog
    End Sub
End Class
