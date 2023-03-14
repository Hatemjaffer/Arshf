using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Arshf.AddPage
{
    public partial class AddArshiveCategory : DevExpress.XtraEditors.XtraForm
    {
        //DataBase and Tables
         DBAREntities db;
         TB_ArchiveCategory tbadd;

         //Other varrble
         public int id;     //لتفرق بين عملية الاضافة ةتعديل
         public Pages.ArchiceCatPage page;
         public bool state;
        public AddArshiveCategory()
        {
            InitializeComponent();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "")
            {
                MessageBox.Show("حظأ الادخال", "الرجاء اكمال الحقول", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //set Data
                //chak add or edit
                if (id == 0)
                {    //Add
                    tbadd = new TB_ArchiveCategory
                    {
                        ArchiveTitel = edt_name.Text,
                        ArchiveDes = edt_detals.Text,
                        UserName = Properties.Settings.Default.FullName,
                         UserDep = Properties.Settings.Default.UserDep,
                          IDUser = Properties.Settings.Default.UserID,

                    };
                }
                //Edit
                else if (id > 0 )
                {
                    tbadd = new TB_ArchiveCategory
                    { 
                        ID = id,
                        ArchiveTitel = edt_name.Text,
                        ArchiveDes = edt_detals.Text,
                        UserName = Properties.Settings.Default.FullName,
                        UserDep = Properties.Settings.Default.UserDep,
                        IDUser = Properties.Settings.Default.UserID,
                    };
                }
                //Loading Data
                Loading.Visible = true;
               // Add or Edit
                var result = await Task.Run(() =>  AddOrEdit(tbadd));
                if (result == true)
                {
                    page.LoadData();
                    MessageBox.Show("تمت العملية بانجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("حظأ في الاتصال", "تأكد من الاتصال بالسيرفر", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Loading.Visible = false;
                //Reload Data
                page.LoadData();  
            }
        }
        
        //Add or Edit
        private bool AddOrEdit(TB_ArchiveCategory Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TB_ArchiveCategory>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;
            }
            catch
            {
                state = false;
            }

            return state;
        }
    }
}