import java.util.Locale;
import java.util.Scanner;


public class TheSmallestOf3Numbers {

	public static void main(String[] args){
				
		Locale.setDefault(Locale.ROOT);
		Scanner reader = new Scanner(System.in);
		while (true) {

			System.out.print("Enter 3 numbers: ");
			double first = reader.nextDouble();
			double second = reader.nextDouble();
			double third = reader.nextDouble();
			double smallest = Math.min(first, Math.min(second,third));
			System.out.print("Smallest: ");
			if (smallest % 1 == 0) {
				System.out.println((int)smallest);
			}
			else {
				System.out.println(smallest);
			}			
			System.out.println("================");
		}
	}
}