Namespace Repository
    Module [Public]
        Public MySkin As New MetroFramework.Components.MetroStyleManager
        Public Public_User As New Model.UserLogin
        Public NamaAplikasi As String = Application.ProductName.ToUpper
        Public FormMain As View.frmMain = Nothing

        Public Function getKoneksiString() As String
            Dim Server, Port, Database, UID, Pwd As String
            Server = Ini.BacaIni("DBConfig", "Server", "localhost")
            Port = Ini.BacaIni("DBConfig", "Port", "3306")
            Database = Ini.BacaIni("DBConfig", "Database", "mposlite")
            UID = Ini.BacaIni("DBConfig", "UID", "root")
            Pwd = Ini.BacaIni("DBConfig", "Pwd", "")
            Return "Server=" & Server & ";Port=" & Port & ";Database=" & Database & ";Uid=" & UID & ";Pwd=" & Pwd & ";Convert Zero Datetime=True;"
        End Function

        Public Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New View.frmMain())
        End Sub

    End Module
End Namespace