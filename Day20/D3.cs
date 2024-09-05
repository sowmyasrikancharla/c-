using System;
class D3{
	public delegate int Show(int a,int b,int c);
	public static int display(int a,int b,int c){
	return a*b+c;
}

	static void Main(string [] args){
	Show s1=display;
	Console.WriteLine(s1(23,3,8));
}
}