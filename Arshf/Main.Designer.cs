namespace Arshf
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.pn_continer = new System.Windows.Forms.Panel();
            this.btn_home = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_department = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_users = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_archive = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_settung = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_help = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowSelectedItem = true;
            this.tileBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 7;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1043, 108);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.btn_home);
            this.tileBarGroup2.Items.Add(this.btn_department);
            this.tileBarGroup2.Items.Add(this.btn_users);
            this.tileBarGroup2.Items.Add(this.btn_archive);
            this.tileBarGroup2.Items.Add(this.btn_settung);
            this.tileBarGroup2.Items.Add(this.btn_help);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // pn_continer
            // 
            this.pn_continer.BackColor = System.Drawing.Color.White;
            this.pn_continer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_continer.Location = new System.Drawing.Point(0, 108);
            this.pn_continer.Name = "pn_continer";
            this.pn_continer.Size = new System.Drawing.Size(1043, 440);
            this.pn_continer.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_home.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_home.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_home.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_home.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.Text = "الرئسية";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_home.Elements.Add(tileItemElement1);
            this.btn_home.Id = 0;
            this.btn_home.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_home.Name = "btn_home";
            this.btn_home.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_home_ItemClick);
            // 
            // btn_department
            // 
            this.btn_department.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_department.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_department.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_department.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_department.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_department.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement2.Text = "الاقسام";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_department.Elements.Add(tileItemElement2);
            this.btn_department.Id = 2;
            this.btn_department.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_department.Name = "btn_department";
            this.btn_department.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_department_ItemClick);
            // 
            // btn_users
            // 
            this.btn_users.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_users.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_users.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_users.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_users.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement3.Text = "مستخدمين";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_users.Elements.Add(tileItemElement3);
            this.btn_users.Id = 3;
            this.btn_users.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_users.Name = "btn_users";
            this.btn_users.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_users_ItemClick);
            // 
            // btn_archive
            // 
            this.btn_archive.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archive.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_archive.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_archive.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_archive.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_archive.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement4.Text = "ارشيف";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_archive.Elements.Add(tileItemElement4);
            this.btn_archive.Id = 4;
            this.btn_archive.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_archive_ItemClick);
            // 
            // btn_settung
            // 
            this.btn_settung.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settung.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_settung.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_settung.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_settung.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_settung.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement5.Text = "الاعدادات";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_settung.Elements.Add(tileItemElement5);
            this.btn_settung.Id = 5;
            this.btn_settung.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_settung.Name = "btn_settung";
            // 
            // btn_help
            // 
            this.btn_help.AppearanceItem.Normal.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_help.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_help.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_help.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_help.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement6.Text = "مساعدة";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_help.Elements.Add(tileItemElement6);
            this.btn_help.Id = 6;
            this.btn_help.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_help.Name = "btn_help";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 548);
            this.Controls.Add(this.pn_continer);
            this.Controls.Add(this.tileBar1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ارشف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_home;
        private System.Windows.Forms.Panel pn_continer;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_department;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_users;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_archive;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_settung;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_help;
    }
}

