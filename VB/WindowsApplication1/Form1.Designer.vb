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
	Partial Public Class Form1
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
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.checkButton1 = New DevExpress.XtraEditors.CheckButton()
			Me.checkButton2 = New DevExpress.XtraEditors.CheckButton()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(9, 78)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.buttonEdit1.Size = New System.Drawing.Size(232, 20)
			Me.buttonEdit1.TabIndex = 0
'			Me.buttonEdit1.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit1_ButtonClick);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(9, 40)
			Me.simpleButton3.Margin = New System.Windows.Forms.Padding(2)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(111, 24)
			Me.simpleButton3.TabIndex = 3
			Me.simpleButton3.Text = "simpleButton3"
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(126, 42)
			Me.dateEdit1.Margin = New System.Windows.Forms.Padding(2)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(115, 20)
			Me.dateEdit1.TabIndex = 6
			' 
			' checkButton1
			' 
			Me.checkButton1.Checked = True
			Me.checkButton1.Location = New System.Drawing.Point(9, 12)
			Me.checkButton1.Name = "checkButton1"
			Me.checkButton1.Size = New System.Drawing.Size(111, 23)
			Me.checkButton1.TabIndex = 7
			Me.checkButton1.Text = "TopMost"
'			Me.checkButton1.CheckedChanged += New System.EventHandler(Me.checkButton1_CheckedChanged);
			' 
			' checkButton2
			' 
			Me.checkButton2.Checked = True
			Me.checkButton2.Location = New System.Drawing.Point(126, 12)
			Me.checkButton2.Name = "checkButton2"
			Me.checkButton2.Size = New System.Drawing.Size(115, 23)
			Me.checkButton2.TabIndex = 8
			Me.checkButton2.Text = "Attach to Parent Form"
'			Me.checkButton2.CheckedChanged += New System.EventHandler(Me.checkButton2_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(259, 325)
			Me.Controls.Add(Me.checkButton2)
			Me.Controls.Add(Me.checkButton1)
			Me.Controls.Add(Me.dateEdit1)
			Me.Controls.Add(Me.simpleButton3)
			Me.Controls.Add(Me.buttonEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.SizeChanged += New System.EventHandler(Me.Form1_SizeChanged);
'			Me.LocationChanged += New System.EventHandler(Me.Form1_LocationChanged);
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private WithEvents checkButton1 As DevExpress.XtraEditors.CheckButton
		Private WithEvents checkButton2 As DevExpress.XtraEditors.CheckButton
	End Class
End Namespace

