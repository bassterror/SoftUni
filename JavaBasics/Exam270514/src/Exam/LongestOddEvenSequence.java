package Exam;

import java.util.Scanner;

public class LongestOddEvenSequence {

	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		String[] numbers = reader.nextLine().split("\\D+");
		int count = 0;
		int tempCount = 1;
		for (int i = 1; i < numbers.length; i++) {
			if (i != numbers.length - 1) {
				if (Integer.parseInt(numbers[i]) % 2 == 0 || Integer.parseInt(numbers[i]) == 0) {
					if (Integer.parseInt(numbers[i + 1]) % 2 != 0 || Integer.parseInt(numbers[i + 1]) == 0) {
						tempCount++;
						if (tempCount > count) {
							count = tempCount;
						}
						continue;
					}
				}
				if (Integer.parseInt(numbers[i]) % 2 != 0 || Integer.parseInt(numbers[i]) == 0) {
					if (Integer.parseInt(numbers[i + 1]) % 2 == 0 || Integer.parseInt(numbers[i + 1]) == 0) {
						tempCount++;
						if (tempCount > count) {
							count = tempCount;
						}
						continue;
					}
				}
				else {
					tempCount = 1;
				}
			}			
		}
		System.out.println(count);
	}

}
