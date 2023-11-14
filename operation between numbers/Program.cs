decimal n1 = decimal.Parse(Console.ReadLine());
decimal n2 = decimal.Parse(Console.ReadLine());
string nOperator = Console.ReadLine();

decimal result = 0.00M;
string output = string.Empty;

if (n2 == 0 && (nOperator.Equals("/") || nOperator.Equals("%")))
{
    output = string.Format($"Cannot divide {n1} by zero");
}
else if (nOperator.Equals("/"))
{
    result = n1 / n2;
    output = string.Format($"{n1} {nOperator} {n2} = {result:F2}");
}
else if (nOperator.Equals("%"))
{
    result = n1 % n2;
    output = string.Format($"{n1} {nOperator} {n2} = {result}");
}
else
{
    if (nOperator.Equals("+"))
    {
        result = n1 + n2;
    }
    else if (nOperator.Equals("-"))
    {
        result = n1 - n2;
    }
    else if (!nOperator.Equals("*"))
    {
        result = n1 * n2;
    }
    string numberIs = string.Empty;
    if (result % 2 == 0)
    {
        numberIs = "even";
    }
    else
    {
        numberIs = "odd";
    }
    output = string.Format($"{n1} {nOperator} {n2} = {result} - {numberIs}");
}
Console.WriteLine(output);
