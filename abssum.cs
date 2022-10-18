using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Console.WriteLine("Enter size of array");
		int n=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter array elements");
		int []a=new int[n];
		for(int i=0;i<n;i++)
		{
			a[i]=Convert.ToInt32(Console.ReadLine());
		}
		Program obj=new Program();
	    obj.arraySum(a);
	}
	void arraySum(int []arr)
	{
		int poscount=0,nevcount=0;
		for(int i=0;i<arr.Length;i++)
		{
			if(arr[i]>0)
				poscount=poscount+arr[i];
			else
				nevcount=nevcount+arr[i];
		}
		if(Math.Abs(nevcount)>poscount)
			Console.WriteLine("Largest abs sum="+nevcount);
		else 
			Console.WriteLine("Largest abs sum="+poscount);
	}
}