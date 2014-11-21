package homework;
import java.util.Scanner;

public class DecimalToHexadecimal {

	@SuppressWarnings("resource")
	public static void main(String[] args){
		
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter number: ");
			int number = reader.nextInt();
			String hex = Integer.toHexString(number).toUpperCase();
			System.out.print("Hex: ");
			System.out.println(hex);
			System.out.println("=====================");
		}
	}
}
