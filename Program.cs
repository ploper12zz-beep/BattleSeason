int totalexp = 0;

Console.Write("input your name: ");
string name = Console.ReadLine();
Console.Write("input your battle number: ");
int battlenumber = int.Parse(Console.ReadLine());
Console.Write("input the EXP gained per battle: ");
int expPerBattle = int.Parse(Console.ReadLine());

Console.WriteLine("\n-----------------------------");
for (int i = 1; i <= battlenumber; i++)
{
    Console.WriteLine($"Battle {i} | Exp gained: {expPerBattle} | Total Exp: {totalexp += expPerBattle}");
}

Console.WriteLine("\n== BATTLE SEASON COMPLETE ==");
Console.WriteLine($"Player: {name}");
Console.WriteLine($"Total Battles: {battlenumber}");
Console.WriteLine($"Total EXP earned: {totalexp}");
