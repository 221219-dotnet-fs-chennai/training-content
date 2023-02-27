

class Person{
    constructor(name)
    {
        this.name=name;
    }
    hello()
    {
        return `Hi ${this.name}`;
    }
}


class Associate extends Person{
    constructor(name)
    {
        super(name);
    }
    hello()
    {
        return "Good Bye";
    }
}

let s1=new Associate('Madhu');
console.log(s1.hello());