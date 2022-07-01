namespace CreateurDeCV.User_Controlle
{
    partial class CController
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CController));
            this.skill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.competencesuivant = new Guna.UI2.WinForms.Guna2Button();
            this.lvskills = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.addskill = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skill
            // 
            this.skill.AccessibleName = "skills";
            this.skill.Location = new System.Drawing.Point(119, 113);
            this.skill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skill.Multiline = true;
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(200, 29);
            this.skill.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AccessibleName = "skills";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label5.Location = new System.Drawing.Point(52, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Skill";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.label12.Location = new System.Drawing.Point(25, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 26);
            this.label12.TabIndex = 35;
            this.label12.Text = "Competences Personnels";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 207);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // competencesuivant
            // 
            this.competencesuivant.AccessibleName = "fnextbtn";
            this.competencesuivant.BorderRadius = 20;
            this.competencesuivant.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.competencesuivant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.competencesuivant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.competencesuivant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.competencesuivant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(237)))));
            this.competencesuivant.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.competencesuivant.ForeColor = System.Drawing.Color.White;
            this.competencesuivant.Location = new System.Drawing.Point(519, 448);
            this.competencesuivant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.competencesuivant.Name = "competencesuivant";
            this.competencesuivant.Size = new System.Drawing.Size(111, 42);
            this.competencesuivant.TabIndex = 37;
            this.competencesuivant.Text = "Suivant";
            this.competencesuivant.Click += new System.EventHandler(this.competencesuivant_Click);
            // 
            // lvskills
            // 
            this.lvskills.AccessibleName = "lvformation";
            this.lvskills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvskills.LabelEdit = true;
            this.lvskills.Location = new System.Drawing.Point(388, 43);
            this.lvskills.Name = "lvskills";
            this.lvskills.Size = new System.Drawing.Size(242, 258);
            this.lvskills.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvskills.TabIndex = 44;
            this.lvskills.UseCompatibleStateImageBehavior = false;
            this.lvskills.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 400;
            // 
            // addskill
            // 
            this.addskill.AccessibleName = "fnextbtn";
            this.addskill.BorderRadius = 20;
            this.addskill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addskill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addskill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addskill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addskill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(237)))));
            this.addskill.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addskill.ForeColor = System.Drawing.Color.White;
            this.addskill.Location = new System.Drawing.Point(149, 159);
            this.addskill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addskill.Name = "addskill";
            this.addskill.Size = new System.Drawing.Size(97, 39);
            this.addskill.TabIndex = 45;
            this.addskill.Text = "Ajouter";
            this.addskill.Click += new System.EventHandler(this.addskill_Click);
            // 
            // CController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addskill);
            this.Controls.Add(this.lvskills);
            this.Controls.Add(this.competencesuivant);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.skill);
            this.Controls.Add(this.label5);
            this.Name = "CController";
            this.Size = new System.Drawing.Size(672, 517);
            this.Load += new System.EventHandler(this.CController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox skill;
        private Label label5;
        private Label label12;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button competencesuivant;
        private ListView lvskills;
        private ColumnHeader columnHeader1;
        private Guna.UI2.WinForms.Guna2Button addskill;
    }
}
