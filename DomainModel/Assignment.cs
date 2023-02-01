using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    internal class Assignment
    {
        public string description { get; set; }
        public float points { get; set; }
        public DateTime dueDate { get; set; }
        public FileExtensionsAttribute typeRestrictions { get; set; }
        public string rubric { get; set; }
        public float grade { get; set; }
        public List<string> comments { get; set; }
    }
}
