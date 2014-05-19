import java.math.BigDecimal;
import java.util.Locale;
import java.util.Scanner;

public class PointInsideOfFigure {

	public static void main(String[] args){
		
		Locale.setDefault(Locale.ROOT);
		Scanner reader = new Scanner(System.in);
		while(true){
			
			System.out.print("Enter coordinates: ");
			BigDecimal pX = reader.nextBigDecimal();
			BigDecimal pY = reader.nextBigDecimal();
			boolean isInsideFirst = firstRectangle(pX, pY);
			if (isInsideFirst) {				
				System.out.println("Inside");
			}
			else {				
				boolean isInsideSecond = secondRectangle(pX, pY);
				if (isInsideSecond) {					
					System.out.println("Inside");
				}
				else {					
					boolean isInsideThird = thirdRectangle(pX, pY);
					if (isInsideThird) {
						System.out.println("Inside");
					}
					else {
						System.out.println("Outside");
					}
				}
			}
			System.out.println("=================");
		}
	}
	
	private static BigDecimal triangleArea(BigDecimal aX, BigDecimal aY, BigDecimal bX, BigDecimal bY, BigDecimal cX, BigDecimal cY){
		
		BigDecimal bg0,bg1, bg2, bg3, bg4, bg5, bg6, bg7, bg8, bg9;
		bg0 = new BigDecimal("2.0");
		bg1 = bY.subtract(cY);
		bg2 = aX.multiply(bg1);
		bg3 = cY.subtract(aY);
		bg4 = bX.multiply(bg3);
		bg5 = aY.subtract(bY);
		bg6 = cX.multiply(bg5);
		bg7 = bg2.add(bg4);
		bg8 = bg7.add(bg6);
		bg9 = bg8.divide(bg0);
		BigDecimal area = bg9.abs();
		return area;
	}
	
	private static boolean firstRectangle(BigDecimal pX, BigDecimal pY){
		
		BigDecimal aX, aY, bX, bY, cX, cY, dX, dY, sum, area;
		area = new BigDecimal("25.0");
		aX = new BigDecimal("12.5");
		aY = new BigDecimal("6.0");
		bX = new BigDecimal("22.5");
		bY = new BigDecimal("6.0");
		cX = new BigDecimal("22.5");
		cY = new BigDecimal("8.5");
		dX = new BigDecimal("12.5");
		dY = new BigDecimal("8.5");
		BigDecimal triangleAPD = triangleArea(aX, aY, pX, pY, dX, dY);
		BigDecimal triangleDPC = triangleArea(dX, dY, pX, pY, cX, cY);
		BigDecimal triangleCPB = triangleArea(cX, cY, pX, pY, bX, bY);
		BigDecimal trianglePBA = triangleArea(pX, pY, bX, bY, aX, aY);
		sum = triangleAPD.add(triangleDPC);
		sum = sum.add(triangleCPB);
		sum = sum.add(trianglePBA);
		int result = sum.compareTo(area);
		if (result == 0) {

			return true;
		}
		return false;
	}
	
	private static boolean secondRectangle(BigDecimal pX, BigDecimal pY){
			
		BigDecimal aX, aY, bX, bY, cX, cY, dX, dY, sum, area;
		area = new BigDecimal("25.0");
		aX = new BigDecimal("12.5");
		aY = new BigDecimal("8.5");
		bX = new BigDecimal("17.5");
		bY = new BigDecimal("8.5");
		cX = new BigDecimal("17.5");
		cY = new BigDecimal("13.5");
		dX = new BigDecimal("12.5");
		dY = new BigDecimal("13.5");
		BigDecimal triangleAPD = triangleArea(aX, aY, pX, pY, dX, dY);
		BigDecimal triangleDPC = triangleArea(dX, dY, pX, pY, cX, cY);
		BigDecimal triangleCPB = triangleArea(cX, cY, pX, pY, bX, bY);
		BigDecimal trianglePBA = triangleArea(pX, pY, bX, bY, aX, aY);
		sum = triangleAPD.add(triangleDPC);
		sum = sum.add(triangleCPB);
		sum = sum.add(trianglePBA);
		int result = sum.compareTo(area);
		if (result == 0) {

			return true;
		}
		return false;
	}
	
	private static boolean thirdRectangle(BigDecimal pX, BigDecimal pY){
		
		BigDecimal aX, aY, bX, bY, cX, cY, dX, dY, sum, area;
		area = new BigDecimal("12.5");
		aX = new BigDecimal("20.0");
		aY = new BigDecimal("8.5");
		bX = new BigDecimal("22.5");
		bY = new BigDecimal("8.5");
		cX = new BigDecimal("22.5");
		cY = new BigDecimal("13.5");
		dX = new BigDecimal("20.0");
		dY = new BigDecimal("13.5");
		BigDecimal triangleAPD = triangleArea(aX, aY, pX, pY, dX, dY);
		BigDecimal triangleDPC = triangleArea(dX, dY, pX, pY, cX, cY);
		BigDecimal triangleCPB = triangleArea(cX, cY, pX, pY, bX, bY);
		BigDecimal trianglePBA = triangleArea(pX, pY, bX, bY, aX, aY);
		sum = triangleAPD.add(triangleDPC);
		sum = sum.add(triangleCPB);
		sum = sum.add(trianglePBA);
		int result = sum.compareTo(area);
		if (result == 0) {

			return true;
		}
		return false;
	}
}
