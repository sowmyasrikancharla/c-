using System;
class Pattern{
	public static void Main(string [] args){
	string inp=Console.ReadLine();
	int n=Convert.ToInt32(inp);
	Console.WriteLine(n);
	int c=65;
	string s="";
	char p;
	for(int i=0;i<n;i++){
			//s=" "*(n-i-1);
		for(int j=0;j<i+1;j++)
		{
			p=Convert.ToChar(c);
			Console.Write(p);
			//s=s+p+" ";
		}
		c++;
	Console.WriteLine();
}
}}
