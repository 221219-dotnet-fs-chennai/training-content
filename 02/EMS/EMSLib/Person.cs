namespace EMSLib;
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public short Age { get; set; }

    public override string ToString()
    {
        return $"Id - {Id}\nName - {Name}\nAge - {Age}";
    }

    public IEnumerable<string,Person> GetPersons(){
        Dictionary<string,Person> persons = new Dictionary<string, Person>();
            persons.Add("RAC1B",new Person(){Id=1, Name="Emily", Age=30});
            persons.Add("YUB7B",new Person(){Id=2, Name="Carolyn", Age=23});
            persons.Add("KJH6C",new Person(){Id=3, Name="William", Age=26});
            persons.Add("BBB0C",new Person(){Id=4, Name="Blake", Age=40});
        return persons;        
    }
}
