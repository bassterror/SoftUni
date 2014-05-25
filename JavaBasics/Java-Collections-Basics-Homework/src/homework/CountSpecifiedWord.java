package homework;
import java.util.Scanner;

public class CountSpecifiedWord {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter sentence: ");
			String input = reader.nextLine().toLowerCase();
			System.out.print("Enter word: ");
			String word = reader.nextLine().toLowerCase();
			String[] words = input.split("\\W+");
			int counter = 0;

			for (int i = 0; i < words.length; i++) {
				if (word.equals(words[i])) {
					counter++;
				}
			}
			System.out.print("Words count: ");
			System.out.println(counter);
			System.out.println("=========================");
		}
	}
}
