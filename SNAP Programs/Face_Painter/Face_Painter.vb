Option Infer On
Imports Snap, Snap.Create
Imports System.Drawing

Public Class Face_Painter : Inherits UI.BlockForm

    ' Declarations of the blocks on a Face_Painter dialog

    Dim selecFaceBlock As UI.Block.SelectObject
    Dim colorPickerBlock As UI.Block.RGBColorPicker

    ' Constructor for a Face_Painter dialog object
    Public Sub New()

        Me.Title = "Face Painter"

        selecFaceBlock = New UI.Block.SelectObject("Select Faces", "Select Faces")
        selecFaceBlock.AllowMultiple = True

        colorPickerBlock = New UI.Block.RGBColorPicker()
        colorPickerBlock.Label = "Select Color"

        Me.AddBlocks(selecFaceBlock, colorPickerBlock)


    End Sub

    Public Shared Sub Main()

        ' Create and display a Face_Painter dialog
        Dim facePainter = New Face_Painter()
        facePainter.Show()

    End Sub

    Public Overrides Sub OnShow()
        '
        selecFaceBlock.SetFaceFilter()
        '
    End Sub
    Public Overrides Sub OnApply()

        For Each face As NX.NXObject In selecFaceBlock.SelectedObjects
            face.Color = colorPickerBlock.Color
        Next

    End Sub

End Class
