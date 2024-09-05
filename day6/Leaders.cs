using System;
class Leaders{
	static void Main(string [] args){
	int [] a1= new int [args.Length];
	for(int i=0;i<args.Length;i++){
		a1[i]=Convert.ToInt32(args[i]);
	}
	Console.WriteLine("The leaders are: ");	
	for(int i=args.Length-1;i>0;i--){
	int c=0;
	for(int j=args.Length-1;j>i;j--){
	if(a1[j]>a1[i]){
	c++;
}
}
	if(c==0){
		Console.Write(a1[i]+" ");
	}

}
}
}