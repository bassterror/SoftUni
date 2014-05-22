import java.util.Scanner;

public class SymmetricNumbersInRange {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
        while (true) {
        	System.out.print("Enter first: ");
        	int start = input.nextInt();
        	System.out.print("Enter last: ");
            int end = input.nextInt();
            for(int number = start ; number<=end ; number++){
                    if(check(number)==true){
                            System.out.print(number);
                            if(number!=end) System.out.print(" ");
                    }
            }
            System.out.println();
            System.out.println("===================================================");
		}
	}
	
	public static boolean check(int number){
        if (Integer.toString(number).equals(new StringBuilder(Integer.toString(number)).reverse().toString())){
        	return true;
        }        
	    else{
	        return false;
	    }
	}
}
