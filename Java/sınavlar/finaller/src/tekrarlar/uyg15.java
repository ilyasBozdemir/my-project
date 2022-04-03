
package tekrarlar;
import java.util.Scanner ;
public class uyg15 {
    public static void main(String[] args) {
        Scanner tara = new Scanner (System.in);
        int  vize , finall ;
        double ortalama ;
        System.out.print("Vize notunu giriniz :");
        vize = tara.nextInt();
        System.out.print("Final notunu giriniz :");
        finall = tara.nextInt();
        ortalama = vize*0.4 + finall*0.6 ;
        System.out.print("Ortalama :" + ortalama);
        
                //ders geçme şartlarını belirleyelim
                if (ortalama >= 50) {
                    System.out.println("Öğrenci Dersi Geçmiştir.");
                    
                }
                else {
                    System.out.println("Öğrenci Derste Başarısızdır.");
                }
                
    }
}
