using BankEncapsulation;


    var instance = new BankAccount();


Console.WriteLine("enter in the amount you would like to deposit");
double userInput = double.Parse(Console.ReadLine());


instance.Deposit(userInput);
Console.WriteLine($"Your balance is: {instance.GetBalance()}");