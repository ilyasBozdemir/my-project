
package tekrarlar;
import java.util.Scanner;

public class uyg13 {
    public static void main(String[] args) {
        /* Kenar uzunluklarının kullanıcı tarafından girilen bir
        dikdörtgenin alanını ve cevresini hesaplayarak ekrana yazdıran program
        kodlayınız.
        NOT: Hesaplamalar farklı bir paketteki bir sınıf içersinde yapılacaktır.
        */ 
        Scanner bilgi = new Scanner (System.in);
        System.out.print("Birinci Kenarı Giriniz :");
        int a = bilgi.nextInt();
        System.out.print("İkinci Kenarı Giriniz :");
        int b = bilgi.nextInt();
        // Dikdörtgen kontrolü
        if ((a == b) || a<=0 || b<=0 ) {
            System.err.println("Kenar uzunulukarını aynı girdiniz.\n"
                    + "Kenar uzunlukları aynı olursa kare olur.\n\n"
                    + "Program sonlandırıldı...!");   
        }
          else  {
          System.out.println("Kenar uzunlukları :" + a + "," + b);
          System.out.println("Alanı :" + uyg013.alan(a, b));
          System.out.println("çevresi :" + uyg013.cevre(a, b));
        }
       
               
        
    }
 
}
