using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseProject.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
