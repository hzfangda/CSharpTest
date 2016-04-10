using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Entities
{
    public class Student : EntityBase
    {
        public string Name { get; set; }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
