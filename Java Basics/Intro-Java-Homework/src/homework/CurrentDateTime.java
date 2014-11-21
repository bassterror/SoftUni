package homework;
import java.time.LocalDateTime;

public class CurrentDateTime {

	public static void main(String[] args) {
		LocalDateTime lDateTime = LocalDateTime.now();
        System.out.println(lDateTime);
	}
}