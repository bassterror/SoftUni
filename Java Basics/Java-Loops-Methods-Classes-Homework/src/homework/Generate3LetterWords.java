package homework;
import java.util.Scanner;

public class Generate3LetterWords {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter charecter: ");
			char[] charecter = reader.next().toCharArray();
			for(int a = 0; a < charecter.length; a++){
                for(int b = 0;b < charecter.length; b++){
                        for (int c = 0; c < charecter.length; c++) {
                                System.out.printf("%s%s%s ",charecter[a],charecter[b],charecter[c]);
                        }
                }
			}
			System.out.println();
	        System.out.println("================================================");
		}        
	}
}
