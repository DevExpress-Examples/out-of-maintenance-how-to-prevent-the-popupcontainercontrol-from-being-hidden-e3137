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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private PopupForm _PopupForm;
        public Form1()
        {
            InitializeComponent();
            _PopupForm = new PopupForm(buttonEdit1);
        }

        

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _PopupForm.TogglePopupFormState();
        }



        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (_PopupForm == null) return;
            _PopupForm.CloseAccept();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (_PopupForm == null) return;
            _PopupForm.CloseAccept();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            _PopupForm.TopMost = checkButton1.Checked;
        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            _PopupForm.AttachedToParentForm = checkButton2.Checked;
        }
    }
}