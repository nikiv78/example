Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Машка-какашка!");
}
else
 {
    Console.Write("Hi, ");
    Console.WriteLine(username);
}