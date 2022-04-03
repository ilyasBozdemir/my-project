
package tekrarlar;
import java.util.Scanner;
public class soru3Final {
    public static void main(String[] args) {
        // kulanıcı tarafından girilen iki sayıya dört işlme yaptıran
        //program kodlayınız.
        Scanner giris = new Scanner (System.in) ;
        System.out.print("Birinci Sayıyı Giriniz :");
        int a =giris.nextInt();
        System.out.print("İkinci Sayıyı Giriniz :");
        int b =giris.nextInt();
        System.out.print("Yapmak istediğiniz işlemi seciniz"
                + "\n1.Toplama\n2.Cıkarma\n3.Carpma\n4.Bölme :\n");
        int Toplama = soru3.soru3_islem.toplama(a, b);
        int Cıkarma = soru3.soru3_islem.cıkarma(a, b);
        int Carpma = soru3.soru3_islem.carpma(a, b);
        double Bolme =  soru3.soru3_islem.bolme(a, b);
        
         int secim = giris.nextInt();
        switch(secim){
          case 1 : System.out.println("Toplama Sonucu :"+ Toplama  ); break ;
          case 2 : System.out.println("Cıkarma Sonucu :"+ Cıkarma); break ;
          case 3 : System.out.println("Carpma Sonucu :"+ Carpma ); break ;
          case 4 : System.out.println("Bölme Sonucu :"+  Bolme ); break ;
            
        }
            
    }
}
        
      
