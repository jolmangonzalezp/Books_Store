using FromLibrary.Views.Forms;
using System;
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
        BusinessLayer.Business logic;
        Features features;
        FrmLoan frmLoan;
        public Main()
        {
            InitializeComponent();
            logic = new BusinessLayer.Business();
            features = new Features();
            frmLoan = new FrmLoan();
            features.OpenNewWindow(frmLoan, panelContent);
            miLoan.BackColor = Color.Gray;
            miLoan.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoan win = new FrmLoan();
            features.OpenNewWindow(frmLoan, panelContent);
        }

        private void miMembers_Click(object sender, EventArgs e)
        {
            FrmMembers win = new FrmMembers();
            features.OpenNewWindow(win, panelContent);
        }
    }
}
