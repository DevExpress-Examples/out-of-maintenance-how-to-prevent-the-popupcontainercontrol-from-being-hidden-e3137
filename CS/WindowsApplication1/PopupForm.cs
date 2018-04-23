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
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public partial class PopupForm : DevExpress.XtraEditors.XtraForm
    {
        bool _attachedToParentForm;
        public bool AttachedToParentForm
        {
            get { return _attachedToParentForm; }
            set { _attachedToParentForm = value; }
        }

        private readonly BaseEdit _OwnerEdit;
        public PopupForm(BaseEdit ownerEdit)
        {
            _OwnerEdit = ownerEdit;
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                checkedListBoxControl1.Items.Add(String.Format("Item{0}", i));
            }
            _attachedToParentForm = true;
            TopMost = true;
        }

        public string GetResult()
        {
            string result = string.Empty;
            foreach (object item in checkedListBoxControl1.CheckedItems)
            {
                result += String.Format("{0}; ", item);
            }
            return result;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CloseAccept();
        }

        public void CloseAccept()
        {
            _OwnerEdit.EditValue = GetResult();
            Visible = false;
        }

        public void TogglePopupFormState()
        {
            if (Visible)
                CloseAccept();
            else
                ShowPopupForm();
        }

        public void ShowPopupForm()
        {
            Point location = _OwnerEdit.PointToScreen(new Point(0, 0));
            location.Y += _OwnerEdit.Height;
            Location = location;
            Size = new Size(_OwnerEdit.Width, 200);
            if (_attachedToParentForm)
                Show(_OwnerEdit.FindForm());
            else
                Show();
            Location = location;
        }
        


    }
}