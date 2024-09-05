using  System;
class Target{
	static void Main(string [] args){
	int [] a1=new int [args.Length];
	for (int i=0;i<args.Length;i++){
		a1[i]=Convert.ToInt32(args[i]);
}
	Console.Write("Enter target: ");
	int target=Convert.ToInt32(Console.ReadLine());
	string status="False";
	for (int i=0;i<args.Length;i++){
		for (int j=0;j<args.Length;j++){
			if(a1[i]+a1[j]==target){
				Console.WriteLine(i+","+j);
				status="true";
				break;			
			}
		}
		if(status=="true"){
			break;
		}
		
}
}
}
