using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BL.EnitiyManagers;
using BL.Entities;
using BL.EntityLists;

namespace UI
{
    public partial class DV : Form
    {
        public DV()
        {
            InitializeComponent();
        }


        TitleManager titleManager;
        //titleList titles;
        titleList tcopy;
        PublisherManager publisherManager;
        PublisherList publisherList;
        BindingNavigator bindingNavigator;
        BindingSource BSrc;
        BindingSource PS;
        String PrevID;

        private void DV_Load(object sender, EventArgs e)
        {
            titleManager = new TitleManager();
            //titles = titleManager.selectAllTitles();
            tcopy = titleManager.selectAllTitles();
            BSrc = new BindingSource(tcopy, "");
            

            publisherManager = new PublisherManager();
            publisherList = publisherManager.selectAllPublishers();
            PS = new BindingSource(publisherList, "");

            bindingNavigator = new BindingNavigator(true);
            this.Controls.Add(bindingNavigator);
            bindingNavigator.Dock = DockStyle.Bottom;
            bindingNavigator.BindingSource = BSrc;

            BindingSource b = new BindingSource();

            title_id.DataBindings.Add("Text", BSrc, "title_id", true);
            title.DataBindings.Add("Text", BSrc, "title", true);
            type.DataBindings.Add("Text", BSrc, "type", true);
            price.DataBindings.Add("Value", BSrc, "price", true);
            advance.DataBindings.Add("Value", BSrc, "advance", true);
            royalty.DataBindings.Add("Value", BSrc, "royalty", true);
            sales.DataBindings.Add("Value", BSrc, "ytd_sales", true);
            notes.DataBindings.Add("Text", BSrc, "notes", true);
            pubDate.DataBindings.Add("Value", BSrc, "pubdate", true);


            b.AddingNew += (sender, e) => b.AddNew();

            comboBox1.DataSource = PS; //new Data Table
            comboBox1.DisplayMember = "pub_name"; //pub name from the Binding Source from new Data Table
            comboBox1.ValueMember = "pub_id";
            comboBox1.DataBindings.Add("SelectedValue", BSrc, "pub_id", true);

          
          
            bindingNavigator.DeleteItem.MouseDown+= (sender, e) =>
            {
                var idtodelete = (string)title_id.Text;
                titleManager.deleteTitles(idtodelete);
                MessageBox.Show("Item may not be deleted as it may be refrenced in other database tables");
                //BSrc.RemoveCurrent();
                Trace.WriteLine(idtodelete);

            };
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BSrc.EndEdit();
            foreach (title dr in tcopy)
            {
                if (dr.State == EntityState.Added)
                {
                    Trace.WriteLine("Added");

                    titleManager.insertTitles(dr.Title_id, dr.Title, dr.Type, dr.Pub_id, dr.Price, dr.Advance, dr.Royalty, dr.Ytd_sales, dr.Notes, dr.Pubdate);
                }
                else if (dr.State == EntityState.Modified)
                {
                    titleManager.updateTitles(dr.Title_id, dr.Title, dr.Type, dr.Pub_id, dr.Price, dr.Advance, dr.Royalty, dr.Ytd_sales, dr.Notes, dr.Pubdate);

                }
                dr.State = EntityState.Unchanged;
            }
        }
    }
}
