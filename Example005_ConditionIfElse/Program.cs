Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "иван")
{
    Console.Write("Привет, дорогой Иван!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
