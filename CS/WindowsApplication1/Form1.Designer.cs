// Developer Express Code Central Example:
// How to prevent the PopupContainerControl from being hidden
// 
// To accomplish your task, you need to use a regular form with the TopMost option
// enabled. In this case, you can manually specify when the form should be hidden.
// For more information, please see the following Knowledge Base
// article:
// 
// http://www.devexpress.com/scid=A439
// 
// This example demonstrates how
// you can show a custom form at a required location.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3137

namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(9, 78);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.buttonEdit1.Size = new System.Drawing.Size(232, 20);
            this.buttonEdit1.TabIndex = 0;
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(9, 40);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(111, 24);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "simpleButton3";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(126, 42);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(115, 20);
            this.dateEdit1.TabIndex = 6;
            // 
            // checkButton1
            // 
            this.checkButton1.Checked = true;
            this.checkButton1.Location = new System.Drawing.Point(9, 12);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(111, 23);
            this.checkButton1.TabIndex = 7;
            this.checkButton1.Text = "TopMost";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // checkButton2
            // 
            this.checkButton2.Checked = true;
            this.checkButton2.Location = new System.Drawing.Point(126, 12);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.Size = new System.Drawing.Size(115, 23);
            this.checkButton2.TabIndex = 8;
            this.checkButton2.Text = "Attach to Parent Form";
            this.checkButton2.CheckedChanged += new System.EventHandler(this.checkButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 325);
            this.Controls.Add(this.checkButton2);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.buttonEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.CheckButton checkButton2;
    }
}

