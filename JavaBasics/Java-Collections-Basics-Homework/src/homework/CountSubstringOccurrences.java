package homework;
import java.util.Scanner;

public class CountSubstringOccurrences {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter sentence: ");
			String input = reader.nextLine().toLowerCase();
			System.out.print("Enter string: ");
			String string = reader.nextLine().toLowerCase();
			int counter = 0;

			for (int i = 0; i <= input.length() - string.length(); i++) {
				if (input.substring(0 + i, string.length() + i).contains(string)) {
					counter++;
				}
			}
			System.out.print("Count: ");
			System.out.println(counter);
			System.out.println("=====================");
		}

	}
}