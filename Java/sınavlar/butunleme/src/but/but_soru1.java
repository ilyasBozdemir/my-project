
package but;
import java.util.Scanner;
public class but_soru1 {
    public static void main(String[] args) {
      Scanner giris = new Scanner (System.in);
      System.out.print("Birinci Sayıyı Giriniz :");
      int a =  giris.nextInt();
      System.out.print("Birinci Sayıyı Giriniz :");
      int b =  giris.nextInt();
       int  sonuc1,sonuc2 ;
       sonuc1=a-b;
       sonuc2=(a-b)*(-1);
       if (a>b) 
        {
        System.out.println("Mutlak Değer Farkı :"+sonuc1);
        }
       else
        {
        System.out.println("Mutlak Değer Farkı :"+sonuc2);
        }
      
     
        
    }
}
