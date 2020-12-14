using System;

namespace interfaces
{
    public class PersonDetails
    {
        static Person GetPersonDetails()
        {
            try
            {
                Console.Write("Enter name : ");
                String Name = Console.ReadLine();
                Console.Write("Enter Id : ");
                int id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter salary : ");
                long salary = Convert.ToInt64(Console.ReadLine());
                Console.Write("Enter PhoneNumber : ");
                long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                return new Person(id, Name, salary, PhoneNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, Enter Data in correct Format !");
                return null;
            }
        }

        public static void PersonOperations(IOperations repositoryName)
        {
            Console.WriteLine("\n1.Add people  2.Delete People   3.Update Details   4. Display   5.Exit");
            Console.Write("Enter your choice  :  ");
            try
            {
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Person newPerson = GetPersonDetails();
                        repositoryName.CreatePerson(newPerson);
                        break;
                    case 2:
                        int idToDelete = GetIdToDelete();
                        repositoryName.DeletePerson(idToDelete);
                        break;
                    case 3:
                        int idToUpdate = GetIdToUpdate();
                        repositoryName.Update(idToUpdate);
                        break;
                    case 4:
                        repositoryName.show();
                        break;
                    case 5:
                        Console.WriteLine("Application Stopped !");
                        System.Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Enter Valid option"); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, Enter a valid choice !");
            }
        }
        static int GetIdToDelete()
        {
            Console.Write("Enter id to Delete Person : ");
            int idToDelete = Convert.ToInt16(Console.ReadLine());
            return idToDelete;
        }
        static int GetIdToUpdate()
        {
            Console.Write("Enter id to Update Person : ");
            int idToDelete = Convert.ToInt16(Console.ReadLine());
            return idToDelete;
        }
    }
}