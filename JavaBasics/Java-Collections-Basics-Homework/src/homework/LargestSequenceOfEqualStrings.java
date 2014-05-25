package homework;
import java.util.Arrays;
import java.util.Scanner;

public class LargestSequenceOfEqualStrings {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter strings: ");
			String string = reader.nextLine();
			String[] strings = string.split(" ");
			Arrays.sort(strings);
			int counterTemp = 1;
			int counter = 1;
			int position = 0;

			for (int i = 1; i < strings.length; i++) {
				if (strings[i].equals(strings[i - 1])) {
					counterTemp++;
				} else {
					counterTemp = 1;
				}
				if (counterTemp > counter) {
					counter = counterTemp;
					position = i;
				}
			}
			for (int i = 0; i < counter; i++) {
				if (i != counter - 1) {
					System.out.print(strings[position] + " ");
				} else {
					System.out.print(strings[position]);
				}				
			}
			System.out.println();
			System.out.println("========================================");
		}
	}
}