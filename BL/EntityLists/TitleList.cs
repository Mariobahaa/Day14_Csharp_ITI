using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Entities;

namespace BL.EntityLists
{
    public class titleList: List<title>
    {
        public titleList() { }
        public titleList(titleList t)
        {
            foreach(title item in t)
            {
                this.Add(item);
            }
        }
    }
}
