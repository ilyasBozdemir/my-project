
package hesaplar;
import java.util.Scanner ;
public class JavaApplication2 {


    public static void main(String[] args) {
        // TODO code application logic here
        Scanner uzunluk1= new Scanner(System.in);
        System.out.print("Birinci Kenarı Giriniz :");
        int kenar1= uzunluk1.nextInt();
        System.out.print("İkinci Kenarı Giriniz :");
        int kenar2= uzunluk1.nextInt();
        System.out.print("Üçüncü Kenarı Giriniz :");
        int kenar3= uzunluk1.nextInt();
        System.out.print("Dik Üçgeninin Alanı :"+ carp(kenar1,kenar2));
    }
         static int carp(int a, int b) {
             return (a*b)/2;
         }
        
    }
    

