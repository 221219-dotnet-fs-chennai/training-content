# Node.js

Node.js is an open-source, cross-platform run-time environment built on Chrome's V8 JavaScript engine.

Node.js is not a programming language. It is used to execute JavaScript code outside of a web browser. It provides a library of various JavaScript modules, which simplifies the development of web applications.

## npm - node package manager

npm is a package manager for the JavaScript programming language. It is the default package manager for the JavaScript runtime environment -Node.js. 

npm consists of three components:
-  The website - discovers packages, set up profiles, and manage access to public or private packages. 
-  The CLI  - runs from a terminal and allow us to interact with npm. 
-  The registry  - a public database of JavaScript packages.

## package.json

When you create a Javascript project with node, it automatically creates a package.json in the root directory of the project

The package.json holds information/metadata about the project:

-   description
-   version
-   license information
-   author
-   entry point
-   dependencies
-   scripts

There are two types of dependencies in package.json

-   dependencies: are essential to running the application
-   devDependencies: are dependencies that are only being used during development of the application

### Installation of Node and npm

We need to add Node.js and an npm package manager to our development environment.

* Download the LTS version of Node.js from [nodejs.org](https://nodejs.org/en/) and install it. To check the version, run `node -v` in a terminal.

* The npm CLI gets installed with Node.js by default. To check that you have installed npm, run `npm -v` in a  terminal. 

## Run through Node.JS Example

# Typescript Intro

Typescript is an open-source, objected-oriented, typed, superset of Javascript, created by Microsoft

-   It contains all functionality of JavaScript
-   With additions of classes, interfaces, inheritance, modules, and more
-   It is portable across browsers and devices
-   It supports strong/static typing

Typescript is not directly readible by the browser, you must transpile the typescript into javascript before running it in the browser or in node

### Setting up Typescript

You can install Typescript using NPM (Node Package Manager) or the TypeScript Visual Studio Plugin.

After installing NPM, run the `npm install -g typescript` command to install TypeScript. To check the version, run the `tsc -v` command in the terminal. 

To compile the TypeScript code, run the `tsc` command, followed by the name of the file you are compiling. After compliation, typescript compiler creates a javascript file with the same name.

## Datatypes

Like Javascript you still declare variables with var, let, const, however you now must declare a type:

-   ex. `let varname : [type] = value`

There are 11 datatypes in Typescript

-   Boolean: true or false
-   Number: integer, or decimal number
-   String: text inclosed in single or double quotes
-   Undefined: same as JS
-   Null: same as JS
-   Any: acts as normal JS variables
-   Void: used for functions that do not return anything
-   Arrays: dynamic size like JS, store a single datatype
-   Tuples: an array that can store a fixed number of objects
-   Enum: declare a set of named constants
-   Never: represents a type of value that never occur. For instance, never is the return type for a    function that always throws an exception.

## Classes and Access Modifiers

In typscript the `class` keyword is used to declare a class, and the `new` keyword can be used to create a new instance of a class

You can implement inheritance with typescript classes using the extends keyword, similar to Java

Typescript has three access modifiers:

-   public: the default modifier, can be accessed anywhere
-   private: can only be accessed inside the class
-   protected: can only be accessed inside of the class or child classes

We can also make properties read only with the readonly modifier

In typscript, the code we write is globally scoped by default. To restrict this, typescript provide modules and namespaces. All variables, classes, and functions declared in a module are not accessible outside of said module

You can create a module using the export keyword, and you can use other modules by using the import keyword

Typescript supports getters and setters to access and set class members, you simple put set and get keyword to create these mutators. You can use these as properties rather than functions.

## Interfaces

Interfaces allus us to create contracts that other classes/objects can implement

You define an interface withe the `interface` keyword, which incldes the properties you want the class/object to have

You can include optional properties with the `?`

The typescript compiler does not convert the interface, it just uses it for type checking

## Decorators

A decorator is a special kind of declaration attached to a class, method, accessor, property, or parameter, they look like annotations from Java

In typescript we have to enable experimental support for decorators in the tsconfig.json file to true

## Types of Decorators

Class is declared before a class declaration that is applied to the constructor of the class, and is used to observe, modify, or replace a class definition

Method is declared before a method declaration, and is applied to the property descriptor for the method, they are used to observe, modify, or replace a method definition

Property, are used to listen to state changes in a class

Parameter is declared before a parameter declaration and is applied to the function for a class constructor or method declaration

Accessor is applied to the property descriptor for an accessor

We will see the use of Decorators often in Angular

## Typescript Examples

# Webpack

In our web application, we use many javascript files that are added into the HTML pages via `<script>` tags.  For each user request, the browser loads these bunch of script files inside the HTML page. This is inefficient as it reduces the page speed since the browser requests each script file separately.

This can be solved by bundling several files together into one file to be downloaded by the browser in one single request.

Webpack is a powerful static module bundler for JavaScript applications that packages all modules in our application into a bundle and serves it to the browser.

Webpack builds a dependency graph  when it processes the application. It starts from a list of modules defined in its config file and recursively builds a dependency graph that includes every module our application needs, then packages all of those modules into a small bundle that can be loaded by the browser.

References::

https://hackmd.io/@benjipeto/typescript-cheatsheet#Object-Types
