Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraBars
Imports DevExpress.MyControl



Namespace TestPersistentRepository
	Partial Public Class FormMain
		Inherits Form
		Private dtList As DataTable
		Private repositoryItemMyPCE As RepositoryItemMyPopupContainerEdit


		Public Sub New()
			InitializeComponent()
			InitTable()
			gridContrl.DataSource = dtList
			treeLst.DataSource = dtList
			vGridContrl.DataSource = dtList
			repositoryItemMyPCE = New RepositoryItemMyPopupContainerEdit()
			repositoryItemMyPCE.PopupControl = popupContainerControl1
			persistentRepository1.Items.Add(repositoryItemMyPCE)
			gridV.Columns("Info").ColumnEdit = repositoryItemMyPCE
			Dim bi As New BarEditItem()
			bi.Edit = repositoryItemMyPCE
			ribbonPageGroup1.ItemLinks.Add(bi)
		End Sub



		Private Sub InitTable()
			dtList = New DataTable()

			dtList.Columns.AddRange(New DataColumn() { New DataColumn("Name"), New DataColumn("Info") })
			Dim rnd As New Random()

			For i As Integer = 0 To 9
				dtList.Rows.Add(New String() { "Name_" & rnd.Next(1000, 10000).ToString(), "Info_" & rnd.Next(1000, 10000).ToString() })
			Next i
		End Sub



		Private Sub treeLst_CustomNodeCellEditForEditing(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs) Handles treeLst.CustomNodeCellEditForEditing
			e.RepositoryItem = repositoryItemMyPCE
		End Sub

		Private Sub vGridContrl_CustomRecordCellEditForEditing(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventArgs) Handles vGridContrl.CustomRecordCellEditForEditing
			e.RepositoryItem = repositoryItemMyPCE
		End Sub
	End Class
End Namespace