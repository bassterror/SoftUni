package homework;
import java.util.Scanner;

public class CountAllWords {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter sentence: ");
			String input = reader.nextLine();		
			String[] words = input.split("\\W+");
			System.out.print("Words count: ");
			System.out.println(words.length);
			System.out.println("=======================");
		}
	}
}
