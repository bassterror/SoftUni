package homework;
import java.util.Scanner;

public class AngleUnitConverter {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter angles count: ");
			int count = Integer.parseInt(reader.nextLine());
	        String[] commands = new String[count * 2];
	        int index = 0;
	        for(int i = 0 ; i < count ; i++){
	        	
	        	System.out.print("Enter angel: ");
	        	String[] degree = reader.nextLine().split(" ");
                commands[index] = degree[0];
                char[] type = degree[1].toCharArray();
                if(type[0] == 'r') {
                	commands[index + 1] = "r";
                }
                else {                	
                	commands[index + 1] = "d";
                }
                index += 2;
            }
	        index = 0;
	        for(int i = 0 ; i < count; i++){
        		if(commands[index + 1] == "r") {
        			System.out.format("%.6f deg", (Math.toDegrees(Double.parseDouble(commands[index]))));
        			System.out.println();
        		}
        		else {
        			System.out.format("%.6f rad",Math.toRadians(Double.parseDouble(commands[index])));
        			System.out.println();
        		}
        		index +=2;
	        }
	        System.out.println("=========================");
		}        
	}
}
