
package protem;
import java.util.Scanner;
public class uygulama02 {
    static void yazmetin(){
        Scanner bilgi = new Scanner (System.in);
        System.out.print("Yazdırmak istediğiniz metin : ");
        String metin = bilgi.nextLine();
        System.out.print("Kaç defa yazdırmak istiyorsunuz? :" );
        int KacDefa = bilgi.nextInt();
        for(int i=1;i<=KacDefa;i++){
        System.out.println(i+ "," + metin);
    }
        
    }
    
    public static void main(String[] args) {
     /* ekrana yazdıralaak olan metnin ve kaç defa yazdırılacağının kullanıcı 
        tarafından girildiği programı yordam kullnarak kodlayınız.
  Not: Ana yordam içerisinde sadece hazırlanan yordam olacak.Diğer  tüm işlemler
  içerisnde yapılacaktır. */
      yazmetin();
     /* Bilgi girişi */
      Scanner giris =new Scanner (System.in);
  int sayi ;
  System.out.print("Bir sayı giriniz:");
  sayi = giris.nextInt();
  System.out.println("Girdiğiniz Sayı :"+sayi);
    }
}
