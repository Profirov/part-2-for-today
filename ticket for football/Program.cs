decimal budget = decimal.Parse(Console.ReadLine());
string ticketType  = Console.ReadLine();
int people = int.Parse(Console.ReadLine());

decimal transportCharges = 0.00M;
decimal moneyForTickets = 0.00M;
decimal moneyDifference = 0.00M;

if (people <= 4)
{
    transportCharges = 0.75M * budget;
}
else if (people <= 9)
{
    transportCharges = 0.60M * budget;
}
else if (people <= 24)
{
    transportCharges = 0.50M * budget;
}
else if (people <= 49)
{
    transportCharges = 0.40M * budget;
}
else if (people <= 50)
{
    transportCharges = 0.25M * budget;
}
switch (ticketType)
{
    case "Normal":
        moneyForTickets = people * 249.99M;
        break;
    case "VIP":
        moneyForTickets = people * 499.99M;
        break;
    default:
        break;
}
moneyDifference = budget - transportCharges - moneyForTickets;
string result = string.Format($"Yes have {decimal.Round(moneyDifference, 2)} leva left.");
if (moneyDifference < 0)
{
    result = string.Format($"Not enough money! You need {Math.Abs(decimal.Round(moneyDifference, 2))}");
}