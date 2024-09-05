using System;
class Ages{
	static void Main(string [] args){
	int [] ages=new int [args.Length];
	for(int i=0;i<args.Length;i++){
		ages[i]=Convert.ToInt32(args[i]);
	}
	int max=ages[0];
	int min=ages[0];
	int maxTemp=0;
	int minTemp=0;
	for(int x=0 ; x<args.Length;x++){
	if(ages[x]>max){
		maxTemp=ages[x];
		ages[x]=max;
		max=maxTemp;
	}
	if(ages[x]<min){
		minTemp=ages[x];
		ages[x]=min;
		min=minTemp;
	}

	}
	Console.WriteLine("Maximum Element is"+max);
	Console.Write("Minimum Element is"+min);

}

}