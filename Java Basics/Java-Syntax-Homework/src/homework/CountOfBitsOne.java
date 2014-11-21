package homework;
import java.util.Scanner;

public class CountOfBitsOne {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter an integer: ");
			int n = reader.nextInt();
			int count = 0;
			for (int i = 0; i < 32; i++) {
				int bit = n & 1;
				if (bit == 1) {
					count++;
				}
				n = n>>1;
			}
			System.out.print("Ones: ");
			System.out.println(count);
			System.out.println("==================");
		}
	}
}