using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BL.EntityLists;
using BL.Entities;

namespace BL.EnitiyManagers
{
    public class TitleManager
    {
        DBManager dbManager = new DBManager();
        
        public titleList DTtoTitleList(DataTable DT)
        {
            titleList titles = new titleList();
            foreach(DataRow dr in DT.Rows)
            {  
                titles.Add(DRtoTitle(dr));
            }
            return titles;
        }

        public title DRtoTitle(DataRow dr)
        {
            title t = new title();
            t.Title_id = dr["title_id"]?.ToString()??"NA";
            t.Title = dr["title"]?.ToString() ?? "NA";
            t.Type = dr["type"]?.ToString() ?? "NA";
            t.Pub_id = dr["pub_id"]?.ToString() ?? "NA";
            decimal d;
            if (decimal.TryParse(dr["price"]?.ToString()??"0.0",out d))
                t.Price = d;
            if (decimal.TryParse(dr["advance"]?.ToString() ?? "0.0", out d))
                t.Advance = d;
            int i;
            if (int.TryParse(dr["royalty"]?.ToString() ?? "0", out i))
                t.Royalty = i;
            if (int.TryParse(dr["ytd_sales"]?.ToString() ?? "0", out i))
                t.Ytd_sales = i;
            t.Notes = dr["notes"]?.ToString() ?? "NA";
            DateTime dt;
            if (DateTime.TryParse(dr["pubdate"]?.ToString() ?? "NA", out dt))
                t.Pubdate = dt;

            t.State = EntityState.Unchanged;
            return t;
        }
        public titleList selectAllTitles()
        {
            return DTtoTitleList(dbManager.ExecuteDataTable("selectAllTitles"));
        }

        public bool insertTitles(String title_id, String Title, String type, String? pub_id, decimal? price, 
            decimal? advance, int? royalty, int? ytd_sales, string notes, DateTime? pdate)
        {
            Dictionary<string, Object> ParamList = new Dictionary<string, object>();
            ParamList["a"]= title_id;
            ParamList["b"] = Title;
            ParamList["c"] = type;
            ParamList["d"] = pub_id;
            ParamList["e"] = price;
            ParamList["f"] = advance;
            ParamList["g"] = royalty;
            ParamList["h"] = ytd_sales;
            ParamList["i"] = notes;
            ParamList["j"] = pdate;


            if (dbManager.ExecuteNonQuery("insertTitles", ParamList) > 0)
                return true;
            return false;
        }


        public bool updateTitles(String title_id, String Title, String type, String? pub_id, decimal? price,
            decimal? advance, int? royalty, int? ytd_sales, string notes, DateTime? pdate)
        {
            Dictionary<string, Object> ParamList = new Dictionary<string, object>();
            ParamList["a"] = title_id;
            ParamList["b"] = Title;
            ParamList["c"] = type;
            ParamList["d"] = pub_id;
            ParamList["e"] = price;
            ParamList["f"] = advance??0;
            ParamList["g"] = royalty??0;
            ParamList["h"] = ytd_sales??0;
            ParamList["i"] = notes;
            ParamList["j"] = pdate;
            //ParamList["a"] = title_id ?? "NA";
            //ParamList["b"] = Title ?? "NA";
            //ParamList["c"] = type ?? "NA";
            //ParamList["d"] = pub_id ?? "NA";
            //ParamList["e"] = price ?? 0;
            //ParamList["f"] = advance ?? 0;
            //ParamList["g"] = royalty ?? 0;
            //ParamList["h"] = ytd_sales ?? 0;
            //ParamList["i"] = notes ?? "NA";
            //ParamList["j"] = pdate ?? DateTime.Now;


            if (dbManager.ExecuteNonQuery("updateTitles", ParamList) > 0)
                return true;
            return false;
        }

        public bool deleteTitles(String title_id)
        {
            Dictionary<string, Object> ParamList = new Dictionary<string, object>();
            ParamList["a"] = title_id;

            if (dbManager.ExecuteNonQuery("deleteTitles", ParamList) > 0)
                return true;
            return false;
        }
    }
}
