package homework;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractEmails {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter text: ");
			String input = reader.nextLine().toLowerCase();
			Pattern pattern = Pattern.compile("[\\w-+]+(?:\\.[\\w-+]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");
			Matcher matcher = pattern.matcher(input);
			System.out.println("Emails:");
			System.out.println("-----------------------------");
			while (matcher.find()) {
				System.out.println(matcher.group());
			}
			System.out.println("=============================");
		}
	}
}
