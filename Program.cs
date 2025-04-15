using System.Globalization;

CultureInfo ci = new CultureInfo("en-US");
char ans;

do
{
    Console.WriteLine("-------- TIP CALCULATOR -----------");
    Console.Write("Enter bill total: ");
    decimal bill = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Enter tip %: ");
    decimal tipPercent = Convert.ToDecimal(Console.ReadLine());
    decimal tipAmount = bill * (tipPercent/100);
    Console.WriteLine($"Your tip is {(tipAmount).ToString("C", ci)}");
    Console.WriteLine($"The grand total for your bill is: {(bill + tipAmount).ToString("C", ci)}");
    while (true)
    {
        Console.WriteLine("\nWould you like to calculate another bill? (y/n)");
        ans = Convert.ToChar(Console.ReadLine().ToLower());
        if (ans != 'n' && ans != 'y')
        {
            Console.WriteLine("Invalid input!");
            continue;
        }
        break;
    }
    Console.WriteLine();
} while (ans != 'n') ;
