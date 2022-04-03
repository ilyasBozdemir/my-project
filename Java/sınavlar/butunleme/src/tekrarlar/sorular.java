
package tekrarlar;
import java.util.Scanner;
public class sorular {
    /*Kullanıcı tarafından girilen 1-5 arası sayı tahmini yapan program
    kodlayınız.  */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner bilgi = new Scanner (System.in);
        System.out.println("1-5 Arası Sayıyı Tahmin Giriniz :");
        int sayi =bilgi.nextInt();
        
        if (sayi==4) {
            System.out.print("Tebrikler Bildiniz! ");
        }
        else if (sayi<=5){
        System.out.print("Bilemediniz Tekrar deneyin. ");
    }
        else {
            
           System.err.println("1-5 Arası Değer Girin\nTekrar Deneyin ");
        }
    }
    
}
