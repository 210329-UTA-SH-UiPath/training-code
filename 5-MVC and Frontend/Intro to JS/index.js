// JavaScript
// Named Function
function BasicFunction(){
    //alert('Hello world');// A global function which belongs to Global object Window
    let name=prompt("Hello! What's your name");
    console.log(`Hello ${name}`);
}
//Anonynous Function
// let BasicFunction=function(){
//     //alert('Hello world');// A global function which belongs to Global object Window
//     let name=prompt("Hello! What's your name");
//     console.log(`Hello ${name}`);
// }

//Arrow Function
// let BasicFunction=()=>{
//     //alert('Hello world');// A global function which belongs to Global object Window
//     let name=prompt("Hello! What's your name");
//     console.log(`Hello ${name}`);
// };

//Callback functions
function ParentFunction(anyfunction){
    console.log('Inside parent function');
    let name=prompt('Please enter your name');
    anyfunction(name);
    console.log('Back to parent function')
}

//var cBack=function CallBack(name){ //Function Expression
    function CallBack(name){
    console.log( `hello ${name}`);
    console.log('I am in callback function');
}
//IIFE => Immediate Invoked Function Expressions
//Arrow Functions=> shorthand notations for anonymous functions
let Outer=(()=>{
    let count=0;
    return function inner(){
        return count++ ;
    };
})();
console.log(Outer);
(()=> console.log('Hi I am IIFE'))();