using System;
class Status{
	static void Main(string [] args){
	int [] a1=new int [args.Length];
	Console.Write("Enter number: ");
	int n=Convert.ToInt32(Console.ReadLine());
	int c=0;
	for (int i=0;i<args.Length;i++){
		a1[i]=Convert.ToInt32(args[i]);
}
	for (int i=0;i<args.Length;i++){
		if(n==a1[i]){c++;}

}
	if(c>=2){Console.WriteLine("True");}
	else{Console.WriteLine("False");}

}
}