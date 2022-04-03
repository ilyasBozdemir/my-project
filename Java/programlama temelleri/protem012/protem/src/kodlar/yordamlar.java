
package Kodlar;
import java.util.Scanner;
public class yordamlar{
    static void ekranayaz () {
    /*  System.out.println("Merhaba");
      System.out.println("Gardaş"); 
      System.out.println("Nasılsın?"); 
    } */
     


    static void metinyaz() {
        Scanner bilgi = new Scanner(System.in);
        System.out.print("Yazdırmak istediğiniz metin : ");
        String metin = bilgi.nextLine();
        System.out.print("Kaç defa yazdırmak istiyorsunuz?. ");
        int KacDefa =bilgi.nextLine();
        for(int i=1;i<=KacDefa;i++ ){
          System.out.print(i +"," +metin );  
        }
   
                  }
public static void main(String[] args) {
    /* */
        metinyaz();
        
      
    }
    
}
