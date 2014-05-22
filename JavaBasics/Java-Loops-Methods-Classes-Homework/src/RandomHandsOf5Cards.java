import java.util.Random;
import java.util.Scanner;

public class RandomHandsOf5Cards {

	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);        
        Random random = new Random();
		String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K","A"};
        String[] suits = {"♣", "♦", "♥", "♠" };
		while (true) {
			System.out.print("Enter number of hands: ");
			int count = reader.nextInt();	
	        for(int i = 0; i < count; i++){
	        	String[] card1 = {cards[random.nextInt(13)],suits[random.nextInt(4)]};
	        	String[] card2 = {cards[random.nextInt(13)],suits[random.nextInt(4)]};
	        	String[] card3 = {cards[random.nextInt(13)],suits[random.nextInt(4)]};
	        	String[] card4 = {cards[random.nextInt(13)],suits[random.nextInt(4)]};
	        	String[] card5 = {cards[random.nextInt(13)],suits[random.nextInt(4)]};
	        	if (card1 != card2 && card1 != card3 && card1 != card4 && card1 != card5) {
					if (card2 != card3 && card2 != card4 && card2 != card5) {
						if (card3 != card4 && card3 != card5) {
							if (card4 != card5) {
								System.out.printf("%s %s %s %s %s%n", card1, card2, card3, card4, card5);
							}
				        	else {
								i--;
								continue;
							}
						}
			        	else {
							i--;
							continue;
						}
					}
					else {
						i--;
						continue;
					}
				}
	        	else {
					i--;
					continue;
				}
	        	
	        }
	        System.out.println("========================");
		}
	}
}
