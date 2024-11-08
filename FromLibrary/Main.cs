using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromLibrary
{
    public partial class Main : Form
    {
        BusinessLayer.Business logic;
        public Main()
        {
            InitializeComponent();
            logic = new BusinessLayer.Business();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLoan win = new MainLoan();
            win.ShowDialog(this);
        }
    }
}
