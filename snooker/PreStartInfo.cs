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

        public List<Player> list = new List<Player>();
        public Table table;
        public bool res = false;
        public PreStartInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Collect data and add into Table Object
            //setTable();
            this.res = true;
            this.Close();
        }

        public void setTable()
        {
            //check no of balls
            string noBallsChecked = ""; //checkBalls();
            string gameTypeChecked = "";//checkGameType();
            List<Player> newlist = new List<Player>();

            //newlist = getListOfPlayers();
            /* Make a Object Here pass alll the values This object will be passed back to main form where we wil use all the execution*/
            //table = new Table(list, radioButton1.Text, radioButton5.Text);
        }

        //public List<Player> getListOfPlayers() {
        //    return;
        //}
        public string checkBalls()
        {
            if (balls6.Checked == true)
            {
                return balls6.Text;
            }
            else if(balls8.Checked == true)
            {
                return balls8.Text;
            }
            else if(balls12.Checked== true)
            {
                return balls12.Text;
            }
            return "";
        }

        public string checkGameType()
        {
            return "";
        }

        private void PreStartInfo_Load(object sender, EventArgs e)
        {
            //string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            //using (SqlConnection con = new SqlConnection(ConString))
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT NAME FROM players", con);
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //    while (reader.Read())
            //    {
            //        MyCollection.Add(reader.GetString(0));
            //    }
            //    txtFirstName.AutoCompleteCustomSource = MyCollection;
            //    con.Close();
            //}
        }

        private void Match_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
