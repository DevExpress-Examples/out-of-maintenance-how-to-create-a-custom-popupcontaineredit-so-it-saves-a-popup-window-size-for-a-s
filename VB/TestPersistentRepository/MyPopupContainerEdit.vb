Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports System.Drawing



Namespace DevExpress.MyControl
	Public Class MyPopupContainerEdit
		Inherits PopupContainerEdit
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyPopupContainerEdit.EDITORTypeName_Renamed
			End Get
		End Property



		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyPopupContainerEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyPopupContainerEdit)
			End Get
		End Property



		Shared Sub New()
			RepositoryItemMyPopupContainerEdit.RegisterMyPopupContainerEdit()
		End Sub



		Public Sub New()
			MyBase.New()

		End Sub



		Protected Overrides Function CreatePopupForm() As PopupBaseForm
			If Properties.PopupControl Is Nothing Then
				Return Nothing
			End If
			Return New MyPopupContainerForm(Me)
		End Function
	End Class
End Namespace
