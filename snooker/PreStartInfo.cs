using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snooker
{
    public partial class PreStartInfo : Form
    {
        public Player p1 = new Player();

        public bool res=false;
        public PreStartInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.name = textBox1.Text;
            this.res = true;
            this.Close();
        }
    }
}
