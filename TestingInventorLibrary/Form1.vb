Imports InventorLibraryEDT.Models
Imports InventorLibraryEDT
Imports Inventor
Imports System.Linq
Imports TestingInventorLibrary
Imports System.Windows.Forms
Imports InventorLibraryEDT.DataStructures
Imports InventorLibraryEDT.Enums
Imports InventorLibraryEDT.Interfaces

Public Class Form1
    'Inherits System.Windows.Forms.Form

    'Public g_inventorApplication As Inventor.Application
    Dim oAssy As AssemblyDocument = g_inventorApplication.ActiveDocument
    Dim STDhandler As New StandardElementHandler
    Private Sub GetSTDs()
        'For Each element In STDList
        '    MsgBox(element.X)
        '    'listBoxStandardElements.Items.Add(element.X)
        'Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GetStandardElements()
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Call ExportToExcel()
    End Sub
    Private Sub GetStandardElements()
        listViewStandardElements.Items.Clear()
        Dim ll As New EDT_LineLayout(oAssy)
        Dim listOfStandardEl = ll.StandardElements

        For Each STD As EDT_StandardElement In listOfStandardEl

            Dim lwi As ListViewItem = New ListViewItem(STD.Occurrence._DisplayName.ToString())
            lwi.SubItems.Add(STD.SpecificElement.ToString())
            lwi.SubItems.Add(STD.CurrentRating.ToString())
            lwi.SubItems.Add(STD.X.ToString())
            lwi.SubItems.Add(STD.Y.ToString())
            lwi.SubItems.Add(STD.Z.ToString())

            listViewStandardElements.Items.Add(lwi)
        Next
    End Sub
    Private Sub ExportToExcel()
        Dim ll As New EDT_LineLayout(oAssy)
        Dim listOfStandardEl = ll.StandardElements
        Call ll.ExportToFile(listOfStandardEl, EDT_Enums.ExportEnum.Excel)
    End Sub
End Class
