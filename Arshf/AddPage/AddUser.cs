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
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        //DataBase and Tables
         DBAREntities db;
         TB_USERS tbadd;

         //Other varrble
         public int id;     //لتفرق بين عملية الاضافة ةتعديل
         public int depid;  // شرحة دقيقة 3 فيديو 20
         public Pages.UsersPage page;
         public bool state;
         public int Start;

        public List<string> DepNameList { get; private set; }

        public AddUser()
        {
            InitializeComponent();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "" || edt_username.Text == "" || edt_password.Text == "" || edt_dep.SelectedItem == null || edt_role.SelectedItem == null || depid == null)
            {
                MessageBox.Show("خطأ ادخال", "اكمل الحقول لطفا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //set Data
                //chak add or edit
                if (id == 0)
                {
                    //Add
                    tbadd = new TB_USERS
                    {
                        IDDep = depid,
                        FullName = edt_name.Text,
                        UserName = edt_username.Text,
                        Password = edt_password.Text,
                        UserRole = edt_role.Text,
                        DepName = edt_dep.Text,

                    };
                }
                //Edit
                else if (id > 0)
                {
                    tbadd = new TB_USERS
                    {
                        ID = id,
                        IDDep = depid,
                        FullName = edt_name.Text,
                        UserName = edt_username.Text,
                        Password = edt_password.Text,
                        UserRole = edt_role.Text,
                        DepName = edt_dep.Text,
                    };
                }

                //Loading Data
                Loading.Visible = true;
                // Add or Edit
                var result = await Task.Run(() => AddOrEdit(tbadd));
                if (result == true)
                {
                
                MessageBox.Show("تمت العملية بانجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                page.LoadData();
                Close();
                }
                else
                {
                    MessageBox.Show("حظأ في الاتصال", "تأكد من الاتصال بالسيرفر", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }

                Loading.Visible = false;
                //Reload Data
                page.LoadData();
            }
        }

        //Add or Edit
        private bool AddOrEdit(TB_USERS Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TB_USERS>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;
            }
            catch
            {
                state = false;
            }

            return state;
        }

        private bool LoadDepName()
        {
            try
            {
                db = new DBAREntities();
                DepNameList = db.TB_Dep.Select(x => x.DepName).ToList();
                // ادا تمت العملية معنها الحالة صح
                state = true;
            }
            catch
            {
                state = false;
            }
           return state;
        }

        private async void AddUser_Load(object sender, EventArgs e)
        {
            Loading.Visible = true;
            var rs =   await Task.Run((() => LoadDepName()));
            if (rs == true)
            {
             edt_dep.DataSource = DepNameList;
            }
            else
            {
             MessageBox.Show("حظأ في الاتصال", "تأكد من الاتصال بالسيرفر", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Loading.Visible = false;
        }

        private async void edt_dep_SelectedIndexChanged(object sender, EventArgs e)
        {

            Loading.Visible = true;
            var depName = edt_dep.Text;
            var rs = await Task.Run((() => LoadDepId(depName)));
            if (rs == false)
            {
                //  edt_dep.DataSource = DepNameList;
                MessageBox.Show("حظأ في الاتصال", "تأكد من الاتصال بالسيرفر", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
       
            Loading.Visible = false;

        }
        private bool LoadDepId(string DepName)
        {
            try
            {
                db = new DBAREntities();
                depid = db.TB_USERS.Where(x => x.DepName == DepName).Select(x => x.ID).FirstOrDefault();
                // ادا تمت العملية معنها الحالة صح
                state = true;
            }
            catch
            {
                state = false;
            }
            return state;
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Start == 1)
            {
                Application.Exit();
            }
        }
    }
}