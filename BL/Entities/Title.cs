 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entities
{
    public class title: EntityBase
    {
		private String title_id;
		public String Title_id { get{ return title_id; }
			set { 
				if ((value != title_id) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				title_id = value;
			}
		}
		String ttitle;
		public String Title
		{
			get { return ttitle; }
			set
			{
				
				if ((value != ttitle) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				ttitle = value;
			}
		}
		String type;
		public String Type
		{
			get { return type; }
			set
			{
				if ((value != type) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				type = value;

			}
		}

		String? pub_id;
		public String? Pub_id
		{
			get { return pub_id; }
			set
			{
				if ((value != pub_id) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				pub_id = value;

			}
		}

		Decimal? price;
		public Decimal? Price
		{
			get { return price; }
			set
			{
				if ((value != price) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				price = value;

			}
		}
		Decimal? advance;
		public Decimal? Advance
		{
			get { return advance; }
			set
			{
				if ((value != advance) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				advance = value;

			}
		}
		int? royalty;
		public int? Royalty
		{
			get { return royalty; }
			set
			{
				if ((value != royalty) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				royalty = value;

			}
		}

		int? ytd_Sales;
		public int? Ytd_sales
		{
			get { return ytd_Sales; }
			set
			{
				if ((value != ytd_Sales) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				ytd_Sales = value;

			}
		}
		String? notes;
		public String? Notes
		{
			get { return notes; }
			set
			{
				if ((value != notes) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				notes = value;

			}
		}
		DateTime pubdate;
		public DateTime Pubdate
		{
			get { return pubdate; }
			set
			{
				if ((value != pubdate) && (this.State != EntityState.Added))
				{
					this.State = EntityState.Modified;
				}
				pubdate = value;

			}
		}

	}

}
