using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1Assignment.Business;

namespace _1Assignment.DataLayer
{   
    
    /// <summary>
    /// to store FirstName, LastName and Rank
    /// </summary>
    class Employees
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Rank { get; set; }

        public Employees(String FirstName, String LastName, int Rank)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Rank = Rank;
        }
        public Employees() { }

 
    }
}
