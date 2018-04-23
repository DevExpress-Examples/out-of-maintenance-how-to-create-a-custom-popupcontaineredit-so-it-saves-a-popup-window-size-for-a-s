Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.Collections
Imports System.Drawing





Namespace DevExpress.MyControl
	Public Class RepositoryItemMyPopupContainerEdit
		Inherits RepositoryItemPopupContainerEdit
		Private cacheSize_Renamed As Hashtable

		Friend Const EDITORTypeName_Renamed As String = "MyPopupContainerEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EDITORTypeName_Renamed
			End Get
		End Property



		<Browsable(False)> _
		Public Shadows ReadOnly Property OwnerEdit() As MyPopupContainerEdit
			Get
				Return TryCast(MyBase.OwnerEdit, MyPopupContainerEdit)
			End Get
		End Property


		Public ReadOnly Property CacheSize() As Hashtable
			Get
				Return cacheSize_Renamed
			End Get
		End Property




		Shared Sub New()
			RegisterMyPopupContainerEdit()
		End Sub



		Public Sub New()
			MyBase.New()
			cacheSize_Renamed = Nothing
			cacheSize_Renamed = New Hashtable()
		End Sub


        Public Shared Sub RegisterMyPopupContainerEdit()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EDITORTypeName_Renamed, GetType(MyPopupContainerEdit), GetType(RepositoryItemMyPopupContainerEdit), GetType(PopupContainerEditViewInfo), New ButtonEditPainter(), True, CType(Nothing, Image), GetType(DevExpress.Accessibility.ButtonEditAccessible)))
        End Sub



		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			Dim source As RepositoryItemMyPopupContainerEdit = TryCast(item, RepositoryItemMyPopupContainerEdit)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Me.cacheSize_Renamed = source.CacheSize
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
