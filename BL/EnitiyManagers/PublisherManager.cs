using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BL.EntityLists;
using BL.Entities;
using DAL;

namespace BL.EnitiyManagers
{
    public class PublisherManager
    {
        DBManager dbManager = new DBManager();

        public PublisherList DTtoPublisherList(DataTable DT)
        {
            PublisherList pubs = new PublisherList();
            foreach (DataRow dr in DT.Rows)
            {
                pubs.Add(DRtoPublisher(dr));
            }
            return pubs;
        }

        public Publisher DRtoPublisher(DataRow dr)
        {
            Publisher p = new Publisher();
            p.Pub_id = dr["pub_id"]?.ToString() ?? "NA";
            p.Pub_name = dr["pub_name"]?.ToString() ?? "NA";
            return p;
        }
        public PublisherList selectAllPublishers()
        {
            return DTtoPublisherList(dbManager.ExecuteDataTable("selectAllPublishers"));

        }
    }
}
