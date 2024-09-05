using System;
class Remove{
	
	static int [] RemoveElementFromArray(int []a1,int ele,int n){
		int []a2= new int [n-1];
		int j=0;
	 	foreach(int x in a1){
		if(x!=ele){
		a2[j]=x;
		j++;
}
	}
	return a2;
}
	static void Main(string [] args){
	Console.Write("Enter Element: ");
	int ele=Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter size: ");
	int n=Convert.ToInt32(Console.ReadLine());
	int []a1= new int [n];

	for(int i=0;i<n;i++){
	a1[i]=Convert.ToInt32(Console.ReadLine());
}
	int []result=RemoveElementFromArray(a1, ele,n);
	Console.Write("Resultant Array is ");
	foreach(int x in result ){
	Console.Write(x+" ");
	}
}
}
