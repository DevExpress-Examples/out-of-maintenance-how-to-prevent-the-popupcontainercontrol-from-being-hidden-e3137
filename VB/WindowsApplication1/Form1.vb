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

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private _PopupForm As PopupForm
		Public Sub New()
            InitializeComponent()
            _PopupForm = New PopupForm(buttonEdit1)
        End Sub



		Private Sub buttonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit1.ButtonClick
			_PopupForm.TogglePopupFormState()
		End Sub



		Private Sub Form1_LocationChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.LocationChanged
			If _PopupForm Is Nothing Then
				Return
			End If
			_PopupForm.CloseAccept()
		End Sub

		Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.SizeChanged
			If _PopupForm Is Nothing Then
				Return
			End If
			_PopupForm.CloseAccept()
		End Sub

        Private Sub checkButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkButton1.CheckedChanged
            If _PopupForm IsNot Nothing Then
                _PopupForm.TopMost = checkButton1.Checked
            End If
        End Sub

		Private Sub checkButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkButton2.CheckedChanged
            If _PopupForm IsNot Nothing Then
                _PopupForm.AttachedToParentForm = checkButton2.Checked
            End If
        End Sub
	End Class
End Namespace