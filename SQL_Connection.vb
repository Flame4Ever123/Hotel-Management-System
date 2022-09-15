Imports System.Data.SqlClient
Public Class SQL_Connection
    Private DBCon As New SqlConnection("Server=LAPTOP-ALAN\SQLEXPRESS;Database=HotelManagementBlue;Trusted_Connection=True;")
    Private DBCmd As SqlCommand

    ' DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)

    ' Query STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()



    End Sub

    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        'RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try

            DBCon.Open()

            DBCmd = New SqlCommand(Query, DBCon)
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            Params.Clear()

            'Execute Command & Fill Dataset
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            Exception = "ExecQuery Error" & vbNewLine & ex.Message
        Finally
            'CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
End Class