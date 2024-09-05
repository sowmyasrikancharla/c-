//Sample Test Case : 1

//123
//sum of the given number is: 6
//product of the given number is: 6
//it is a spy number
//Given number in reverse order: 321

using System;
class Spy{
	public static void Main(string [] args){
		int rem=0;
		int sum=0;
		int prod=1;
		int rev=0;
		Console.Write("Enter Number");
		string inp=Console.ReadLine();
		int num=Convert.ToInt32(inp);
		while(num>0){
			rem=num%10;
			num=num/10;
			sum=sum+rem;
			prod=prod*rem;
			rev=rev*10+rem;
}
Console.WriteLine("Sum of the given number is:"+sum);
Console.WriteLine("Product of the given number is:"+prod);
if(prod==sum){
	Console.WriteLine("It is a spy number");
	Console.WriteLine("Given number in reverse order: "+rev);
		
}
else{
	Console.WriteLine("It is not a spy number");
}
}
}
