package Exam;

import java.util.Scanner;
import java.util.Map;
import java.util.TreeMap;

public class CountBeers {

	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		String[] input = new String[999];
		for (int i = 0; i < input.length; i++) {
			String line = reader.nextLine();
			if (line.equals("End")) {
				input[i] = line;
				break;
			} else {				
				input[i] = line;
			}
		}

        TreeMap<String, Integer> beers = new TreeMap<>();
		for (int i = 0; i < input.length; i++) {
			Integer count = beers.get(input[i].split(" ")[1]);
			if (count == null) {
				count = 0;
			}
			else {
				
			}
		}
	}
}
