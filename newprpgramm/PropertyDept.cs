using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    public class PropertyDept
    {
        private int deptid;
        private string deptname;
        private string location;

        public int Deptid
        {
            get { return deptid; }  
            set { deptid = value; }
        }
        public string Deptname
        {
            get { return deptname; }
            set { deptname = value; }
        }

        public string Location
        {
                get { return location; }    
            set { location = value; }

        }
        public override string ToString()
        {
            return $"id={deptid} name={deptname} location={location}";
        }
    }
    
}
