using System;

string test1 = @"{([()()([][])()({})])}";
string test2 = @"{([()()([][])()({})])";
string test3 = @"{()([][])(])}";

var validator = new StringValidator();

Console.WriteLine($"Texto válido: { validator.Validate(test1)}");
Console.WriteLine($"Texto válido: { validator.Validate(test2)}");
Console.WriteLine($"Texto válido: { validator.Validate(test3)}");