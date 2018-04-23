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
    partial class PopupForm
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
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.CheckOnClick = true;
            this.checkedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(268, 240);
            this.checkedListBoxControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton1.Location = new System.Drawing.Point(0, 240);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(268, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 263);
            this.Controls.Add(this.checkedListBoxControl1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupForm";
            this.Text = "PopupForm";
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}