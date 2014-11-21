package homework;
import java.util.Scanner;

public class RectangleArea {
	
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		while (true) {
			System.out.print("Enter a: ");
			int a = reader.nextInt();
			System.out.print("Enter b: ");
			int b = reader.nextInt();
			System.out.print("Area: ");
			System.out.println(a*b);	
			System.out.println("=============");
		}
	}
}