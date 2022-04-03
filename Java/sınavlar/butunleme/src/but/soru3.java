
package but;
import java.util.Scanner;
public class soru3 {
    public static void main(String[] args) {
     Scanner giris = new Scanner(System.in);
     System.out.print("Birinci Sayıyı Girin :");
     int a= giris.nextInt();
     System.out.print("İkinci Sayıyı Girin :");
     int b= giris.nextInt();
     // but_islem paketinden soru3_islem sınıfını cagıralım ve bir degiskene 
     //atayalım
     int sonuc =but_islem.soru3_islem.denklem(a, b);
     int sonuc2=but_islem.soru3_islem.denklem2(a, b);
     System.out.println("İşlem sonucu :"+sonuc+","+sonuc2);
     
     // tamamdır bu kadar sonuc
     
     
    
  

    }
}
