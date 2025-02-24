using System;
class OTP{
	//method to generate 6 Digit Otp
	public static int Generate6DigitOTP(){
		Random random = new Random();
		return random.Next(100000,1000000);
	}
	//method to check if Otps are unique
	public static bool IsUniqueOTPs(int[] otps){
		for(int i=0;i<otps.Length;i++){
			for(int j=i+1;j<otps.Length;j++){
				if (otps[i]==otps[j]){
					return false;
				}
			}
		}
		return true;
	}
	static void Main(string[] args){
		//Initialize array
		int[] otps =new int[10];
		//loop to fill the otps array
		for(int i=0;i<10;i++){
			otps[i]=Generate6DigitOTP();
			
		}
		//check conditions of unique otps and display output
		if(IsUniqueOTPs(otps)){
			Console.WriteLine("All Otps are unique");
		}
		else{
			Console.WriteLine("All Otps are not unique");
		}
		
	}}