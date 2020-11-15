import { StringValidator } from "./stringValidator.ts";

 
let test1 = "{([()()([][])()({})])}";
let test2 = "{([()()([][])()({})])";
let test3 = "{()([][])(])}";

let validator = new StringValidator();

console.log(`Texto válido: ${ validator.validate(test1)}`);
console.log(`Texto válido: ${ validator.validate(test2)}`);
console.log(`Texto válido: ${ validator.validate(test3)}`);