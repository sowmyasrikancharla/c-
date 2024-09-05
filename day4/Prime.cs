using System;
class Prime{
	static void Main(string [] args){
	int count;
	Console.Write("Enter Range:");
	string inp=Console.ReadLine();
	int range=Convert.ToInt32(inp);
		for(int i=2;i<range;i++){
		count=0;
		for (int j=2;j<i;j++){
			if(i%j==0){
				count+=1;
			}		
	}
	if(count==0){
			Console.Write(i+" ");	
}
}
}
}