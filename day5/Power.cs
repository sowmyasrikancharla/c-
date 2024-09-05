using System;
class Power{
	static void Main(string [] args){
	Console.Write("Enter number: ");
	int n=Convert.ToInt32(Console.ReadLine());
	int c=0;
	for (int i=0;i<n;i++){
	if(Math.Pow(2,i)==n){
		Console.WriteLine("True");
		c++;
		break;
	}
}
	if(c==0){
	Console.WriteLine("False");
}
}
}