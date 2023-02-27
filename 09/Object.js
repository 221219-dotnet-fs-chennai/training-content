const person1 = { 
    name: 'John', 
    age: 20, 
};

// accessing property
console.log(person1["name"]); 

console.log(person1.name);

// nested object
const student = { 
    name: 'John', 
    age: 20,
    marks: {
        science: 70,
        math: 75
    }
}

// accessing property of student object
console.log(student.marks);

// accessing property of marks object
console.log(student.marks.science); 

//In JavaScript, an object can also contain a function. For example,

const person2 = {
    name: 'Sam',
    age: 30,
    // using function as a value
    greet: function() { console.log('hello') }
}

person2.greet(); // hello


// accessing method and property
const person3 = {
    name: 'John',
    greet: function() { console.log('hello'); }
};

// accessing property
person3.name; 

// accessing method
person3.greet(); 

//You can also add a method in an object. For example,
/*
// creating an object
let student = { };

// adding a property
student.name = 'John';

// adding a method
student.greet = function() {
    console.log('hello');
}

// accessing a method
student.greet(); 

//JavaScript this Keyword
// To access a property of an object from within a method of the same object, you need to use the this keyword. Let's consider an example.
*/
const person = {
    name: 'John',
    age: 30,

    // accessing name property by using this.name
    greet: function() { console.log('The name is' + ' ' + this.name); }
};

person.greet();
