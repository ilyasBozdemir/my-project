
package tekrarlar;

public class SwitchCase {
    public static void main(String[] args) {
        // haftanın günlerini sorguyalım
        //haftanın 5. günün sorguyalım.
        //doğru bulunca uygulamadan cıkılır.
        int hafta = 5 ;
        switch(hafta){
            case 1: System.out.println("Pazartesi"); break ;
            case 2: System.out.println("Salı"); break ;
            case 3: System.out.println("Çarşamba"); break ;
            case 4: System.out.println("Perşembe"); break ;
            case 5: System.out.println("Cuma"); break ;
        }
        System.out.println();
        // break deyimini kaldırıp deneyelim
        int hafta2 = 4 ;
        switch(hafta2){
            case 1: System.out.println("Pazartesi");  
            case 2: System.out.println("Salı");  
            case 3: System.out.println("Çarşamba");
            case 4: System.out.println("Perşembe");
            case 5: System.out.println("Cuma");
            // persembeden itibaren calısır break deyimi asla unutulmamalıdır.
        }
        int hafta3 = 8 ;
        switch(hafta3){
            case 1: System.out.println("Pazartesi"); break ;
            case 2: System.out.println("Salı"); break ;
            case 3: System.out.println("Çarşamba"); break ;
            case 4: System.out.println("Perşembe"); break ;
            case 5: System.out.println("Cuma"); break ;
            case 6: System.out.println("Cumartesi"); break ;
            case 7: System.out.println("Pazar"); break ;
            default : System.out.println("hiçbir kosul saglanmıyor"); break ;
        }
    }
}
   
     