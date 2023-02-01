using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    internal class Student : User
    {
        public Item MakeItem()
        {
            return new Item();
        }
    }
}
