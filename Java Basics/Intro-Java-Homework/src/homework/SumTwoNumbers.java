package homework;
import java.util.Scanner;

public class SumTwoNumbers {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
        int a = reader.nextInt();
        int b = reader.nextInt();
        System.out.println(a+b);
	}
}