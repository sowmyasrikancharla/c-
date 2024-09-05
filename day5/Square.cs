using System;
class Square{
	static void Main(string [] args){
	Console.WriteLine("Enter number:");
	int n=Convert.ToInt32(Console.ReadLine());
	for(int i=1;i<n;i++){
	if((i*i)>=n){
		if((i*i)>n){
			Console.Write(i-1);
		}
		else{
			Console.Write(i);
		}
	break;


}
}
}
}