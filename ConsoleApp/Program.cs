using ClassLib;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Institute Howest = new Institute()
            {
                Groups = new List<Group>() {
                    new Group() {
                        Name = "2TI",
                        Students = new List<Student>()
                        {
                            new Student(lastName:"Hoet", firstName:"Jan", Id:323, trajectory:"SE"),
                            new Student(lastName:"Vandenberghe", firstName:"Jordy", Id:966, trajectory:"CSP"),
                            new Student() { LastName="Steelandt", FirstName="Bart", StudentID=1003, TrajectoryName="IBC"  }
                        },
                        Teacher = new Teacher(lastName:"Gobbelijn", firstName:"Professor", id:14323456)
                    },
                    new Group() {
                        Name = "3TI",
                        Students = new List<Student>()
                        {
                            new Student(lastName:"Gillez", firstName:"Amedee", Id:545, trajectory:"SE"),
                        },
                        Teacher= new Teacher(lastName:"Roels", firstName:"Kristien", id:27645387)
                    }
                }
            };

            Console.WriteLine(Howest.Groups[0].ToString());
            Console.WriteLine(Howest);
        }
    }
}
