using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1Assignment.DataLayer;
namespace _1Assignment.Control
{
    class ReadData
    {
        ReadData()
        {

        }
        static ReadData obj = null;
        public static ReadData GetInstance()
        {
            if (obj == null)
                obj = new ReadData();
            return obj;
        }
        /// <summary>
        /// Takes all the inputs and stores them and then calls sortData
        /// </summary>
        public void GetInput()
        {

            try
            {
                int N = Convert.ToInt32(Console.ReadLine());
                //Stores the position and its rating
                Dictionary<string, int> PositionRating = new Dictionary<string, int>();
                for (int i = 0; i < N; i++)
                {
                    string st = Console.ReadLine(); //getting input value as string

                    List<string> parts = st.Split('-').Select(p => p.Trim()).ToList(); //spliting and storing the string to a list

                    PositionRating.Add(parts[0], Convert.ToInt32(parts[1])); // adding the list elements to dictionary
                }


                int M = Convert.ToInt32(Console.ReadLine());

                //Storing the Name and position of the employees in a Employees class
                //creating array of class objects
                Employees[] EmployeesObj = new Employees[M];
                for (int i = 0; i < M; i++)
                {
                    string st = Console.ReadLine(); // Storing input in the string
                    List<string> NamePos = st.Split('-').Select(p => p.Trim()).ToList();//seperating strings on basis of -
                    List<string> FullName = NamePos[0].Split(' ').Select(p => p.Trim()).ToList();// Seperating Name to get first and last name
                    EmployeesObj[i] = new Employees(FullName[0], FullName[1], PositionRating[NamePos[1]]);
                    //Now storing the data in the i-th class object
                    //directly saving rank using the dictionary
                }

                //Now calling sortData() of ProcessData.cs to sort the class object array
                _1Assignment.Business.ProcessData ProcessObj = new _1Assignment.Business.ProcessData();
                ProcessObj.sortData(EmployeesObj, M);
            }
            catch
            {
                Console.WriteLine("Please give valid input");
            }

        }

    }
}