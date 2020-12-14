using System;
using System.Reflection;
namespace interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            IOperations repositoryName;
            Console.WriteLine("\n\n\n1.SQL Repository 2. CSV Repository ");
            try
            {
                System.Console.Write("Enter your choice : ");
                int option = Convert.ToInt16(Console.ReadLine());
                String finalStatus = "yes";
                if (option == 1)
                {
                    repositoryName = DynamicRepositoy.GetRepositoryName("interfaces.SQLRepository");
                    Console.WriteLine("\n                                     SQL REPOSITORY     ");
                    while (finalStatus.Equals("yes"))
                        PersonDetails.PersonOperations(repositoryName);
                }
                if (option == 2)
                {
                    repositoryName = DynamicRepositoy.GetRepositoryName("interfaces.CSVRepository");
                    Console.WriteLine("\n                                    CSV REPOSITORY     ");
                    while (finalStatus.Equals("yes"))
                        PersonDetails.PersonOperations(repositoryName);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter valid choice .! ");
            }
        }
    }
}
