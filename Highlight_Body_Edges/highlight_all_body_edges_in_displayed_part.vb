Option Strict Off
Option Explicit On
Imports System
Imports NXOpen
Imports NXOpen.Guide

Module Program

    Sub Main()

        Dim theSession As Session = Session.GetSession()
        Dim theUI As UI = UI.GetUI()
        Dim theLW As ListingWindow = theSession.ListingWindow
        Dim displayedPart As Part = theSession.Parts.Work
        Dim bodyCollection As BodyCollection = displayedPart.Bodies
        Dim n As Integer = 0
        Dim sEdge As Edge = Nothing

        For Each sBody As Body In bodyCollection

            For Each sEdge In sBody.GetEdges()

                sEdge.Highlight()

            Next

        Next

    End Sub

    Public Function GetUnloadOption(ByVal dummy As String) As Integer

        GetUnloadOption = NXOpen.Session.LibraryUnloadOption.Immediately

    End Function


End Module