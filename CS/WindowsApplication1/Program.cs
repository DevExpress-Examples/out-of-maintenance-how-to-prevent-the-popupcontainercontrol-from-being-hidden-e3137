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
using System.Windows.Forms;

namespace WindowsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}