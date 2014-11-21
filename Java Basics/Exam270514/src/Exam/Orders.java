package Exam;

import java.util.Arrays;
import java.util.Scanner;
import java.util.Map;
import java.util.TreeMap;

public class Orders {

	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		int n = reader.nextInt();
		String[] lines = new String[n + 1];
		String[] edit = new String[n];
		String[] products = new String[n];
		String[] customers = new String[n];
		TreeMap<String, Integer> productsCount = new TreeMap<>();
		TreeMap<String, Integer> customersCount = new TreeMap<>();
		for (int i = 0; i <= n; i++) {
			lines[i] = reader.nextLine();
		}
		for (int i = 1; i < lines.length; i++) {
			String[] temp = lines[i].split(" ");
			edit[i - 1] = temp[2] + " " + temp[0] + " " + temp[1];
			products[i - 1] = temp[2];
			customers[i - 1]= temp[0];
		}
		Arrays.sort(edit);
		for (String product : products) {
			Integer count = productsCount.get(product);
			if (count == null) {
				count = 0;
			}
			productsCount.put(product, count + 1);
		}
		for (String cusomer : customers) {
			Integer count = customersCount.get(cusomer);
			if (count == null) {
				count = 0;
			}
			customersCount.put(cusomer, count + 1);
		}
		for (Map.Entry<String, Integer> entry : productsCount.entrySet()) {
			System.out.printf("%s: ", entry.getKey());
			boolean first = true;
			for (Map.Entry<String, Integer> entryC : customersCount.entrySet()) {
				int value = 0;
				for (int i = 0; i < edit.length; i++) {
					String[] temp = edit[i].split(" ");
					if (temp[0].equals(entry.getKey())) {
						if (temp[1].equals(entryC.getKey())) {
							value += Integer.parseInt(temp[2]);
						}
					}		
				}
				if (first) {
					if (value != 0) {
						System.out.printf("%s ", entryC.getKey());
						System.out.print(value);
						first = false;
					}
				}
				else {
					if (value != 0) {
						System.out.printf(", %s ", entryC.getKey());
						System.out.print(value);
					}
				}
			}			
			System.out.println();
		}
	}
}
