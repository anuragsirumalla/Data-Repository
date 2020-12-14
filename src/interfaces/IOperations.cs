using System.Collections.Generic;

namespace interfaces
{
    public interface IOperations
    {
        void CreatePerson(Person p);
        bool DeletePerson(int id);
        void Update(int id);
        IEnumerable<Person> GetPeople();
        void show();
    }
}