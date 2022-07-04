Option Strict Off
Option Explicit On
Imports NXOpen
Imports NXOpen.Features


Module report_all_body_features
    Sub Main()

        Dim theSession As Session = Session.GetSession()
        Dim workPart As Part = theSession.Parts.Work
        Dim theLW As ListingWindow = theSession.ListingWindow
        Dim displayedPart As Part = theSession.Parts.Display

        theLW.Open()

        For Each uBody As Body In displayedPart.Bodies

            For Each uFeature As Feature In uBody.GetFeatures
                theLW.WriteLine(uFeature.GetFeatureName)
            Next
        Next


    End Sub

    Public Function GetUnloadOption(ByVal dummy As String) As Integer

        GetUnloadOption = NXOpen.Session.LibraryUnloadOption.Immediately

    End Function


End Module