package homework;
import java.util.ArrayList;
import java.util.Scanner;

public class CombineListsofLetters {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			ArrayList<Character> l1 = new ArrayList<Character>();
			ArrayList<Character> l2 = new ArrayList<Character>();
			ArrayList<Character> combined = new ArrayList<Character>();
			System.out.print("Enter first list of letters: ");
			for (char ch : reader.nextLine().toCharArray()) {
				l1.add(ch);
			}
			combined.addAll(l1);
			System.out.print("Enter second list of letters: ");
			for (char ch : reader.nextLine().toCharArray()) {
				l2.add(ch);
			}
			for (int i = 0; i < l2.size(); i++) {
				if (!l1.contains(l2.get(i))) {
					combined.add(' ');
					combined.add(l2.get(i));
				} else {
					continue;
				}
			}
			System.out.print("Result: ");
			for (int i = 0; i < combined.size(); i++) {
				System.out.print(combined.get(i));
			}
			System.out.println();
			System.out.println("=============================");
		}
	}
}
