Console.WriteLine("FizzBuzz");
string input = "";
int number = 0;

do
{
    Console.WriteLine("Please enter a positive integer");
    input = Console.ReadLine();
    number = int.Parse(input);

    if (number <= 0)
    {
        Console.WriteLine("The number should be greater than 0");
    }
} while (number <= 0);

for (int i = 0; i <= number; i++)
{
    if ((i % 3) <= 0)
     {
         if ((i % 5) <= 0)
         {
             Console.WriteLine("Buzz");
         }
         else
         {
             Console.WriteLine("Fizz");
         }
     }
     else
     {
         Console.WriteLine(i);
     }
}