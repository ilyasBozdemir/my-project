
package tekrarlar;
import java.util.Scanner;
public class uyg14 {
    public static void main(String[] args) {
       Scanner tara = new Scanner (System.in);
       int x,y,z ;
       System.out.print("x kenarını giriniz :");
       x = tara.nextInt();
       System.out.print("y kenarını giriniz :");
       y = tara.nextInt();
       System.out.print("z kenarını giriniz :");
       z = tara.nextInt();
       // karsılastırma ifadeleri
       if (x == y && y==z ) {
           System.out.print("Üçgenimiz Eşkenar Üçgendir.");
          
       }
       else if (x!=y && y!=z ) {
           System.out.print("Üçgenimiz Çeşitkenar Üçgendir.");
       }
       else 
           System.out.print("Üçgenimiz İkizkenar Üçgendir.");
           
    }
}
