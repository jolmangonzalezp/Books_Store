using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromLibrary
{
    public class Features
    {
        public Features() { }

        public void OpenNewWindow(Form win, Panel container)
        {
            container.Controls.Clear();
            win.TopLevel = false;
            win.FormBorderStyle = FormBorderStyle.None;
            win.Dock = DockStyle.Fill;
            container.Controls.Add(win);
            win.Show();
        }
    }
}
