using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateurDeCV.User_Controlle
{
    public partial class HomeCtr : UserControl
    {
        public HomeCtr()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        public void Start_Click(object sender, EventArgs e)
        {
            
                Form1 frm;     //frm_main is your main form which user control is on it
            frm = (Form1)this.FindForm();
            frm.perBtn_Click(sender, e);





        }
    }
}
