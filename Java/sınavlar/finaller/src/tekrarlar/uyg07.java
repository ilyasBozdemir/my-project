
package tekrarlar;
import java.util.Scanner;
public class uyg07 {
    public static void main(String[] args) {
         byte [] yazili = new byte[10];
         byte [] sozlu = new byte[10];
        yazili[0]=85;
        yazili[1]=78; 
        yazili[2]=90;        
        yazili[3]=75;        
        yazili[4]=60;       
        yazili[5]=50;        
        yazili[6]=80;        
        yazili[7]=70;       
        yazili[8]=65;       
        yazili[9]=60; 
       
        sozlu[0]=80;
        sozlu[1]=90;        
        sozlu[2]=75;        
        sozlu[3]=65;        
        sozlu[4]=85;        
        sozlu[5]=70;        
        sozlu[6]=60;       
        sozlu[7]=65;        
        sozlu[8]=85;        
        sozlu[9]=70;
        
        System.out.println("4.Öğrencinin yazılı notu="+yazili[3]);       
        System.out.println("8.Öğrencinin sözlü notu="+sozlu[7]);
    }
}
