Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine()!;

if(username.ToLower() == "маша")  // .ToLower() - приводит буквы к нижнему регистру
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}