package Exam;

import java.math.BigDecimal;
import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;

public class ThreeLargestNumbers {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner reader = new Scanner(System.in);
		int n = reader.nextInt();
		BigDecimal[] numbers = new BigDecimal[n];
		for (int i = 0; i < n; i++) {			
			numbers[i] = reader.nextBigDecimal();
		}
		Arrays.sort(numbers);
		if (numbers.length > 3) {
			for (int i = numbers.length - 1; i > numbers.length - 4; i--) {
				System.out.println(numbers[i]);
			}
		}
		else {
			if (numbers.length == 3) {
				System.out.println(numbers[2]);
				System.out.println(numbers[1]);
				System.out.println(numbers[0]);
			}
			if (numbers.length == 2) {
				System.out.println(numbers[1]);
				System.out.println(numbers[0]);
			}
			if (numbers.length == 1) {
				System.out.println(numbers[0]);
			}
		}
	}
}
