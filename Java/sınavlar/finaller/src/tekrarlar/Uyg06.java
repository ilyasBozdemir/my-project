
package tekrarlar;
import java.util.Scanner;
public class Uyg06 {
       static void bilgi (){
           Scanner girdi = new Scanner (System.in);
        System.out.print("Yazdırmak istediğiniz metni giriniz :");
        String metin = girdi.nextLine();
        System.out.print("Kaç defa yazdırmak istiyorsunuz ? :");
        int KacDefa = girdi.nextInt();
        for (int i=1; i<=KacDefa; i++ ) {
            System.out.println(i + "."+ metin );
        }
        
       }
       
     public static void main(String[] args) {
        /* ekrana yazdıralaak olan metnin ve kaç defa yazdırılacağının kullanıcı tarafından
  girildiği programı yordam kullanarak kodlayınız.
Not: Ana yordam içerisinde sadece hazırlanan yordam olacak.Diğer  tüm işlemler
içerisnde yapılacaktır. */
        bilgi();
        
        
    }
    
}
