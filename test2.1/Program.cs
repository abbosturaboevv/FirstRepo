Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLowerInvariant() == "Аббос") 
{
    Console.WriteLine("Это же Аббос!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}