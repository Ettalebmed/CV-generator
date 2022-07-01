using System;
using System.Data;
using System.Data.SqlClient;
using System;
namespace CreateurDeCV
{
    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();
        }

        public void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void btnHome_Click(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);

        }
        public void btnHome_MouseHover(object sender, EventArgs e)
        {
            
        }

        public void btnHome_MouseLeave(object sender, EventArgs e)
        {
            
            
        }


        public void button1_Click_1(object sender, EventArgs e)
        {
            Color orange = Color.FromArgb(254, 59, 1);
            //changer le couleru du text button

            btnHome.ForeColor = orange;
            comBtn.ForeColor = Color.Black;
            forBtn.ForeColor = Color.Black;
            lanBtn.ForeColor = Color.Black;
            perBtn.ForeColor = Color.Black;
            downloadbtn.ForeColor = Color.Black;

            //le pannel mettre visible
            phome.Visible = true;
            pfor.Visible = false;
            pcomp.Visible = false;
            pinfo.Visible = false;
            plang.Visible = false;
            piController1.Visible=false;
            pdownload.Visible = false;
            pdow.Visible = false;

            lController1.Visible=false;
            cController1.Visible=false;
            fController1.Visible=false;
            homeCtr1.Visible = true;
            homeCtr1.BringToFront(); 
            
        }
         public  void  perBtn_Click(object sender, EventArgs e)
        {
            Color orange = Color.FromArgb(254, 59, 1);
            perBtn.ForeColor = orange;
            comBtn.ForeColor = Color.Black;
            forBtn.ForeColor = Color.Black;
            lanBtn.ForeColor = Color.Black;
            btnHome.ForeColor = Color.Black;
            downloadbtn.ForeColor = Color.Black;




            phome.Visible = false;
            pfor.Visible = false;
            pcomp.Visible = false;
            pinfo.Visible = true ;
            plang.Visible = false;
            pdow.Visible = false;

            //bring PICOntroller to the page
            homeCtr1.Visible = false;
            fController1.Visible=false;
            lController1.Visible=false;
            pdownload.Visible = false;

            cController1.Visible=false;
            piController1.Visible = true;
            piController1.BringToFront();
        }
        public void perBtn_Click2()
        {
            Color orange = Color.FromArgb(254, 59, 1);
            perBtn.ForeColor = orange;
            comBtn.ForeColor = Color.Black;
            forBtn.ForeColor = Color.Black;
            lanBtn.ForeColor = Color.Black;
            btnHome.ForeColor = Color.Black;
            downloadbtn.ForeColor = Color.Black;




            phome.Visible = false;
            pfor.Visible = false;
            pcomp.Visible = false;
            pinfo.Visible = true;
            plang.Visible = false;
            pdow.Visible = false;

            //bring PICOntroller to the page
            homeCtr1.Visible = false;
            lController1.Visible = false;
            cController1.Visible = false;
            fController1.Visible = false;
            pdownload.Visible = false;

            piController1.Visible = true;
            piController1.BringToFront();
        }

        public void forBtn_Click(object sender, EventArgs e)
        {
            Color orange = Color.FromArgb(254, 59, 1);
            forBtn.ForeColor = orange;
            comBtn.ForeColor = Color.Black;
            perBtn.ForeColor = Color.Black;
            lanBtn.ForeColor = Color.Black;
            btnHome.ForeColor = Color.Black;
            downloadbtn.ForeColor = Color.Black;



            phome.Visible = false;
            pfor.Visible = true;
            pcomp.Visible = false;
            pinfo.Visible = false;
            plang.Visible = false;
            pdow.Visible = false;
            //bring controller Formtion
            homeCtr1.Visible = false;
            piController1.Visible = false;
            pdownload.Visible = false;

            lController1.Visible = false;
            fController1.Visible = true;
            fController1.BringToFront();

        }

        public void lanBtn_Click(object sender, EventArgs e)
        {
            Color orange = Color.FromArgb(254, 59, 1);
            lanBtn.ForeColor = orange;
            comBtn.ForeColor = Color.Black;
            perBtn.ForeColor = Color.Black;
            forBtn.ForeColor = Color.Black;
            btnHome.ForeColor = Color.Black;
            downloadbtn.ForeColor = Color.Black;



            phome.Visible = false;
            pfor.Visible = false;
            pcomp.Visible = false;
            pinfo.Visible = false;
            plang.Visible = true;
            pdow.Visible = false;

            homeCtr1.Visible = false;
            piController1.Visible = false;
            cController1.Visible = false;
            fController1.Visible = false;
            pdownload.Visible = false;


            lController1.Visible = true;
            lController1.BringToFront();
        }

        public void comBtn_Click(object sender, EventArgs e)
        {
            Color orange = Color.FromArgb(254, 59, 1);
            comBtn.ForeColor = orange;
            lanBtn.ForeColor = Color.Black;
            perBtn.ForeColor = Color.Black;
            forBtn.ForeColor = Color.Black;
            btnHome.ForeColor = Color.Black;
            downloadbtn.ForeColor = Color.Black;

            phome.Visible = false;
            pfor.Visible = false;
            pcomp.Visible = true;
            pinfo.Visible = false;
            plang.Visible = false;
            pdow.Visible = false;
            //brong comtroller User
            homeCtr1.Visible = false;
            piController1.Visible = false;
            fController1.Visible = false;
            lController1.Visible = false;
            pdownload.Visible = false;
            cController1.Visible = true;

            cController1.BringToFront();

        }
        public SqlConnection connectDB()
        {
            string str = "Data source=(LocalDB)\\myinstance ; Initial Catalog = GestionCVv;integrated Security=true";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            return conn;

        }


        public void Form1_Load(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);
            //connection DB 
           
        }

        public void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            button1_Click_1( sender,  e);
        }

        public void homeCtr1_Load(object sender, EventArgs e)
        {

        }

        public void downloadbtn_click(object sender, EventArgs e)
        {
            Color orange = Color.FromArgb(254, 59, 1);
            downloadbtn.ForeColor = orange;
            comBtn.ForeColor = Color.Black;
            forBtn.ForeColor = Color.Black;
            lanBtn.ForeColor = Color.Black;
            btnHome.ForeColor = Color.Black;
            perBtn.ForeColor = Color.Black;




            phome.Visible = false;
            pfor.Visible = false;
            pcomp.Visible = false;
            pinfo.Visible = false ;
            plang.Visible = false;
            pdow.Visible = true;
            pdownload.Visible = true;

            //bring PICOntroller to the page
            homeCtr1.Visible = false;
            fController1.Visible=false;
            lController1.Visible=false;
            cController1.Visible=false;
            piController1.Visible = false;
            pdownload.Visible = true;
            pdownload.BringToFront();
        }

        private void dController1_Load(object sender, EventArgs e)
        {

        }

       
    }
}