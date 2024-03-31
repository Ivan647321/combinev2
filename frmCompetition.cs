using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class frmCompetition : Form
    {
        public frmCompetition()
        {
            InitializeComponent();
        }

        private void frmCompetition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.Competition' table. You can move, or remove it, as needed.
            this.competitionTableAdapter.Fill(this.database1DataSet4.Competition);
            getWin();
            getLose();
        }

        private void lblShowWin_Click(object sender, EventArgs e)
        {

        }
        private void getWin()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            string query = "select count(status) from Competition where status='win'";

            SqlDataAdapter command = new SqlDataAdapter(query, connection);
            connection.Open();

            int result = Convert.ToInt32(command.SelectCommand.ExecuteScalar());
            lblShowWin.Text = result.ToString();
            connection.Close();
              

        }
        private void getLose()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            string query = "select count(status) from Competition where status='lose'";

            SqlDataAdapter command = new SqlDataAdapter(query, connection);
            connection.Open();

            int result = Convert.ToInt32(command.SelectCommand.ExecuteScalar());
            lblShowLose.Text = result.ToString();
            connection.Close();


        }
    }
}
