
package javaapplication10;
import java.util.Scanner;
public class JavaApplication10 {

    public static void main(String[] args) {
      Scanner Gun = new Scanner(System.in);
      int gunler;
      
      gunler=Gun.nextInt();
        
      
           
            switch(gunler){
            case 1:
                  System.out.println("Pazartesi");              
            case 2:
                  System.out.println("Sali");
            case 3:
                  System.out.println("Çarsamba");
            case 4:
                  System.out.println("Persembe");
            case 5:
                  System.out.println("Cuma");
            case 6:
                  System.out.println("Cumartesi");
            case 7:                
                  System.out.println("Pazar");
            
           default :
            System.err.println("Hatali secim! 1-7 sayý kullanýnýz.");
            break;
        }
       
    }
    
}
