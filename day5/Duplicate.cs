using System;
class Duplicate{
	static void Main(string [] args){
	int [] a1=new int [args.Length];
	for (int i=0;i<args.Length;i++){
		a1[i]=Convert.ToInt32(args[i]);
}

	for (int i=0;i<args.Length;i++){
		int c=0;
		for (int j=0;j<args.Length;j++){
			if(a1[i]==a1[j]){
				c++;			
			}
		}
		if(c!=1){
		Console.Write("Duplicate Element is "+a1[i]);
		break;
		}

}

}
}