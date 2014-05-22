
public class FullHouse {	
	
	public static void main(String[] args) {
		int count = 0;
		for(int card1 = 2; card1<= 14 ; card1++){
		    for(int card2 = 2; card2<=14 ; card2++){
	            if(card2 == card1) {
	            	continue;
	            }
	            for(int card1Suit = 1 ; card1Suit<=4 ; card1Suit++){
                    for(int card2Suit = card1Suit+1 ; card2Suit<=4; card2Suit++){
                        for(int card3Suit = card2Suit+1; card3Suit <=4 ; card3Suit++){
                            for(int card4Suit = 1; card4Suit <=4 ; card4Suit++){
                                for(int card5Suit = card4Suit+1 ; card5Suit<=4 ; card5Suit++){
                                    printCard(card1);
                                    printSuit(card1Suit);
                                    printCard(card1);
                                    printSuit(card2Suit);
                                    printCard(card1);
                                    printSuit(card3Suit);
                                    printCard(card2);
                                    printSuit(card4Suit);
                                    printCard(card2);
                                    printSuit(card5Suit);
                                    System.out.println();
                                    count++;
                                }
                            }
	                    }
                    }
	            }    
		    }
		}
		System.out.print("Full houses: ");
		System.out.println(count);
	}
	
	static void printCard(int n){
		 
	     if(n<=10) {
	    	 System.out.print(n);
	     }
	     else{
		     switch(n){
		     case 11: 
		    	 System.out.print("J");
				 break;
			 case 12: 
				 System.out.print("Q");
				 break;
			 case 13: 
				 System.out.print("K");
				 break;
			 case 14: 
				 System.out.print("A");
		    	 break;
		    }
	    }
	}

	static void printSuit(int suitNumber){
		char clubs = '♣';
		char diamonds = '♦';
		char hearts = '♥';
		char spades = '♠';
		switch(suitNumber){
			case 1: 
				System.out.print(clubs + " ");
				break;
			case 2: 
				System.out.print(diamonds + " ");
				break;
			case 3: 
				System.out.print(hearts + " ");
				break;
			case 4: 
				System.out.print(spades + " ");
				break;
		}
	}
}
