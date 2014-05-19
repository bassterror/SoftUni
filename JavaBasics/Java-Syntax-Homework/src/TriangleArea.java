import java.util.Locale;
import java.util.Scanner;

public class TriangleArea {
	
	public static void main(String[] args){

		Locale.setDefault(Locale.ROOT);
		Scanner reader = new Scanner(System.in);
		while(true){
			System.out.print("Enter coordinates of point A: ");
			double aX = reader.nextDouble();
			double aY = reader.nextDouble();
			System.out.print("Enter coordinates of point B: ");
			double bX = reader.nextDouble();
			double bY = reader.nextDouble();
			System.out.print("Enter coordinates of point C: ");
			double cX = reader.nextDouble();
			double cY = reader.nextDouble();
			int area = Math.abs((int) (((aX*(bY - cY))+(bX*(cY-aY))+(cX*(aY-bY)))/2));
			System.out.println("Area: " + area);
		}
	}
}
