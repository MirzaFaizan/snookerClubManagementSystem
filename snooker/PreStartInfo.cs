using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace snooker
{
    public partial class PreStartInfo : Form
    {
        public Player p1 = new Player();
        public Player p2 = new Player();
        public List<Player> list = new List<Player>();
        public Table table;
        public bool res = false;
        public PreStartInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(p1);
            list.Add(p2);
            table = new Table(list, radioButton1.Text,radioButton5.Text);
            this.res = true;
            this.Close();
        }
    }
}
