Option Strict Off
Option Explicit On
Imports NXOpen.UF

Module turn_off_object_name_display
    Sub Main()

        Dim theUFSession As UFSession = UFSession.GetUFSession()

        theUFSession.Disp.SetNameDisplayStatus(UFConstants.UF_DISP_NAME_DISPLAY_OFF)

    End Sub

    Public Function GetUnloadOption(ByVal dummy As String) As Integer

        GetUnloadOption = NXOpen.Session.LibraryUnloadOption.Immediately

    End Function


End Module