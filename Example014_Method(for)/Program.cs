﻿// Метод for


string Method4(int count, string Text )
{
 
   string result = String.Empty;
   for(int i = 0;i < count; i++)
   {
       result = result + Text;
   }
   return result;
}
string res = Method4(10, "z");
// Console.WriteLine(res);

// Цикл в цикле

for(int i = 2;i < 10; i++)
{
    for(int j = 2;j <= 10; j++)
    {
      Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}












