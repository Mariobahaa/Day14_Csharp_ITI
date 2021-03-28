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
    public partial class GV : Form
    {
        public GV()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        TitleManager titleManager;
        //titleList titles;
        titleList tcopy;
        PublisherManager publisherManager;
        PublisherList publisherList;

        private void GV_Load(object sender, EventArgs e)
        {
            titleManager = new TitleManager();
            //titles = titleManager.selectAllTitles();
            tcopy = titleManager.selectAllTitles();
            var source = new BindingSource(tcopy, "");
            dataGridView1.DataSource = source;

            publisherManager = new PublisherManager();
            publisherList = publisherManager.selectAllPublishers();
            var PS = new BindingSource(publisherList, "");

            DataGridViewComboBoxColumn ck = new DataGridViewComboBoxColumn();
            ck.HeaderText = "Publisher";
            ck.DisplayMember = "pub_name";
            ck.ValueMember = "pub_id";
            ck.DataSource = PS;

            ck.DataPropertyName = "pub_id";
            dataGridView1.Columns.Add(ck);

            dataGridView1.Columns["pub_id"].Visible = false;

            
            dataGridView1.UserDeletingRow+= (args, e) =>
            {
                var idToDelete = (String)e.Row.Cells["Title_id"].Value;
                titleManager.deleteTitles(idToDelete);
                
            };
        }

        private void btnDGVSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach(title dr in tcopy)
            {
                if (dr.State == EntityState.Added)
                {
                    titleManager.insertTitles(dr.Title_id, dr.Title, dr.Type, dr.Pub_id, dr.Price, dr.Advance, dr.Royalty, dr.Ytd_sales, dr.Notes, dr.Pubdate);
                }
                else if(dr.State == EntityState.Modified)
                {
                  
                    titleManager.updateTitles(dr.Title_id, dr.Title, dr.Type, dr.Pub_id, dr.Price, dr.Advance, dr.Royalty, dr.Ytd_sales, dr.Notes, dr.Pubdate);

                }
                dr.State = EntityState.Unchanged;

            }
        }
    }
}
