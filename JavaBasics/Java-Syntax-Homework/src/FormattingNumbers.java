import java.util.Locale;
import java.util.Scanner;

public class FormattingNumbers {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter 3 numbers: ");
			int a = reader.nextInt();
            double b = reader.nextDouble();
            double c = reader.nextDouble();
           
            String aHexString = Integer.toHexString(a).toUpperCase();
            String aBinary = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
           
            if (c%1 == 0) {
                    System.out.printf("|%-10s|%s|%10.2f|%-10.0f|",aHexString,aBinary,b,c);
                    System.out.println();
            }else {
                    System.out.printf("|%-10s|%s|%10.2f|%-10.3f|",aHexString,aBinary,b,c);
                    System.out.println();
            }
            System.out.println("=============================================");
		}
	}
}