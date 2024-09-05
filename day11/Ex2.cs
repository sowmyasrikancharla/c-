using System;
using System.IO;
class Ex2{
	public static void Main(string [] args){
	Console.WriteLine("Choose the file 0 or 1 or 2");
	string [] a=new string []
	{@"C:\Users\sowmy\OneDrive\Desktop\Sample1.txt",@"C:\Users\sowmy\OneDrive\Desktop\Sample2.txt",@"C:\Users\sowmy\OneDrive\Desktop\Sample3.txt"};
	foreach(string x in a){
	Console.WriteLine(x);
}
	int n=Convert.ToInt32(Console.ReadLine());
	
	FileStream f=new FileStream(a[n],FileMode.OpenOrCreate);
	StreamReader s1=new StreamReader(f);
	String line= s1.ReadLine();
	if(line!=null){
	Console.WriteLine(line);
	}
	else{
	Console.WriteLine("Done");
}
}
}