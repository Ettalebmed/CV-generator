using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateurDeCV.User_Controlle
{
    public partial class PIController : UserControl
    {
        static int count=0;
        public PIController()
        {
            InitializeComponent();
        }

        private void PIController_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select Image(*.jpg;*.png;*.GIF)|*.jpg;*.png;*.GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                userpicture.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpnom_TextChanged(object sender, EventArgs e)
        {

        }


       


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
                Form1 frm;     //frm_main is your main form which user control is on it
                frm = (Form1)this.FindForm();
                frm.forBtn_Click(sender, e);


               

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        byte[] convertImgToByte(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();

            }
        }

        Image convertByteToImage(Byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public void enregistrer(object sender, EventArgs e)
        {
                count++;
                Form1 frm;     //frm_main is your main form which user control is on it
                frm = (Form1)this.FindForm();



                //database connection
                var conn = frm.connectDB();

                SqlTransaction tr = conn.BeginTransaction();

                inpdatenaissance.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012".  
                inpdatenaissance.CustomFormat = "yyyy-MM-dd hh:MM:ss";

                var nom = this.inpnom.Text;
                var prenom = this.inpprenom.Text;
                var adresse = this.inpadresse.Text;
                var paye = this.inppaye.Text;
                var ville = this.inpville.Text;
                var description = this.inpdescription.Text;
                var date_naissance = this.inpdatenaissance.Text;
                var img = userpicture.Image;
               
            
                SqlCommand cmd = new SqlCommand
                ("insert into Personne" +
                "(nom,prenom,datenaissance,adresse,ville,paye,photo,description) " +
                "values('" + nom + "','" + prenom + "','" + date_naissance 
                + "','" + adresse + "','" + ville + "','" + paye + "','" +
               " @image" + "','" + description + "')", conn);

                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "insert into Personne(nom,prenom,age,ville,paye) values('mohamed','mohamed',12,'mohamed','mohamed')";
                cmd.Parameters.AddWithValue("@Image",convertImgToByte(img));
                cmd.Transaction = tr;

                cmd.ExecuteNonQuery();
                tr.Commit();
                conn.Close();
            inpnom.Text = "";
            inpprenom.Text = "";
            inpadresse.Text = "";
            inppaye.Text = "";
            inpville.Text = "";
            inpdescription.Text = "";
            inpdatenaissance.Text = "";


            if (count==1)
                MessageBox.Show("les donnes enregistree avec succes ", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("les nouveux donnes personnelles enregistrer avec succes ", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);



            guna2Button2_Click(sender, new EventArgs());
        }

        private void inpdatenaissance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
