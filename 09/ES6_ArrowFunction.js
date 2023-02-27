
/*
var name="Manikandan";
{
    var name="Mahesh";

    console.log(name);
}
console.log(name);
*/







/*

// With no argument

let greet = () => console.log('Hello');
greet(); // Hello




// With one argument

let greet1 = name11 => console.log('Hello' +name11);
greet1("Prasanna"); 


// Arrow function as an expression

let age = 5;

let welcome = (age < 18) ?
  () => console.log('Baby') :
  () => console.log('Adult');

welcome(); 

//Multiline Arrow Functions
//If a function body has multiple statements, you need to put them inside curly brackets {}. For example,

let sum = (a, b) => {
    let result = a + b;
    return result;
}

let result1 = sum(5,7);
console.log(result1);
*/
//this with Arrow Function
//Inside a regular function, this keyword refers to the function where it is called.

//However, this is not associated with arrow functions. Arrow function does not have its own this. So whenever you call this, it refers to its parent scope. For example,

//Inside a regular function
/*

function Person() {
    this.name = 'Jack',
    this.age = 25,
    this.sayName = function () {

        // this is accessible
        console.log(this.age);

        function innerFunc() {

            // this refers to the global object
            console.log(this.age);
            console.log(this);
        }

        innerFunc();

    }
}

let x = new Person();
x.sayName();


//Inside an arrow function


function Person() {
    this.name = 'Jack',
    this.age = 25,
    this.sayName = function () {

        console.log(this.age);
        let innerFunc = () => {
            console.log(this.age);
        }

        innerFunc();
    }
}

const x1 = new Person();
x1.sayName();

// Later 

//Arrow Function with Promises and Callbacks
//Arrow functions provide better syntax to write promises and callbacks. For example,

// ES5
asyncFunction().then(function() {
    return asyncFunction1();
}).then(function() {
    return asyncFunction2();
}).then(function() {
    finish;
});
//can be written as

// ES6
asyncFunction()
.then(() => asyncFunction1())
.then(() => asyncFunction2())
.then(() => finish);
*/

function sum(x, y=10, z=30)
{
    return x+y+z;
}

console.log(sum(10,20));

function sample(x=1)
{
    console.log(x);
}

sample(undefined);








