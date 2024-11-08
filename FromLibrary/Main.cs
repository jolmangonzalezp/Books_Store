using FromLibrary.Views.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromLibrary
{
    public partial class Main : Form
    {
        bool[] btns = new bool[] {true,false,false,false};
        ArrayList btnList = new ArrayList();

        BusinessLayer.Business logic;
        Features features;
        FrmLoan frmLoan;
        public Main()
        {
            InitializeComponent();
            logic = new BusinessLayer.Business();
            features = new Features();
            frmLoan = new FrmLoan();

            btnList.Add(miLoan);
            btnList.Add(miBooks);
            btnList.Add(miAuthor);
            btnList.Add(miMembers);

            features.OpenNewWindow(frmLoan, panelContent);
            ResetMenu();
            btns[0] = true;
            ChangeMenuItemColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            features.OpenNewWindow(new FrmLoan(), panelContent);
            ResetMenu();
            btns[0] = true;
            ChangeMenuItemColor();
        }

        private void miMembers_Click(object sender, EventArgs e)
        {
            
            features.OpenNewWindow(new FrmMembers(), panelContent);
            ResetMenu();
            btns[3] = true;
            ChangeMenuItemColor();
        }

        private void ChangeMenuItemColor()
        {
            for (int i = 0; i < btns.Length; i++)
            {
                if (btns[i])
                {
                    ToolStripMenuItem menuItem = (ToolStripMenuItem)btnList[i];
                    menuItem.BackColor = Color.Gray;
                    menuItem.ForeColor = Color.White;
                }
                else
                {
                    ToolStripMenuItem menuItem = (ToolStripMenuItem)btnList[i];
                    menuItem.BackColor = Color.White;
                    menuItem.ForeColor = Color.Gray;
                }
            }
        }

        private void ResetMenu()
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i] = false;
            }
        }

        private void miAuthor_Click(object sender, EventArgs e)
        {
            FrmMembers win = new FrmMembers();
            features.OpenNewWindow(win, panelContent);
            ResetMenu();
            btns[2] = true;
            ChangeMenuItemColor();
        }

        private void miBooks_Click(object sender, EventArgs e)
        {
            FrmMembers win = new FrmMembers();
            features.OpenNewWindow(win, panelContent);
            ResetMenu();
            btns[1] = true;
            ChangeMenuItemColor();
        }
    }
}
