using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1Assignment.DataLayer;
using _1Assignment;

namespace _1Assignment.Business
{
    class ProcessData
    {   /// <summary>
        /// Sorts the array of class object
        /// </summary>
        /// <param name="EmployeesObj"></param>
        /// <param name="M"></param>
        public void sortData(Employees[] EmployeesObj, int M)
        {
            //Temporary class object, used for swapping while sorting
            Employees temp = new _1Assignment.DataLayer.Employees();

            //Sorting the object array on the basis of FirstName
            //Using standard Bubble sort because it is a stable sorting algorithm
            for (int j = 0; j < M - 1; j++)
            {
                for (int i = j + 1; i < M; i++)
                {
                    if (EmployeesObj[j].FirstName.CompareTo(EmployeesObj[i].FirstName) > 0)
                    {
                        temp = EmployeesObj[j];
                        EmployeesObj[j] = EmployeesObj[i];
                        EmployeesObj[i] = temp;
                    }
                }
            }

            //Sorting the object array on the basis of LastName
            //Using standard Bubble sort because it is a stable sorting algorithm
            for (int j = 0; j < M - 1; j++)
            {
                for (int i = j + 1; i < M; i++)
                {
                    if (EmployeesObj[j].LastName.CompareTo(EmployeesObj[i].LastName) > 0)
                    {
                        temp = EmployeesObj[j];
                        EmployeesObj[j] = EmployeesObj[i];
                        EmployeesObj[i] = temp;
                    }
                }
            }

            //Sorting the object array on the basis of LastName
            //Using standard Bubble sort because it is a stable sorting algorithm
            for (int i = 0; i < M - 1; i++)
                for (int j = 0; j < M - i - 1; j++)
                    if (EmployeesObj[j].Rank < EmployeesObj[j + 1].Rank)
                    {

                        temp = EmployeesObj[j];
                        EmployeesObj[j] = EmployeesObj[j + 1];
                        EmployeesObj[j + 1] = temp;
                    }

            Console.Clear();
            //Writing the sorted objects on the console
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(EmployeesObj[i].FirstName + " " + EmployeesObj[i].LastName);
            }

        }


    }
}
