package homework;
import java.util.Scanner;

public class LongestIncreasingSequence {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter numbers: ");
			String string = reader.nextLine();
			String[] strings = string.split(" ");
			int[] numbers = new int[strings.length];
			for (int i = 0; i < numbers.length; i++) {
				numbers[i] = Integer.parseInt(strings[i]);
			}
			int counterTemp = 1;
			int counter = 1;
			int position = 0;
			
			for (int i = 0; i < strings.length - 1; i++) {
				if (numbers[i] < numbers[i + 1]) {
					counterTemp++;
				} else {
					counterTemp = 1;
				}
				if (counterTemp > counter) {
					counter = counterTemp;
					position = i + 1;
				}
			}

			System.out.print("Result: ");
			for (int i = 0; i < counter; i++) {
				if (i != counter - 1) {
					System.out.print(numbers[position - (counter - 1) + i] + " ");
				} else {
					System.out.print(numbers[position - (counter - 1) + i]);
				}
			}
			System.out.println();
			System.out.println("============================================");
		}
	}
}