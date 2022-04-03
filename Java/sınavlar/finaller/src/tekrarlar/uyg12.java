
package tekrarlar;
import java.util.Scanner;
public class uyg12 {
    public static void main(String[] args) {
         Scanner giris = new Scanner(System.in);
        int secim;

        System.out.print("Secim yapiniz (1 - 2 - 3) :");
        secim=giris.nextInt();

        switch (secim) {
        case 1 :
            System.out.println("A sinifi dergilerin listesi");
            break;

        case 2 :
            System.out.println("B sinifi dergilerin listesi");
            break;

        case 3 :
            System.out.println("C sinifi dergilerin listesi");
            break;

        default :
            System.err.println("Hatali secim! 1, 2 ya da 3'e basiniz.");
            break;
        }
    }
}
