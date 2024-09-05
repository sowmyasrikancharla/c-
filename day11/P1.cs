using System;
class P1{
	public static void Main(string [] args){
	int []arr=new int [3];
	int [] a1=new int [3];
	Console.Write("Enter input1: ");
	arr[0]=Convert.ToInt32(Console.ReadLine());
	if(arr[0]>1000 && arr[0]<=9999){
		Console.Write("Enter input2: ");
		arr[1]=Convert.ToInt32(Console.ReadLine());
		if(arr[1]>=1000 && arr[1]<=9999){
			Console.Write("Enter input3: ");
			arr[2]=Convert.ToInt32(Console.ReadLine());
			if(arr[2]>=1000 && arr[2]<=9999){

			int c=0;
	int result=0;
	while(c<=3){
	for(int i=0;i<3;i++){
		int r=arr[i]%10;
		arr[i]=arr[i]/10;
		a1[i]=r;

	}
	int max=a1[0];
	int temp=0;
	foreach(int x in a1){
	if(x>max){
		temp=max;
		max=x;
	}
	}
	c++;
	result=result*10+max;
	}
	Console.WriteLine(result);
	int ans=0;
	while(result>0){
	int rem=result%10;
	result=result/10;
	ans=ans*10+rem;
	}

	Console.WriteLine(ans);
	}

	else{
		Console.WriteLine("Invalid Input");
		}
		}
		else{
			Console.WriteLine("Invalid Input");

		}
		}
	else{
	Console.WriteLine("Invalid Input");
	}
	}
}