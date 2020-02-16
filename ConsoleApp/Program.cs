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
                        Name = "2TIa",
                        Students = new List<Student>()
                        {
                            new Student(lastName:"Hoet", firstName:"Jan", Id:323, trajectory:"SE"),
                            new Student(lastName:"Vandenberghe", firstName:"Jordy", Id:966, trajectory:"CCCP")
                        },
                        Teacher = new Teacher(lastName:"Gobbelijn", firstName:"Professor", Id:14323456)
                    },
                    new Group() {
                        Name = "3TI",
                        Students = new List<Student>()
                        {
                            new Student(lastName:"Gillez", firstName:"Amedee", Id:545, trajectory:"SE"),
                        },
                        Teacher= new Teacher(lastName:"Roels", firstName:"Kristien", Id:27645387)
                    }
                }
            };

            Console.WriteLine(Howest.Groups[0].ToString());
        }
    }
}
