Option Strict Off
Option Explicit On
Imports NXOpen


Module Hello_World
    Sub Main()

        Dim theSession As Session = Session.GetSession()

        Guide.InfoWriteLine("Hello World!")

    End Sub

    Public Function GetUnloadOption(ByVal dummy As String) As Integer

        GetUnloadOption = NXOpen.Session.LibraryUnloadOption.Immediately

    End Function


End Module