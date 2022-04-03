package protem;
import java.util.Scanner;
public class uygulama03 {
     static void AdSoyad () {
      Scanner bilgi = new Scanner(System.in); 
    System.out.print("Ad Soyad Girin :");
    String metin = bilgi.nextLine();
    }
    
    public static void main(String[] args) {
     

    /* kullanıcıdan ad-soyad bilgisinin alındığı ve ekrana yazdırıldığı 
        uygulamayı yordam kullanarak yapınız. */ 
      AdSoyad();
    }
}