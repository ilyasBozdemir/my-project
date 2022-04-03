
package Kodlar;
import java.util.Scanner;
public class Uygulama {
   
    
    static void Adsoyad () {
        Scanner bilgi = new Scanner (System.in);
      System.out.print("Ad Soyad Giriniz: ");
      String isim = bilgi.nextLine();
      System.out.print("Merhaba :" ); 
    }
    
    
    public static void main(String[] args) {
        Adsoyad(); 
    }
       
        
       
   
 
    
}
