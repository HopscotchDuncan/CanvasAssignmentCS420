using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    internal class User
    {
        public string contactInfo { get; set; }
        public string bio { get; set; }
        public string links { get; set; }

        public string SendMessage(string message)
        {
            return message;
        }
    }
}
