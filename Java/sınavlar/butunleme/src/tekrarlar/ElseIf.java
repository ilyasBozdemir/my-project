
package tekrarlar;

public class ElseIf {
    public static void main(String[] args) {
        //örnek 
        int puan = 85;
        char sonuc ;
        if (puan >=88 ) {
            sonuc = 'A' ;
            
        }
        else  if (puan <=90 ) {
            sonuc = 'B' ;
            /* C secenegi kesin olmasına ragmen sartları saglayan ilk 
            kod blogu calısır */
        }
        else if (puan >=85 ) {
            sonuc = 'C' ;
            
        }
        else  {
            sonuc = 'D' ;
            
        }
        System.out.println("sonuc: " + sonuc);
             
        
    }
}
