using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesUI.Helpers
{
    public class GBTDataTypesList
    {
        public List<string> TypeNames { get; set; }
        public List<string> Order { get; set; }
        public List<string> OrderType { get; set; }

        public List<int> IntegerList { get; set; }
        public List<string> StringList { get; set; }
        public List<DateTime> DateList { get; set; }


        public GBTDataTypesList()
        {
            TypeNames = new List<string>
            {
                "integer",
                "text"
            };
            Order = new List<string>
            {
                "ascending",
                "descending"
            };
            OrderType = new List<string>
            {
                "alphabetical",
                "length"
            };
        }
    }
}
