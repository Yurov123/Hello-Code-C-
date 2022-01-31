Console.Write("Enter yuor name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hello,same Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}