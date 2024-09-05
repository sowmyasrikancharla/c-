using System;
using System.Collections.Generic;
class Birthday{
static void Main(string [] args){
SortedList <string,int> s1=new SortedList<string,int>();
Console.WriteLine("Enter the number of people: ");
int n=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
	Console.Write("Enter name for person{0}",i);
	string name=Console.ReadLine();
	Console.Write("Enter age for person{0}",i);
	int age=Convert.ToInt32(Console.ReadLine());
	s1.Add(name,age);
}
Console.WriteLine(s1.GetKey(1));
}
}