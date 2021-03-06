﻿using System;
using System.Collections.Generic;

namespace MasteringDebugging
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                List<Person> people = populatePeople();

                foreach (var person in people)
                {
                    Console.WriteLine(person.FullName);
                }
                Console.WriteLine(people[6].FirstName);
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }
        static List<Person> populatePeople ()
        {
            return new List<Person> {
                new Person {FirstName = "Joseph", MiddleInitial="J", LastName="Guadagno", Email="jguadagno@hotmail.com", DateOfBirth= DateTime.Parse("05/31/1971 2:17 am"), Children = new List<Person> {new Person {FirstName = "Will"}}},
                new Person {FirstName = "Deidre", MiddleInitial="A", LastName="Guadagno", Email="deeguadagno@hotmail.com", DateOfBirth= DateTime.Parse("05/03/1970")},
                new Person {FirstName = "Joseph", MiddleInitial="J", LastName="Guadagno", Email="jjguadagno@gmail.com", DateOfBirth= DateTime.Parse("05/31/1997")},
                new Person {FirstName = "Emily", MiddleInitial="E", LastName="Guadagno", Email="eeguadagno@msn.com", DateOfBirth= DateTime.Parse("05/31/1999")}
            };
        }
    }
}
