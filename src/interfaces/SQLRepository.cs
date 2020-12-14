using System;
using System.Collections.Generic;
using System.Linq;

namespace interfaces
{
    class SQLRepository : IOperations
    {
        List<Person> SqlRepositoryListPersons = new List<Person>();

        public void CreatePerson(Person person)
        {
            SqlRepositoryListPersons.Add(person);
            Console.WriteLine("Added Successfully !\n");
        }

        public bool DeletePerson(int id)
        {
            if (SqlRepositoryListPersons.ToList().Count > 0)
                foreach (var person in SqlRepositoryListPersons)
                {
                    if (person.Id == id)
                    {
                        SqlRepositoryListPersons.Remove(person);
                        Console.WriteLine("\nDeleted Succesfully ! ");
                        return true;
                    }
                }
            else
            {
                Console.WriteLine("\nData Not Found..! please, try again ");
            }
            return false;
        }
        public void Update(int id)
        {
            var PersonsInCsvRepository = GetPeople();
            bool updateStatus = false;
            foreach (var EachPerson in PersonsInCsvRepository)
            {
                try
                {
                    if (EachPerson.Id == id)
                    {
                        Console.Write("Enter your PhoneNumber  :   ");
                        long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                        EachPerson.PhoneNumber = PhoneNumber;
                        Console.WriteLine("\nUpdated Succesfully !");
                        updateStatus = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, Enter Data in correct Format.!");
                }
            }
            if (!updateStatus)
            {
                Console.WriteLine("No ID found, please Enter valid ID ");
            }
        }
        public IEnumerable<Person> GetPeople()
        {
            var Persons = from person in SqlRepositoryListPersons
                          select person;
            return Persons;
        }
        public void show()
        {
            var PersonsInSqlRepository = GetPeople();
            if (SqlRepositoryListPersons.ToList().Count > 0)
            {
                Console.WriteLine("\n\n{0,9}{1,12}{2,10}{3,15}","Person Id","Name","Salary", "PhoneNumber");
                foreach (var EachPerson in PersonsInSqlRepository)
                {
                    Console.WriteLine("{0,9}{1,12}{2,10}{3,15}",EachPerson.Id,EachPerson.Name,EachPerson.Salary,EachPerson.PhoneNumber);               
                }
            }
            else
                Console.WriteLine("No Data Found ");
        }

    }
}