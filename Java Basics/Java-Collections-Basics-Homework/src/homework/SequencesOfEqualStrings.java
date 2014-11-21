package homework;
import java.util.Arrays;
import java.util.Scanner;

public class SequencesOfEqualStrings {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter strings: ");
			String string = reader.nextLine();
			String[] strings = string.split(" ");
			Arrays.sort(strings);
			
			for (int i = 0; i < strings.length - 1; i++) {
				if (strings[i].equals(strings[i + 1])) {
					System.out.print(strings[i] + " ");
					if (i == strings.length - 2) {
						System.out.print(strings[i + 1]);
					}
				} else {
					System.out.print(strings[i]);
					System.out.println();
					if (i == strings.length - 2) {
						System.out.print(strings[i + 1]);						
					}
				}
			}
			System.out.println();
			System.out.println("=====================");
		}		
	}
}
