
package tekrarlar;

public class If {
    public static void main(String[] args) {
        /* Tek seçimli yapı olarak ifade edilir.
        kosul "dogru" ise işlem yapar "yanlış" ise işlem yapmaz 
         */ 
        // Birden fazla önermeyi bir "if" Cümleciğinde birleştirme 
        // örnek  yaş dogum tarihi doğru mu görelim 
        int yas = 25 ;
        int DogumTarihi = 1985;
        if (yas == 25 && DogumTarihi== 1985 ); {
        System.out.println("yazilanlar tamamıyla dogrudur...");
       } 
       if (yas == 25 || DogumTarihi== 1990 ); {
        System.out.println("yazilanlarin bir parcası dogrudur...");
    }
       
       
               
        
    }
  
}
