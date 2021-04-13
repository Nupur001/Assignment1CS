using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1Assignment.Business;
using _1Assignment.DataLayer;
using _1Assignment.Control;

/*----------------------------Algorithm--------------------------
 * 1. Take input
 *      1.1. Store the position and rank in a dictionary i. e. PositionRank
 *      1.2. Store the First Name, LastName and rank in a array of class objects i. e. Employees
 * 2. Sorting
 *      2.1. Sort array  of objects on basis of First Name-- Buble sort because it is a stable sorting algorithm
 *      2.2. Sort array  of objects on basis of Last Name-- Buble sort because it is a stable sorting algorithm
 *      2.3. Sort array of objects on basis of Rank-- Buble sort because it is a stable sorting algorithm
 * 3. Output
 */

namespace _1Assignment
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ReadData DataObj = ReadData.GetInstance();
            DataObj.GetInput();
            Console.ReadKey();
        }
    }
}
