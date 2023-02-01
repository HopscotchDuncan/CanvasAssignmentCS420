using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    internal class Group
    {
        public List<Teacher> teachers = new List<Teacher>();
        public List<Student> students = new List<Student>();
        public List<string> announcements = new List<string>();
        public List<string> pages = new List<string>();
        public List<string> discussions = new List<string>();
        public List<File> files = new List<File>();
        public List<string> collaborations = new List<string>();
    }
}
