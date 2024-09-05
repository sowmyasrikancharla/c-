using System;
class Missing{
	static void Main(string [] args){
	Console.Write("Enter the Size of array:");
	int n=Convert.ToInt32(Console.ReadLine());
		int [] a1=new int [n];

	for (int i=1;i<n;i++){
		a1[i]=Convert.ToInt32(Console.ReadLine());
}
	for (int i=1;i<n-1;i++){
	if(a1[i+1]-a1[i]!=1){
	Console.WriteLine("Missing value is "+(a1[i]+1));
	}
}	
}
}