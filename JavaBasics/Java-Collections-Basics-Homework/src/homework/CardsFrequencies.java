package homework;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class CardsFrequencies {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter cards: ");
			String[] input = reader.nextLine().split("[ ♥♣♦♠]+");
			Map<String, Integer> cards = new LinkedHashMap<String, Integer>();
			for (String card : input) {
			    Integer count = cards.get(card);
			    if (count == null) {
				count = 0;
			    }
			    cards.put(card, count + 1);
			}
			for (Map.Entry<String, Integer> entry : cards.entrySet()) {
			    double precentage = (double) entry.getValue() * 100 / input.length;
			    System.out.printf("%s -> %.2f%%\n", entry.getKey(), precentage);
			}
			System.out.println("==========================");
		}

	}

}
