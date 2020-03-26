'Imports System.IO

'Public Class ConfigWriteHelper

'#Region "vars"
'    Public dictConfigKeyWordAsKeyDetailAsValue As Dictionary(Of String, ConfigLine)
'    Public ResultTableName As String
'    Private _filePath As String
'    Public ResultTable As System.Data.DataTable

'    Public Property ConfigFilePath As String
'        Get
'            Return _filePath
'        End Get
'        Set(value As String)
'            _filePath = value
'            subProcessprt()
'            convertTodt()
'        End Set
'    End Property
'#End Region

'#Region "processor"
'    Private Sub subProcessprt()

'        Dim ConfigKeyWord As String = ""
'        Dim ConfigVALUE As String = ""
'        Dim ConfigDesc As String = ""

'        Dim line As String
'        Dim sr As StreamReader = New StreamReader(_filePath, System.Text.Encoding.Default)

'        Do While sr.Peek() > 0
'            System.Windows.Forms.Application.DoEvents()
'            line = sr.ReadLine().Trim


'        Loop
'        sr.Close()
'        sr = Nothing


'    End Sub


'#End Region

'#Region "private functions"
'    Private Sub convertTodt()
'        'DIM table
'        ResultTable = New System.Data.DataTable
'        ResultTable.TableName = ResultTableName
'        ResultTable.Columns.Add("ConfigKeyWord")
'        ResultTable.Columns.Add("ConfigVALUE")
'        ResultTable.Columns.Add("ConfigDesc")

'        For Each subDict In dictConfigKeyWordAsKeyDetailAsValue
'            ResultTable.Rows.Add(subDict.Value.ConfigKeyWord, subDict.Value.ConfigVALUE, subDict.Value.ConfigDesc)
'        Next
'    End Sub

'    Private Function convertDictToArray(ByVal dict As Dictionary(Of String, Integer)) As String
'        Dim str As String = ""
'        For Each subDict In dict
'            If str = "" Then
'                str = subDict.Key
'            Else
'                str = str & ", " & subDict.Key
'            End If
'        Next
'        Return str
'    End Function
'    Private Sub addArrayToDict(ByRef dict As Dictionary(Of String, Integer), ByVal arr As String())
'        For Each sSub In arr
'            If dict.ContainsKey(sSub) = False Then
'                dict.Add(sSub, 1)
'            Else
'                dict(sSub) += 1
'            End If
'        Next

'    End Sub

'    Private Sub appendDictToDict(ByRef dictDest As Dictionary(Of String, Integer), ByRef dictSource As Dictionary(Of String, Integer))
'        For Each sSub In dictSource
'            If dictDest.ContainsKey(sSub.Key) = False Then
'                dictDest.Add(sSub.Key, sSub.Value)
'            Else
'                dictDest(sSub.Key) += sSub.Value
'            End If
'        Next
'    End Sub
'#End Region


'End Class
