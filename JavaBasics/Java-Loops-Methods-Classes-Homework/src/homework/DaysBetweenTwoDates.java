package homework;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;

public class DaysBetweenTwoDates {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		SimpleDateFormat myFormat = new SimpleDateFormat("dd-MM-yyyy");
		while (true) {
			System.out.print("Enter first date: ");
			String firstInput = reader.nextLine();
			System.out.print("Enter second date: ");
			String secondInput = reader.nextLine();
			try{
				Date firstDate = myFormat.parse(firstInput);
				Date secondDate = myFormat.parse(secondInput);
				long diff = secondDate.getTime() - firstDate.getTime();
				System.out.println("Days between: " + TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS));
			} 
			catch (java.text.ParseException e) {				
				e.printStackTrace();
			}
			System.out.println("=======================");
		}	
	}
}