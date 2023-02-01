using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    internal class Item
    {
        public string title { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }
        public Course course { get; set; }
        public string details { get; set; }

        public void finish()
        {
            
        }
    }
}
