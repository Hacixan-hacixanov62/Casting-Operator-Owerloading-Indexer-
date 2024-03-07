

namespace Casting___OperatorOverloading___Indexer
{
    internal class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public object Name { get; internal set; }

        public static bool operator > (Employee emp1,Employee emp2 )
        {
            return  emp1.Id > emp2.Id ;
        }

        public static bool operator < (Employee emp1, Employee emp2)
        {
            return emp1.Id < emp2.Id; 
        }

    }
}
