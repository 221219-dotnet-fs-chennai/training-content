//you can create an object in JavaScript using an object constructor function. For example,
/*
// constructor function
function Person () {
    this.name = 'John',
    this.age = 23
}

// creating objects
const person1 = new Person();
const person2 = new Person();

console.log(person1);
*/
//JavaScript Prototype
//In JavaScript, every function and object has a property named prototype by default. For example,
/*
function Person () {
    this.name = 'John',
    this.age = 23
}

const person = new Person();

// checking the prototype value
console.log(Person.prototype); // { ... }

*/
//Prototype Inheritance
// In JavaScript, a prototype can be used to add properties and methods to a constructor function. And objects inherit properties and methods from a prototype. For example,

// constructor function
/*
function Person () {
    this.name = 'John',
    this.age = 23
}

// creating objects
const person11 = new Person();
const person21 = new Person();

// adding property to constructor function
Person.prototype.gender = 'male';
Person.prototype.greet=function(){
    console.log('hi '+this.name);
}

// prototype value of Person
console.log(Person);
console.log(Person.prototype);

// inheriting the property from prototype
console.log(person11.gender);
console.log(person21.gender);*/
//Run Code
//Output

//{ gender: "male" }
//male
//male

//Changing Prototype
//If a prototype value is changed, then all the new objects will have the changed property value. All the previously created objects will have the previous value. For example,
/*
// constructor function
function Person() {
    this.name = 'John'
}

// add a property
Person.prototype.age = 20;

// creating an object
const person1 = new Person();

console.log(person1.age); // 20

// changing the property value of prototype
Person.prototype = { age: 50 }

// creating new object
const person3 = new Person();

console.log(person3.age); // 50
console.log(person1.age); // 20
*/
//JavaScript Prototype Chaining
//If an object tries to access the same property that is in the constructor function and the prototype object, the object takes the property from the constructor function. For example,

function Person() {
    this.name = 'John'
}

// adding property 
Person.prototype.name = 'Peter';
Person.prototype.age = 23

const person1 = new Person();

console.log(person1.name); 
console.log(person1.age); 



