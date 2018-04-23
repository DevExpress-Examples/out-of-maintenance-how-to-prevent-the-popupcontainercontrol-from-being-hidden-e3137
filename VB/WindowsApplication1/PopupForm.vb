' Developer Express Code Central Example:
' How to prevent the PopupContainerControl from being hidden
' 
' To accomplish your task, you need to use a regular form with the TopMost option
' enabled. In this case, you can manually specify when the form should be hidden.
' For more information, please see the following Knowledge Base
' article:
' 
' http://www.devexpress.com/scid=A439
' 
' This example demonstrates how
' you can show a custom form at a required location.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3137


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class PopupForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private _attachedToParentForm As Boolean
		Public Property AttachedToParentForm() As Boolean
			Get
				Return _attachedToParentForm
			End Get
			Set(ByVal value As Boolean)
				_attachedToParentForm = value
			End Set
		End Property

		Private ReadOnly _OwnerEdit As BaseEdit
		Public Sub New(ByVal ownerEdit As BaseEdit)
			_OwnerEdit = ownerEdit
			InitializeComponent()
			For i As Integer = 0 To 9
				checkedListBoxControl1.Items.Add(String.Format("Item{0}", i))
			Next i
			_attachedToParentForm = True
			TopMost = True
		End Sub

		Public Function GetResult() As String
			Dim result As String = String.Empty
			For Each item As Object In checkedListBoxControl1.CheckedItems
				result &= String.Format("{0}; ", item)
			Next item
			Return result
		End Function

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			CloseAccept()
		End Sub

		Public Sub CloseAccept()
			_OwnerEdit.EditValue = GetResult()
			Visible = False
		End Sub

		Public Sub TogglePopupFormState()
			If Visible Then
				CloseAccept()
			Else
				ShowPopupForm()
			End If
		End Sub

		Public Sub ShowPopupForm()
			Dim location As Point = _OwnerEdit.PointToScreen(New Point(0, 0))
			location.Y += _OwnerEdit.Height
			Me.Location = location
			Size = New Size(_OwnerEdit.Width, 200)
			If _attachedToParentForm Then
				Show(_OwnerEdit.FindForm())
			Else
				Show()
			End If
			Me.Location = location
		End Sub



	End Class
End Namespace