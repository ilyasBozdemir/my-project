
package Kodlama;
import java.util.Scanner;
public class Ucgen_kontrol {
    public static void main(String[] args) {
        
    
    Scanner input = new Scanner (System.in);
    int x,y,z ;
    System.out.print("x Kenarını Giriniz :");
     x = input.nextInt();
    System.out.print("y Kenarını Giriniz :");
     y = input.nextInt();
    System.out.print("z Kenarını Giriniz :");
     z = input.nextInt();
    if (x==y && y==z) //true durumda calısır
    {
         System.out.println("Üçgenimiz Eşkenar'dir.");
    }
    else if (x!=y && y!=z && x!=z) //false durumda calısır
    {
         System.out.println("Üçgenimiz Çeşitkenar'dır");
    }
    else 
    {
         System.out.println("Üçgenimiz İkizkenar'dır.");
    }
    
   } 
}
