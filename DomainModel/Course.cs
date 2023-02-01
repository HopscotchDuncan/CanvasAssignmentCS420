using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    internal class Course : Group
    {
        public List<Assignment> assignments = new List<Assignment>();
        public float grade { get; set; }
    }
}
