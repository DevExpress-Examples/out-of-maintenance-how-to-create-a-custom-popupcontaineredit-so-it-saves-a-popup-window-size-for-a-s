Imports Microsoft.VisualBasic
Imports System
Namespace TestPersistentRepository
	Partial Public Class FormMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.persistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
			Me.ribbonContrl = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.repositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
			Me.repositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.gridContrl = New DevExpress.XtraGrid.GridControl()
			Me.gridV = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.treeLst = New DevExpress.XtraTreeList.TreeList()
			Me.vGridContrl = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			CType(Me.ribbonContrl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridContrl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridV, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeLst, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridContrl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonContrl
			' 
			Me.ribbonContrl.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.ribbonContrl.ExpandCollapseItem.Id = 0
			Me.ribbonContrl.ExpandCollapseItem.Name = ""
			Me.ribbonContrl.ExternalRepository = Me.persistentRepository1
			Me.ribbonContrl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonContrl.ExpandCollapseItem})
			Me.ribbonContrl.Location = New System.Drawing.Point(0, 0)
			Me.ribbonContrl.MaxItemId = 4
			Me.ribbonContrl.Name = "ribbonContrl"
			Me.ribbonContrl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonContrl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMarqueeProgressBar1, Me.repositoryItemPopupContainerEdit1, Me.repositoryItemCalcEdit1})
			Me.ribbonContrl.SelectedPage = Me.ribbonPage1
			Me.ribbonContrl.Size = New System.Drawing.Size(918, 145)
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' repositoryItemMarqueeProgressBar1
			' 
			Me.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1"
			' 
			' repositoryItemPopupContainerEdit1
			' 
			Me.repositoryItemPopupContainerEdit1.AutoHeight = False
			Me.repositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1"
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' gridContrl
			' 
			Me.gridContrl.ExternalRepository = Me.persistentRepository1
			Me.gridContrl.Location = New System.Drawing.Point(12, 151)
			Me.gridContrl.MainView = Me.gridV
			Me.gridContrl.MenuManager = Me.ribbonContrl
			Me.gridContrl.Name = "gridContrl"
			Me.gridContrl.Size = New System.Drawing.Size(488, 200)
			Me.gridContrl.TabIndex = 1
			Me.gridContrl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridV})
			' 
			' gridV
			' 
			Me.gridV.GridControl = Me.gridContrl
			Me.gridV.Name = "gridV"
			' 
			' treeLst
			' 
			Me.treeLst.ExternalRepository = Me.persistentRepository1
			Me.treeLst.Location = New System.Drawing.Point(12, 368)
			Me.treeLst.Name = "treeLst"
			Me.treeLst.Size = New System.Drawing.Size(494, 231)
			Me.treeLst.TabIndex = 2
'			Me.treeLst.CustomNodeCellEditForEditing += New DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(Me.treeLst_CustomNodeCellEditForEditing);
			' 
			' vGridContrl
			' 
			Me.vGridContrl.ExternalRepository = Me.persistentRepository1
			Me.vGridContrl.Location = New System.Drawing.Point(506, 151)
			Me.vGridContrl.Name = "vGridContrl"
			Me.vGridContrl.Size = New System.Drawing.Size(400, 200)
			Me.vGridContrl.TabIndex = 3
'			Me.vGridContrl.CustomRecordCellEditForEditing += New DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventHandler(Me.vGridContrl_CustomRecordCellEditForEditing);
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Location = New System.Drawing.Point(512, 368)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(120, 100)
			Me.popupContainerControl1.TabIndex = 5
			' 
			' FormMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(918, 611)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Controls.Add(Me.vGridContrl)
			Me.Controls.Add(Me.treeLst)
			Me.Controls.Add(Me.gridContrl)
			Me.Controls.Add(Me.ribbonContrl)
			Me.Name = "FormMain"
			Me.Text = "Main form"
			CType(Me.ribbonContrl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridContrl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridV, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeLst, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridContrl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private persistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
		Private ribbonContrl As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private gridContrl As DevExpress.XtraGrid.GridControl
		Private gridV As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents treeLst As DevExpress.XtraTreeList.TreeList
		Private WithEvents vGridContrl As DevExpress.XtraVerticalGrid.VGridControl
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private repositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
		Private repositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
	End Class
End Namespace

