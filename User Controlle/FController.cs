using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateurDeCV.User_Controlle
{
    public partial class FController : UserControl
    {
        public FController()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 frm;     //frm_main is your main form which user control is on it
            frm = (Form1)this.FindForm();
          


            //
            frm.comBtn_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void ajformation_click(object sender, EventArgs e)
        {
            if (titleformation.Text != "")
               
            {
                
                string[] row = { titleformation.Text, debutformation.Text, finformation.Text };
                var item = "";
                foreach (string s in row)
                {
                    item = item + s + ",   ";

                }
                var listViewItem = new ListViewItem(item);
                listView1.Items.Add(listViewItem);
                
                Form1 frm;     //frm_main is your main form which user control is on it
                frm = (Form1)this.FindForm();
                //
                //add content of list view to database

                var conn = frm.connectDB();
                SqlTransaction tr = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand
                   ("insert into Formation" +
                   "(IdP,formation) " +
                   "values(1,@formation)", conn);

                cmd.Parameters.AddWithValue("@formation", titleformation.Text +
                    "  Debut :" + debutformation.Text + "  Fin :" + finformation.Text);
                cmd.Transaction = tr;

                cmd.ExecuteNonQuery();

                tr.Commit();
                conn.Close();
                MessageBox.Show("Formation ete ajoutee avec succes ...Ajouter D'autres ", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                titleformation.Text = "";



            }


            else MessageBox.Show("Le titre de la Formation est Vide", " Error ",MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
