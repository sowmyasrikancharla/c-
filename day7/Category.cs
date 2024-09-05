using System;

abstract class Vehicle{
	protected abstract void Description(string name,int n);
}

class Category:Vehicle{
	protected override void Description(string name,int n){
	Console.WriteLine("The number of wheels in a {0} are {1} ",name,n);
}

	static void Main(string [] args){
	int n=Convert.ToInt32(args[0]);
	string name=args[1];
	Category c1=new Category();
	c1.Description(name,n);
}
}