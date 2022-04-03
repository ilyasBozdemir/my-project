
package tekrarlar;
import java.util.Scanner;
public class uyg02 {
    public static void main(String[] args) {
        Scanner sayi = new Scanner(System.in);
        System.out.println("1.Sayıyı Giriniz :");
        int sayi1 = sayi.nextInt();
        System.out.println("2.Sayıyı Giriniz :");
        int sayi2 = sayi.nextInt();
        
        System.out.println("Girilen Sayılar :"+ sayi1 + ","+ sayi2 ); 
    }
}
