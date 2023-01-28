namespace Delegates
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public static IEnumerable<Employee> DummyEmployees()
        {
            return new List<Employee>(){
                new Employee(){Id=1,Name="Kaveri",Age=23,Salary=250000},
                new Employee(){Id=2,Name="Sabitha",Age=32,Salary=40000},
                new Employee(){Id=3,Name="Fred",Age=40,Salary=870000},
                new Employee(){Id=4,Name="Carol",Age=42,Salary=10000},
                new Employee() { Id = 5, Name = "Marielle", Age = 35, Salary = 4500000 }
                };
        }
        public override string ToString()
        {
            return $"Id - {Id}\nName - {Name}\nAge - {Age}\nSalary - ${Salary}";
        }
    }
    internal class LinqBasics
    {
        internal IEnumerable<int> Filter(int[] marks)
        {
            // QUERY SYNTAX in LINQ
            // deferred execution - this means the query variable only holds the query expression and it will run when foreach loop is called
            //var query = from m in marks
            //            where m >= 65
            //            orderby m descending //by default it is asc order
            //            select m;

            // immediate execution - which means that we are enforcing compiler to get the values in the query parameter. Otherways are like using Avg, max, count etc....
            //var query = (from m in marks
            //            where m >=65
            //            orderby m descending
            //            select m).ToList();

            // METHOD SYNTAX
            var query = marks.Where(a => a >= 65).OrderBy(a=>a).ToList();

            /*List<int> filterMarks = new List<int>();
            foreach (var m in marks)
            {
                if (m >= 65)
                {
                    filterMarks.Add(m);
                }
            }*/
            return query;
        }
    }
}
