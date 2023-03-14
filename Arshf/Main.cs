using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arshf.Pages;
using DevExpress.XtraEditors;

namespace Arshf
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            LoadHomePage(); 
        }

        //Load Home Page
        private void btn_home_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e) //1
        {
            LoadHomePage();
        }

        private void LoadHomePage()
        {
            Pages.HomePage page = new HomePage();
            LoadPage(page);
        }


        //Load Page Method
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page) // 2
        {
            try
            {
                pn_continer.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                pn_continer.Controls.Add(Page);
            }
            catch
            {}
          
        }

        private void btn_department_ItemClick(object sender, TileItemEventArgs e)
        {
            Pages.DepPage page = new DepPage();
            LoadPage(page);
        }

        private void btn_users_ItemClick(object sender, TileItemEventArgs e)
        {
            Pages.UsersPage page = new UsersPage();
            LoadPage(page);
        }

        private void btn_archive_ItemClick(object sender, TileItemEventArgs e)
        {
            Pages.ArchiceCatPage page = new ArchiceCatPage();
            LoadPage(page);
        }
    }
}
