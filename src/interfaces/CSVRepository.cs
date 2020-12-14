using System;
using System.Collections.Generic;
using System.Linq;

namespace interfaces
{
    class CSVRepository : IOperations
    {
        List<Person> CsvRepositoryListPersons = new List<Person>();
        public void CreatePerson(Person person)
        {
            CsvRepositoryListPersons.Add(person);
        }


        public bool DeletePerson(int id)
        {
            if (CsvRepositoryListPersons.ToList().Count > 0)
                foreach (var person in CsvRepositoryListPersons)
                {
                    if (person.Id == id)
                    {
                        CsvRepositoryListPersons.Remove(person);
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

        public IEnumerable<Person> GetPeople()
        {
            var Persons = from person in CsvRepositoryListPersons
                          select person;
            return Persons;
        }

        public void Update(int id)
        {
            var PersonsInCsvRepository = GetPeople();
            bool updateStatus = false;
            foreach (var EachPerson in PersonsInCsvRepository)
            {
                if (EachPerson.Id == id)
                {
                    try
                    {
                        Console.Write("Enter your PhoneNumber  :   ");
                        long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                        EachPerson.PhoneNumber = PhoneNumber;
                        Console.WriteLine("\nUpdated Succesfully !");
                        updateStatus = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please, Enter Data in correct Format.!");
                    }

                }
            }
            if (!updateStatus)
            {
                Console.WriteLine("No ID found, please Enter valid ID ");
            }
        }
        public void show()
        {
            var PersonsInCsvRepository = GetPeople();
            if (CsvRepositoryListPersons.ToList().Count > 0)
            {
                Console.WriteLine("\n\n{0,9}{1,12}{2,10}{3,15}","Person Id","Name","Salary", "PhoneNumber");
                foreach (var EachPerson in PersonsInCsvRepository)
                {
                    Console.WriteLine("{0,8}{1,15}{2,10}{3,15}",EachPerson.Id,EachPerson.Name,EachPerson.Salary,EachPerson.PhoneNumber);               
                }
            }
            else
                Console.WriteLine("No Data Found ");
        }
    }
}