using System;

class Program
{
    static void Main()
    {
		while(true){
			Console.WriteLine("Give the first number");
        double num1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Give the operator");
		string op = Console.ReadLine();
		Console.WriteLine("Give the second number");
        double num2 = Convert.ToDouble(Console.ReadLine());
		
		switch(op){
			case "+":
				Console.WriteLine(num1 + num2);
				break;
			case "-":
				Console.WriteLine(num1 - num2);
				break;
			case "x":
				Console.WriteLine(num1 * num2);
				break;
			case "*":
				Console.WriteLine(num1 * num2);
				break;
			case "/":
				if(num2 == 0){
					Console.WriteLine("Division by 0 is not possible.");
				}
				else{
					Console.WriteLine(num1 / num2);
				}
				break;
			default:
				Console.WriteLine("Invalid Operator");
				break;
			}
			Console.WriteLine("Do you want to calculate again? (y/n)");
			if(Console.ReadLine().ToLower() != "y") break;
		}
    }
}

