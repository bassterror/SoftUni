package homework;
import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter n: ");
			int n = reader.nextInt();
			int[] numbers = new int[n];
			for (int i = 0; i < numbers.length; i++) {
				numbers[i] = reader.nextInt();
			}
			Arrays.sort(numbers);
			for (int i = 0; i < numbers.length; i++) {
				System.out.print(numbers[i] + " ");
			}
			System.out.println();
			System.out.println("===================================");
		}
	}
}