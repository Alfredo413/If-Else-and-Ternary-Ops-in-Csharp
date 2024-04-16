// conditionals similar to Javascript;
// AND written as &&
// OR  written as || 


List<int> list1 = new List<int> { 1, 0, 2, 3 };

for (int i = 0; i < list1.Count; i++)
{
    if (list1[i] == 1 || list1[i] >= 3)
    {
        Console.WriteLine("hit");
    }
    else
    {
        Console.WriteLine("miss");
    }
}
Console.WriteLine("- - -");


//Inline Statement, also called Ternary Operator.
// start with boolean question:  3 > 2 ?
// if true, return left of colon:  10:
// if false, return right of colon:  :5
var inlineStatement1 = 3 > 2 ? 10 : 5;              // True; Thus 10.
var inlineStatement2 = 0 == 0 && 1 != 1 ? 10 : 5;   // False; Thus 5.
var inlineStatement3 = 9 <= 10 ? "T" : "F";         // True; Thus "T".

Console.WriteLine(inlineStatement1);
Console.WriteLine(inlineStatement2);
Console.WriteLine(inlineStatement3);