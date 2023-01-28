using Delegates;
/*
//predefined delegates
//Action - void delegate with no parameters
// Func<> - any return type delegate with no parameters
//Predicate - boolean return type with any one parameter
//initializing the delegates
Action del = new Action(DummyClass.Display);
MyDelegate myDelegate;
//MyDelegate myDelegate = new MyDelegate(DummyClass.Add);// initially it will be single cast delegate
//Anonymous method for addition
//MyDelegate myDelegate = delegate(float x, float y) { Console.WriteLine(x + y);  };
// shorthand of anonymous method - Lambda Expression. => denotes lambda operator
myDelegate = (float x, float y) => Console.WriteLine(x + y);

// but you can also have multiple methods called by delegate when you invoke it
//myDelegate += DummyClass.Substract;
//Anonymous method for substraction
//myDelegate += delegate(float x, float y) { Console.WriteLine(x - y); };
myDelegate += (float x, float y) => Console.WriteLine(x - y);

//myDelegate += DummyClass.Multiply;
//Anonymous method for multiplication
//myDelegate += delegate (float x, float y) { Console.WriteLine(x * y); };
myDelegate += (float x, float y) => Console.WriteLine(x * y);

//myDelegate += DummyClass.Divide;
//anonymous method for division
//myDelegate += delegate (float x, float y) { Console.WriteLine(x / y); };
myDelegate += (float x, float y) => Console.WriteLine(x / y);

//invoking of the delegate
//myDelegate(45.89f, 23.55f);

//DummyClass.CallBack(80, 40, myDelegate);

//del();


//------------------
char a = '1', b = '2';
Console.WriteLine($"a = {a}, b = {b}");
Algorithm<char>.Swap(ref a, ref b);
Console.WriteLine($"a = {a}, b = {b}");
*/

/*LinqBasics basics = new LinqBasics();

int[] marks = { 56, 78, 54, 76, 87, 95 };
var filteredValues =basics.Filter(marks);
foreach (var item in filteredValues)
{
    Console.WriteLine(item);
}*/
/*Console.WriteLine($"Count of Employees "+Employee.DummyEmployees().Count());
//var empAgeGreaterThan25=Employee.DummyEmployees().Where(e => e.Age > 25);
var empSalaryGreaterThan3Lacs = //from emp in Employee.DummyEmployees()
                                //where emp.Salary>300000
                                //orderby emp.Name
                               // select emp;
    Employee.DummyEmployees().Where(e => e.Salary > 300000).OrderBy(e=>e.Name);
foreach (var emp in empSalaryGreaterThan3Lacs)
{
    Console.WriteLine("================");
    Console.WriteLine(emp.ToString());
}
Console.WriteLine(Employee.DummyEmployees().Max(e=>e.Age));
*/
AsynchProgramming.Method1();
AsynchProgramming.LongMethod();
Console.WriteLine("Program Ends");
