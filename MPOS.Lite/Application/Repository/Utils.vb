Namespace Repository
    Public Class Utils
        Public Shared Function NullToDbl(ByVal Value As Object) As Double
            If IsDBNull(Value) Then
                Return 0.0
            Else
                If IsNumeric(Value) Then
                    Return Value
                Else
                    Return 0.0
                End If

            End If
        End Function
        Public Shared Function NullToBool(ByVal Value As Object) As Boolean
            If IsDBNull(Value) Then
                Return False
            ElseIf Value Is Nothing Then
                Return False
            ElseIf Value.ToString = "" Then
                Return False
            Else
                Return CBool(Value)
            End If
        End Function
        Public Shared Function NullToStr(ByVal Value As Object) As String
            If IsDBNull(Value) Then
                Return ""
            ElseIf Value Is Nothing Then
                Return ""
            Else
                Return Value
            End If
        End Function
        Public Shared Function AppendBackSlash(ByVal str As String) As String
            If Right(str, 1) = "\" Then
                Return str
            Else
                Return str & "\"
            End If
        End Function
        Public Shared Function NullToLong(ByVal Value As Object) As Long
            If IsDBNull(Value) Then
                Return 0
            Else
                If IsNumeric(Value) Then
                    Return Value
                Else
                    Return 0
                End If
            End If
        End Function
        Public Shared Function NullToInt(ByVal Value As Object) As Integer
            If IsDBNull(Value) Then
                Return 0
            Else
                If IsNumeric(Value) Then
                    Return Value
                Else
                    Return 0
                End If
            End If
        End Function
        Public Shared Function NullToDate(ByVal X As Object) As Date
            If TypeOf X Is Date Then
                Return CDate(X)
            Else
                Return CDate("1/1/1900")
            End If
        End Function
        Public Shared Function FixApostropi(ByVal Str As String) As String
            Return Str.Replace("'", "''")
        End Function
        Public Shared Function FixKoma(ByVal Str As String) As String
            Return Str.Replace(",", ".")
        End Function
    End Class
End Namespace