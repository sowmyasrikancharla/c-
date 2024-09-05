using System;
using System.IO;
class Ex1{
	public static void Main(string [] args){
	FileStream f=new FileStream(@"C:\Users\sowmy\OneDrive\Desktop\text1.txt",FileMode.OpenOrCreate);
	StreamReader s1=new StreamReader(f);
	String line= s1.ReadLine();
	Console.WriteLine(line);
	if(line!=null){
	Console.WriteLine(line);
	}
	else{
	Console.WriteLine("Done");
	}
	while((line=s1.ReadLine())!=null){
	Console.WriteLine(line);
}
	

}
}