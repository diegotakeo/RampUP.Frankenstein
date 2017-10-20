using Rampup.Atv2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rampup.Atv2.Construtor
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void movimentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacao move = new Movimentacao();
            move.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
