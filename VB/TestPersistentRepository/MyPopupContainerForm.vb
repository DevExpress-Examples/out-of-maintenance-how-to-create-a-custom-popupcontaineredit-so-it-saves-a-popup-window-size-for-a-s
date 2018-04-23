Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors
Imports System.Drawing



Namespace DevExpress.MyControl
	Public Class MyPopupContainerForm
		Inherits PopupContainerForm
		Public Sub New(ByVal ownerEdit As PopupContainerEdit)
			MyBase.New(ownerEdit)
		End Sub




		Protected Overrides Function CalcFormSizeCore() As Size
			Dim size As Size = MyBase.CalcFormSizeCore()
			Dim editor As MyPopupContainerEdit = TryCast(OwnerEdit, MyPopupContainerEdit)
			If editor IsNot Nothing Then

				Dim s_type As String = editor.Parent.GetType().ToString()
				Dim size_obj As Object = editor.Properties.CacheSize(s_type)
				If size_obj IsNot Nothing Then
					size = CType(size_obj, Size)
				End If
			End If

			Return size
		End Function



		Protected Overrides Sub SetPropertyStore(ByVal size As Size)
			MyBase.SetPropertyStore(size)

			Dim ri As RepositoryItemMyPopupContainerEdit = TryCast(OwnerEdit.Properties, RepositoryItemMyPopupContainerEdit)

			If ri.CacheSize IsNot Nothing Then
				Dim parent_type As String = OwnerEdit.Parent.GetType().ToString()
				If (Not ri.CacheSize.ContainsKey(parent_type)) Then
					ri.CacheSize.Add(parent_type, size)
					Return
				End If

				ri.CacheSize(parent_type) = size
			End If
		End Sub
	End Class
End Namespace
