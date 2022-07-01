using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CreateurDeCV.User_Controlle
{
    public partial class CController : UserControl
    {
        public CController()
        {
            InitializeComponent();
        }

        private void CController_Load(object sender, EventArgs e)
        {

        }

        private void competencesuivant_Click(object sender, EventArgs e)
        {
            Form1 frm;     //frm_main is your main form which user control is on it
            frm = (Form1)this.FindForm();
            frm.lanBtn_Click(sender, e);
        }

        private void addskill_Click(object sender, EventArgs e)
        {   
            Form1 frm;     //frm_main is your main form which user control is on it
            frm = (Form1)this.FindForm();
            string[] row = { skill.Text };
           
            var listViewItem = new ListViewItem(row);
            lvskills.Items.Add(listViewItem);

            var conn = frm.connectDB();
            SqlTransaction tr = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand
               ("insert into comp" +
               "(idc,idP,competence) " +
               "values(1,1,@skill)", conn);

            cmd.Parameters.AddWithValue("@skill", skill.Text);
            cmd.Transaction = tr;

            cmd.ExecuteNonQuery();

            tr.Commit();
            conn.Close();
            MessageBox.Show("Competence a ete ajoutee avec succees ...Ajouter D'autres ", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            skill.Text = "";
        }
    }
}
