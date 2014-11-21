package homework;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class MostFrequentWord {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter text: ");
			String[] words =  reader.nextLine().toLowerCase().split("\\W+");
            TreeMap<String, Integer> wordsCount = new TreeMap<>();
           
            int maxCount = 0;
            for (String word : words) {
                Integer count = wordsCount.get(word);
                if (count == null) {
                        count = 0;
                }
                if (count + 1 > maxCount) {
                	maxCount = count + 1;
                }
                wordsCount.put(word, count + 1);
            }
            System.out.println("Result: ");
            for (Map.Entry<String, Integer> entry : wordsCount.entrySet()) {
                if (entry.getValue() == maxCount) {
                        System.out.println(entry.getKey() + " -> " + maxCount + " times");
                }
            }
            System.out.println("=============================");
		}
	}
}
