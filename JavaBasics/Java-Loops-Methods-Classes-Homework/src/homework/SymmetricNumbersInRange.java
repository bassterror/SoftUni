package homework;
import java.util.Scanner;

public class SymmetricNumbersInRange {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
        while (true) {
        	System.out.print("Enter first: ");
        	int start = reader.nextInt();
        	System.out.print("Enter last: ");
            int end = reader.nextInt();
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
