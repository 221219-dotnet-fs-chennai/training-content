# .NET Architecture Components
* There are many frameworks included in .NET 6.0
    * A framework are just predefined classes and libraries to help us start an application
    * One framework we will be using in the future is ASP.NET (Used to create Web Apis)
## SDK vs Runtime
### SDK
* Software Development Kit
* Includes everything we need to build and run a .NET application
    * Such as Command-Line interface commands to create our projects as well as a bunch of other functionalities
* SDK includes Runtime as well why? Well when you develop an application you of course need to run it to be able to test if everything is working properly
### Runtime
* It includes all the resources we need to run existing .NET application
* A lot less storage required to download and install
* Mostly useful for end-users (people who will be using our application)

# Common Language Infrastructure (CLI)
* This is the  infrastructure of .NET on how it is able to write your application in numerous programming language beyond C# and for your application to be run on any operating system
## General structure of the .Net
* .Net - when you instal .Net sdk you get
    * **CLR**
        * CLI - Common Language Infrastructure (**.Net Languages**)
            * CLS
            * CTS
        * Garbage Collector - dispose unused objects of a program
        * JIT Compiler - to compile your IL to machine native code (binary code), its very fast
    * **Libraries**
    
## CLS
* Common Language Specification
* It has defined rules and restrictions that every langauge must follow for it to be able to run the .NET framework. Eg rules like Arrays index should start from 0, the langauges should be OOP.
* Essentially a standardization to make sure a language won't do anything that will make it incompatible with .NET framework
## [CTS](https://www.c-sharpcorner.com/blogs/what-are-cts-and-cls-in-net)
* Common Type System
* Provides a library of the basic value data types
* It is a standardization of data types to ensure every language will follow the same datatype
    * Ex: int in C# is the same 32-bit memory as the int in Visual Basic
* Helps create **Language Interoperability**
    * Fancy way of saying .NET has the capability to develop application using two or more programming languages
    * You can create apps using Visual Basic, C#, J# (Java-like language that can run in .NET), etc.
        * NEVER SAY JAVA ITSELF J# IS NOT JAVA
## VES
* Run-time system of CLI that provides all the tools it needs to be able to execute your application
### CLR
* Common Language Runtime implements VES so anything in VES, CLR also has it plus more
* Essentially, it is .NET's version of VES
* Run-time environment that provides services that make the development process easier
* Some servies it includes:
    * Automatic memory management (older languages you have to manually release unused resources)
    * JIT compilation (Just-inTime compilation that involves compliation during execution for optimization)
        * It just means any new compile code gets executed immediately, it doesn't have to wait until your entire code has been compiled to run your app
    * Exception handling support
    * Security against vulnerable code, like you cannot run a malicious .net code in your machine taken from internet.

# Application Architecture
* A way for us to group our code just like how we group our files by putting them in folders
## Separation of Concern
* The fancy way of saying it is a concept of organizing our code
* We want our code to follow a certain theme and all the code are grouped together to do a certain functionality
* We do this by leveraging classes and other grouping mechanisms to group code and logic together
* This is a first but **important** step to writing readable, extendable, and maintainable code
## Classes
* They are the building blocks of your code
* They are the blueprints to creating objects that you process in your program
## Namespace
* Logical grouping of classes that follow a certain theme of functionality
* To utilize the classes located in a different namespace, you must use the 'using' keyword
## Project
* They contain all the files that are compiled into an executable, library, website, etc.
* There are different types of projects that are responsible at creating one thing like how a console project is a great starting point of your application while class library projects are great at adding more customize functionalities you want in your application
* A way you know a folder is a project if you notice an important file usually dictated as **(folder name).csproj** they contain key information that will configures your project and also what your project will depend on
## Assembly
* They contain all the files that are actual executables
* These files will differ depending on what operating system you are using but as for windows, it will be .exe and .dll files
* If you open the auto-generated bin folders, you can file the assembly files located there
* **So main difference with projects are that projects are the .cs files and .csproj and other configurations while assembly is the actual files that gets run since that is what your operating system understands**
## Solution
* The final grouping mechanism in that it will group multiple projects as one application
* They are the final packaging of your application
## - [C# Program Structure](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/)

- [Namespace](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/members)
    - [Types](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/members) - Eg class, structs, enums, delegates, interface
        - [Members of Types](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/members)- Eg methods, properties, variables, constructors, events etc...
# OOP Definition
- Procedural Oriented languages - C, C++, BASIC, COBOL
  - Focus on what do and more focuss on How to do
  - The code scattered - variables, functions were loose and no structure.
  - Data leak due to garbage, that means data is less secure.
  - Resuability wasn't a great option in Procedural oriented language.

 - In OOP the program is organized into classes and accessed via object.
  - Programmer focus on what to do over how to do.
  - Programming is more organized hence better readablity of the code
  - Ex. OOP languages : C#, Java, C++, VB, TypeScript
  - OOP is well suited for programs that are large, complex, and actively updated and maintained.
  - Additional benifits are like code resuability, scalibility, efficiency
## Structure of OOP
- Structure comprises of building blocks of OOP
  - **[Class](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes)**: Blueprint of user defined type which is mapped to real time entities. Ex: Pen can be created as class with attributes/properties - type (ball, ink), color (blue, black, red, green) , behavior (writing).
  - **Object**: An object is a implementation of the class. It has been allocated memory. Whenever a class is instantiated the obj comes into the picture.
    - `Pen pen1 = new Pen();`, `Pen pen2 = pen1`.
    - Object has set of attributes/properties (static/dynamic)
    - Behaviour/Operations 
  - Another example 
```
  Car -> Object
    Properties/attributes
        Static - Make, model, chasiss number, number wheels
        Dynamic - speed, color, mileage, fuel
    Behaviour
	    Operation - transportation, play music, seatings, temperature control
```
  - **Pillars of OOP**
    - [OOP](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop) is structured on 4 pillars of OOP as:
      - **Encapsulation** - *Wrapping up of the data* (ex - methods encloses data field, class/Type encloses a method, namespace encapsulates the type) and *data hiding*, to provide protection from the outside world. We use Access modifiers to provide various levels of access.
      - **Abstraction** - Showing only essential features of the program instead on un-necessary details. In C#, abstraction can be achieved by **abstract** classes and **interfaces**. Through abstraction a template is provided which is generally implemented by Team of Software Developers.
      - **Inheritance** - Is a way to extend a type so that its properties and behaviours can be extended/branched further. Types of Inheritance:
        - Single - level: A->B
        - Multi - level: A->B->C
        - Hierarichal level A->B,C,D
        - Multiple inheritance - (A,B)->C
        - Hybrid inheritance - Combination of more than one above types of inheritance.
        - C# doesnot support multiple and hybrid inheritance.
        -  Programmar achive reusability through inheritance
      - **Polymorphism** 
        - Poly - many, morphs - forms. 
        - Ability to implement inherited properties or methods in different ways across multiple abstractions. 
        - It can be static/Compile time polymorphism or dynamic/runtime polymorphism. 
        - Ex Method Overloading is an example of compile time polymorphism, which is method with same name behaves differently based on signatures (parameters). Method Overriding is an example of runtime polymorphism, which is re-defining the method of parent class into child class. 
     - remember all 4 pillars as **A PIE**
# Access modifiers
- They are the keywords used to specify the declared accessibilty of a member or type.
- In C# we have 4 access modifiers:
    1. public - Access isn't restriced.
    2. protected - Access is limited to containing class or the types derived from the containing class
    3. internal - Access is limited to the current assembly/program.
    4. private - Access is limited to containing type.
- By default a **class is internal** and **member of types are private**.
- Additional access modifiers
    5. protected internal
    6. private protected
    7. file - newly launched in C# 11

# Datatypes in C#
- All the datatypes in C# are directly or indirectly inherited from **System.Object** class. Which is why we get object methods like Equals(), ToString(), GetHashCode().
- Predefined - built in datatypes in C#
    - Eg: int, short, byte, long, float, double, decimal, char, boolean, string
- User defined
    - class, struct, arrays, enums etc....
- **Value Types**
    - A value type contains an instance/value od the type (struct)
    - Stored on stack memory location
    - with value types each variable has its own copy of the data and its not possible for the operations on one variable affect to the other 
    - Predefined (int, byte, short, long, double, decimal, float, char,bool) enums, structs
- **Reference Types**
    - A reference typw contains a reference to an instance/value of the type (class)
    - The reference is stored in the stack and the instance/value its pointing to is stored on the heap
    - With reference types, 2 variables can reference the same object; there, operations one one variable can affecr the object referenced by the other variable.
    - predefined (string, collections), class, object, arrays, interface, delegates
# [Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
- Smart fields in C# which are used to expose a private variable outside the class
- You can use conditionals with your properties, to perform some computation on the data before it's stored or returned.
- properties can be created in 3 ways:
  - read-only - with only get accessor.
  - write-only - with only set accessor.
  - read-write property - with both get and set accessor. 
# [Constructors](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
- A constructor is a special method whose name is same as the name of its type, it does not have any return type
- Whenever a class or struct is created, its constructor is called. 
    - We use constructor to set some defualt values, limitation instantiation
- Types of Constructors:
    - Parameterless constructor - a constructor without any parameter.
    - Parameterized constructor - constructor with parameters.
        - this keyword should be used to resolve ambiguity in names
    - Private constructor
    - Static constructor

# [Method](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
- A block of code which has a logic in the form of a series of statements.
- A method consists of :
    - Signature - consists of access/optional modifiers, name of the method, return type and parameters.
        - parameters which are enclosed within () and separated by commas
    - Body - anything within { } is known as method body.
## Method Overloading 
  - Also known as static or compile time polymorphism
  - Methods with same name in the containing class but with different **Signature**.
  - Signatures can be different in 3 ways:
    - Number of parameters.
    - Datatype of parameters.
    - Sequence of parameters.
 
## Method Overriding
- It is also known as dynamic/runtime polymorphism.
- Redefining the method of base class in child class.
- It is necessary to make a method overridable by using *abstract* or *virtual* keyword in base class
- In child class use the keyword *override* to override these methods.
## [Abstract class]
- An abstract class cannot be instantiated
- An abstract class may contaim abstract methods and successor
- A non-abstrat class dervied from an abstract class must include the actual implementations of all inherited abstarct methods

## Abstract methods
- An abstract method is implicitly virtual method.
- Abstract method declarations are only permitted in abstract classes
- An abstract method has no implenmentation (body); this is why the method ends with a semicoln instead on curly brackets.
- An abstract method is implemented in the child class by using **override** keyword

## [Interface](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
- An interface is a contract which is implemented by a class/struct; and the implementing class/struct must define the implementation of the members of the interface.
- In earlier version of C# we use have only four types of members of interfaces as methods, properties, indexers and events. But in mordern version of C# 9 or above you can have a static implementatio of common functionalities.
## [Abstract class](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members) vs [Interface](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
- An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface. 
- Abstract class allows you to implement a spectrum of abstraction like full abstraction, partial abstraction etc....
- Abstract class allows you to have all types of members. Like you can have data variables and assign values to it and can create methods with definition. But interface can only have methods, properties, events, indexers, which means interfaces cannot have variables or methods with implementation (except C# 8.0 or later version allow you to have static methods with implementation).
- Abstract class and interface cannot be instantiated but meant to be implemented/inherited.
- Abstract/Concrete class can implement one or more interfaces by which multiple inheritance is achieved. But class can only inherit from 1 class.
- A class can inherit 1 class and one or more interfaces.    
- Abstract class is used to implement core identity of a class where as interface is used to implement peripheral/surface level abililities of a class.
- If there is a need of implementing xommon behavior the abstract class should be used over interfaces.
```
class A{}

abstract class C: IX, IY
{}

class B: A, IX, IY // multiple inheritance
{

}

interface IX{}

interface IY{}
```

# Non-access modifiers
## Abstract
* Enables you to create incomplete implementation of whatever you applied it to and it must be implemented in a derived class
* Implicitly used by interfaces
* Explicitly used by abstract classes

## Static
* Static classes cannot be instantiated or inherited, its members must also be static
* Static class members belongs to the class itself rather than to a specific object
    * Allows you to use those class members without instantiating an object from that class
    * If a static field changes, every object will reflect that change (think of it as a federal law that every state must follow)
## const
- A const keyword is used woth fields which donot changes throughout the program
- Eg `float const Pi = 22/7;`
## Readonly
* Readonly fields cannot change its value once it is set
* **They can be initialized at a later time** like in a constructor
* "Read only" meaning you can only read the value and not write it

## Override
* Override methods must do method overriding or the compiler will notify you that it isn't
* Essential for method overriding for polymorphism

## Virtual
* Allows the method for the base class to be overriden
* Essential for method overriding for polymorphism
* Virtual methods doesn't allow methods to be private (I'm sure you can figure out why that is the case *cough* private methods cannot be inherited *cough*)

# Quick More Datatypes
## Nullable
* Makes datatypes optional and it is denoted by using '?'
* Hence the name nullable, it makes whatever datatype have an option to also hold a null value
* Just useful for the compiler to help you out and telling you that something might give a null and you might have to take that into account
```
//This means x variable can hold either true, false, or null
bool? x
//This means y can hold numbers or a null
int? y
//This means i can hold characters or a null I'm sure you get what it means
string? i
```
## Struct
* Unlike classes, struct gets stored in the stack memory so they are more optimized and efficient
* But since they are stored in the stack memory, they are only used for encapsulating simple data and have little to no behavior (so generally have simple datatype for properties and very simple functions of methods)
* Limitations:
    * A structure cannot be inherited from other structs or classes. However structs can implement interfaces.
    * Prior to C# 11, a constructor of a structure type must initialize all the instance fields of the type.
    * Prior to C# 10, you cannot declare a parameterless constructor
    * Prior to C# 10, you can't initialize an instance field or property at its declaration.

## Conversion
### Implict Conversions
* No syntax is required to change type because  conversion succeed with not data loss. Ex long can contain int values because long is 8 byte integer and int is of 4 byte integer type.
* * ```
long height;
int h = 178;
height = h;// implicit conversion
```
### Explicit Conversion
* Explicit conversion require a cast expression. Casting is required when informations might be lost in the conversiom or when the conversion might not succeed. Ex - numeric conversion to a type that has less precision or smaller range or conversion of base type to child type.
* ```
short height;
int h = 178;
height = (short)h;// explicit cast
```
### [User-defined conversion](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators)
* Gives you the capabilities to convert other datatypes into a class either implicitly or explicitly
* You must use the **operator** keyword followed by either **implicit** or **explicit** keyword

### [Boxing and Unboxing](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
* Boxing
    * It is when a value type gets casted into an object
    * Useful if you want a value type to have reference type like functionalities
    * It is implicit conversion
* Unboxing
    * When you extract the value from an object and convert it into a value type instead
    * It is explicit conversion
```
Console.WriteLine("==== Boxing and Unboxing ====");
            
            //Value type
            //You get the value directly
            int num = 123;

            //Boxing example
            //When a value type gets casted into an object
            //What happens is that the value is wrapped to give it a reference type behavior
            //No other syntax is needed
            //It is implicit conversion
            object obj = num;
            Console.WriteLine(obj);

            //Unboxing example
            //When you extract the value type from the object and just get the value directly instead
            //A syntax is needed (dataType)Object
            //It is explicit converion
            int num2 = (int)obj;
            Console.WriteLine(num2);
```
- Boxing and unboxing are computationally expensive and in return they are poor in [performance](https://learn.microsoft.com/en-us/dotnet/framework/performance/performance-tips)
    - When a value type is boxed it has allocate a new object and constructed. Memory loaction also changes from stack to heap.
    - For unboxing to a lesser degree, you have to move an object to stack memory
    - It is best to avoid boxing using value types in situation where they are boxed a high number of times. This can take upto 20 times longer than a simple reference assignment.
    - ![https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/media/boxing-and-unboxing/boxing-operation-i-o-variables.gif](boxing)
    - Similar way when unboxing happens it can take upto 4 times as long as an assignment.
    - ![https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/media/boxing-and-unboxing/unboxing-conversion-operation.gif](unboxing)
### Var keyword
- Implicit typed variables declared using var

### Upcasting 
* Upcasting - Process of assignment of derived class object to a base class reference in C# inheritance 
    * It is implicit 
* Downcasting - Process of assigment of base class object to child class reference in C# inheritance
    * it is explicit so might need a cast


# Collections in C#
## [Arrays](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
- collection of items of similar data type and these items are located in contigious memory locations
- Types of arrays in C#: 
1. Single dimension array
2. Multidimension array
    a. 2 D
    b. 3-D
3. Jagged Arrays
- Length will tell you the number of items in the array
- Rank - will tell the dimension of the array
- All indexes of arrays are 0 indexed, an array with n elements will have 0 to n-1 indexes
- Looping thropugh arrays become easy because of foreach loop as you know Arrays implement IEnumerable
- Arrays have drawbacks:
    - They are fixed in size and adding extra element will raise an IndexOutOfRangeException
    - Arrays elements will always have any value even if its default which means arrays cannot grow or shrink
## References
- [Basics of C# Programming](https://learn.microsoft.com/en-gb/users/dotnet/collections/yz26f8y64n7k07?WT.mc_id=dotnet-35129-website&source=docs)
- [Practise C#](https://dotnetcademy.net/Learn/2047/Pages/1)
- [OOPS explained by medium.com](https://medium.com/@cancerian0684/what-are-four-basic-principles-of-object-oriented-programming-645af8b43727)