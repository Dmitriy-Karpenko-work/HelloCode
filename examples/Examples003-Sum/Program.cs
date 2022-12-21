/* сложение простое
int numberA = 31;
int numberB = 5;
int result = numberA + numberB; // Добавлена переменная RESULT
Console.WriteLine(result);
*/
/* Еще один вариант решения
int numberA = 3;
int numberB = 5;
Console.WriteLine(numberA + numberB);
*/

int numberA = new Random().Next(1, 10); // 1 2 3 4 5 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
