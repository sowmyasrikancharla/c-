using System;
class D5{
	public delegate void Show(int a,int b,int c);
	public void display(int a,int b,int c){
	Console.WriteLine( a*b+c);
	}
	public void Add(int a,int b,int c){
	Console.WriteLine(a+b+c);
	}
	public void Mul(int a,int b,int c){
	Console.WriteLine(a*b*c);
	}

	static void Main(string [] args){
	D5 d=new D5();
	Show s1= new Show(d.display);
	s1+=d.Add;
	s1+=d.Mul;
	s1.Invoke(23,3,8);
}
}