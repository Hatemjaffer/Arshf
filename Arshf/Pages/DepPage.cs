﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Arshf.AddPage;
using DevExpress.XtraEditors;

namespace Arshf.Pages
{
    public partial class DepPage : DevExpress.XtraEditors.XtraUserControl
    {
        //Data base and Table
        private DBAREntities db;
        TB_Dep tbadd;
        
        //Other varlble
        int id;
        private bool state;

        public DepPage()
        {
            InitializeComponent();
            LoadData();
        }

        //LoadData
        public void LoadData()
        {
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.GetQueryable += entityInstantFeedbackSource1_GetQueryable;
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.DismissQueryable += entityInstantFeedbackSource1_DismissQueryable;
            //هاذي انا درتها لعمل ريفش اثناء عمليات الاضافة وحذف وتعديل
            this.entityInstantFeedbackSource1.Refresh();

        }
        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {                                                               //هاذي وضيفتها دير في سلكت من قاعدة البيانات
            // Instantiate a new DataContext                            // علما بأن هادي تجي بروحة 
            Arshf.DBAREntities dataContext = new Arshf.DBAREntities();
            // Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.TB_Dep;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {                                                                // وهاذي وضفتها دير في ست علي قاعد البيانات
            // Dispose of the DataContext
            ((Arshf.DBAREntities)e.Tag).Dispose();
        }

        //Add
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPage.AddDep add = new AddDep();
            add.btn_add.Text = "اضافة";
            add.id = 0;
            add.page = this;
            add.Show();
            
        }
        //Edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {   //Edit
                    AddPage.AddDep add = new AddDep();
                    add.btn_add.Text = "تعديل";
                    add.Text = "تعديل قسم";
                    add.id = id;
                    add.edt_name.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("DepName"));
                    add.edt_detals.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("DepDetails"));
                   
                    add.page = this;
                    add.Show();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("خظأ في العملية",exception.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
           
        }

        //Delete
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                 var result =   MessageBox.Show("اجراء حذف", "هل انت متأكد من الاجراء",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result ==DialogResult.Yes)
                 {
                     //Delete

                     //Loading
                     Loading.Visible = true;
                     tbadd = new TB_Dep
                     {
                         ID = id,
                     };
                     var rs = await Task.Run(() => Delete(tbadd));
                     if (rs == true)
                     {
                         LoadData();

                         MessageBox.Show("تم الحذف بانجاح");

                     }
                     else
                     {
                         MessageBox.Show("حظأ في الاتصال", "تأكد من الاتصال بالسيرفر", MessageBoxButtons.OK, MessageBoxIcon.Error);

                     }
                     //End
                     Loading.Visible = false;
                    }
                   
                }
                else
                {
                    MessageBox.Show("لا بيانات لحدفها");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("خظأ في العملية", exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Delete Method
        private bool Delete(TB_Dep Data)
        {
            try
            {
                db = new DBAREntities();
                db.Entry(Data).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                state = true;
            }
            catch
            {
                state = false;
            }

            return state;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
