using  System;
class Single1{
	static void Main(string [] args){
	int [] a1=new int [args.Length];
	for (int i=0;i<args.Length;i++){
		a1[i]=Convert.ToInt32(args[i]);
}
	foreach(int i in a1){
		Console.WriteLine(i);
	} 
}
}
