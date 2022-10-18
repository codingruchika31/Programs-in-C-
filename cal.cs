using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Console.WriteLine("Choose option: 1-Addition 2-Subraction 3-Division 4-Multiplication 5-Power");
		//int c=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter enter two numbers");
		int a=Convert.ToInt32(Console.ReadLine());
		int b=Convert.ToInt32(Console.ReadLine());
		switch(Convert.ToInt32(Console.ReadLine()))
		{
			case 1: int sum=0;
					sum=a+b;
					Console.WriteLine("Addition {a} + {b} ="+sum);
					break;
			case 2: int sub=0;
					sub=a-b;
					Console.WriteLine("Subtraction {a} - {b} ="+sub);
					break;
			case 3: double div=0.0;
					div=(double)a/b;
					Console.WriteLine("Division {a} / {b} ="+div);
					break;
			case 4: int mul=0;
					mul=a*b;
					Console.WriteLine("Multiplication {a} * {b} ="+mul);
					break;
			case 5: double pow=0;
					pow=(double)Math.Pow(a,b);
					Console.WriteLine("Power {a} ^ {b} ="+pow);
					break;
			default: Console.WriteLine("Incorrect choice no such operation available");
					break;
		}
	}
				
}