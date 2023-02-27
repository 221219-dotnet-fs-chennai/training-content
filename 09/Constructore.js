// constructor function
function Person () {
    this.name = 'John',
    this.age = 23,

     this.greet = function () {
        console.log('hello');
    }
}

// create objects
const person1 = new Person();
const person2 = new Person();

// access properties
console.log(person1.name);  
console.log(person2.name);  



// constructor function
function Person (person_name, person_age, person_gender) {

   // assigning  parameter values to the calling object
    this.name = person_name,
    this.age = person_age,
    this.gender = person_gender,

    this.greet = function () {
        return ('Hi' + ' ' + this.name);
    }
}


// creating objects
const person11 = new Person('John', 23, 'male');
const person21= new Person('Sam', 25, 'female');

// accessing properties
console.log(person11.name); // "John"
console.log(person21.name); // "Sam"

console.log(person21.greet());

// Adding properties and methods in an object
/*

// constructor function
function Person2 () {
    this.name = 'John',
    this.age = 23
}

// creating objects
let person12 = new Person2();
let person22 = new Person2();

// adding property to person1 object
person12.gender = 'male';

// adding method to person1 object
person12.greet = function () {
    console.log('hello');
}

person12.greet();   // hello
person22.greet();
// Error code
// person2 doesn't have greet() method
person2.greet();
*/
// JavaScript Object Prototype
// You can also add properties and methods to a constructor function using a prototype. For example,

// constructor function
/*
function Person3 () {
    this.name = 'John',
    this.age = 23
}

// creating objects
let person13 = new Person3();
let person23 = new Person3();

// adding new property to constructor function
Person3.prototype.gender = 'Male';

console.log(person13.gender); // Male
console.log(person23.gender); // Male


// get and set keyword

const associate={
    firstName:'Cibi',
    lastName:null,
    
    set addlastName(newName)
    {
        this.lastName=newName;
    },
    get getName()
    {
        return this.firstName+this.lastName;
    }
}
associate.addlastName="Sharan";
console.log(associate.firstName);
console.log(associate.getName);

*/
const associate={
    firstName:'Cibi',
    lastName:null,
}
Object.defineProperty(associate,"getName",{
    get: function()
    {
        return this.firstName+this.lastName;
    }
});
Object.defineProperty(associate,"setlastName",{
    set:function(value)
    {
        this.lastName=value;
    }
});
associate.setlastName="Sharan";
console.log(associate.firstName);
console.log(associate.getName);








