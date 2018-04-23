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
Namespace WindowsApplication1
	Partial Public Class PopupForm
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
			Me.checkedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkedListBoxControl1
			' 
			Me.checkedListBoxControl1.CheckOnClick = True
			Me.checkedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.checkedListBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.checkedListBoxControl1.Name = "checkedListBoxControl1"
			Me.checkedListBoxControl1.Size = New System.Drawing.Size(268, 240)
			Me.checkedListBoxControl1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.simpleButton1.Location = New System.Drawing.Point(0, 240)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(268, 23)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "OK"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' PopupForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(268, 263)
			Me.Controls.Add(Me.checkedListBoxControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "PopupForm"
			Me.Text = "PopupForm"
			CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private checkedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace