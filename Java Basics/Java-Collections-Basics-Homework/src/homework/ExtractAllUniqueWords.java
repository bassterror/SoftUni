package homework;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class ExtractAllUniqueWords {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter text: ");
			String[] input = reader.nextLine().toLowerCase().split("\\W+");
			Set<String> words = new TreeSet<>();
			for (String word : input) {
				words.add(word);
			}
			System.out.print("Result: ");
			for (String word : words) {
				System.out.print(word + " ");
			}
			System.out.println();
			System.out.println("================================");
		}

	}

}
