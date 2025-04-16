using System.Globalization;

CultureInfo ci = new CultureInfo("en-US");
char ans;

do
{
    Console.WriteLine("-------- TIP CALCULATOR -----------");

    // Get initial bill total and desired tip percentage
    Console.Write("Enter bill total: ");
    decimal bill = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Enter tip %: ");
    decimal tipPercent = Convert.ToDecimal(Console.ReadLine());

    // Calculate tip amount and print formatted total
    decimal tipAmount = bill * (tipPercent/100);
    Console.WriteLine($"Your tip is {(tipAmount).ToString("C", ci)}");
    Console.WriteLine($"The grand total for your bill is: {(bill + tipAmount).ToString("C", ci)}");

    // Check for exit condition from user
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
