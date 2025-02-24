using System;
class Quadratic{
	//method to calculate the roots
	public static double[] CalculateRoots(double a, double b,double c){
		//calculate delta
		double delta= Math.Pow(b,2) + 4*a*c;
		//if delta positive we have two roots
		if (delta>0){
			double[] roots = new double[2];
			double root1 = (-b + delta)/(2*a);
			double root2 = (-b - delta)/(2*a);
			roots[0]=root1;
			roots[1]=root2;
			return roots;
		}
		//if delta is zero than we have one root
		else if (delta==0){
			double [] roots = new double[1];
			double root1 = -b/(2*a);
			roots[0]=root1;
			return roots;
		}
		//empty array for negative delta
		else{
			return  new double[0];

		}
	}
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter a: ");
		double a=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter b: ");
		double b=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter c: ");
		double c=Convert.ToDouble(Console.ReadLine());
		//Calculate roots
		double[] roots=  CalculateRoots(a,b,c);
		//Display output
		for(int i=0;i<roots.Length;i++){
			Console.WriteLine($"root is :{roots[i]}");}
	}}