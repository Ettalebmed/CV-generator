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
    public partial class LController : UserControl
    {
        public LController()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addformation_Click(object sender, EventArgs e)
        {
            string[] row = { langueinput.SelectedItem.ToString(), niveauinput.SelectedItem.ToString() };
            var item = "";
            foreach (string s in row)
            {
                item = item + s + "  ";

            }
            var listViewItem = new ListViewItem(item);
            lvlangue.Items.Add(listViewItem);

            Form1 frm;     //frm_main is your main form which user control is on it
            frm = (Form1)this.FindForm();
            

       

            var conn = frm.connectDB();
            SqlTransaction tr = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand
               ("insert into Langue" +
               "(idL,idP,Langue) " +
               "values(1,1,@Langue)", conn);

            cmd.Parameters.AddWithValue("@Langue", langueinput.SelectedItem.ToString()+"        Niveau :  "+niveauinput.SelectedItem.ToString());
            cmd.Transaction = tr;

            cmd.ExecuteNonQuery();

            tr.Commit();
            conn.Close();
            MessageBox.Show("Langue a ete ajoutee avec succees ...Ajouter D'autres ", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 frm;     //frm is your main form which user control is on it
            frm = (Form1)this.FindForm();
            frm.downloadbtn_click(sender, e);
            
        }
    }
}
