namespace interfaces
{
    public class Person
    {
        public string Name
        {
            set;
            get;
        }
        public long Salary
        {
            set;
            get;
        }
        public long PhoneNumber
        {
            get;
            set;
        }
        public int Id 
        {
            get;
            set;
        }

        public Person(int Id,string Name,long Salary,long PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.PhoneNumber = PhoneNumber;
        }
    }
}