Option Strict Off
Option Explicit On
Imports NXOpen
Module highlight_all_body_faces_in_displayed_part
    Sub Main()

        Dim theSession As Session = Session.GetSession()
        Dim theUI As UI = UI.GetUI()
        Dim displayedPart As Part = theSession.Parts.Work
        Dim bodyCollection As BodyCollection = displayedPart.Bodies

        For Each sBody As Body In bodyCollection

            For Each sFace As Face In sBody.GetFaces()

                sFace.Highlight()

            Next
        Next

    End Sub

    Public Function GetUnloadOption(ByVal dummy As String) As Integer
        GetUnloadOption = NXOpen.Session.LibraryUnloadOption.Immediately

    End Function

End Module