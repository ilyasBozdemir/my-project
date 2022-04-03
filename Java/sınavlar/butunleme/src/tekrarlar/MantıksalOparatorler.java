
package tekrarlar;

public class MantıksalOparatorler {
    public static void main(String[] args) {
        // Mantıksal oparatorler 
        // AND-OR-XOR-NOT 
    // örnegimizde oparatorleri inceleyelim
    boolean x =true ;
    boolean y =false ; 
    boolean z =true ;
    boolean t =false ;
    //AND Oparatoru(&&)
    //Bu oparorun sağındaki ve solunda ki ifade true ise sonuç true olur.
    //Diğer tüm durumlarda sonuç false olur.
    System.out.println("x && y :" + (x && y)  );//false olmalı.
    System.out.println("x && z :" + (x && z)  );//true olmalı.
    //OR Oparatoru (||)
    //Bu oparorun sağındaki ve solunda ki ifade false ise sonuç false olur.
    //Diğer tüm durumlarda sonuç true olur.
    System.out.println("t || y :" + (t || y)  );//false olmalı.
    System.out.println("x || y :" + (x || y)  );//true olmalı.
    //XOR Oparatoru (^)--özel or Oparatoru
    //Bu oparorun sağındaki ve solunda ki ifade aynı ise sonuç false olur.
    System.out.println("x ^ y :" + (x ^ y)  );//true olmalı.
    System.out.println("x ^ z :" + (x ^  z)  );//false olmalı.
    //NOT opatratoru
    //Bu oparator kendisindenn sonra gelen ifadenin ters halini alır. 
    // True ise ise false , false  ise true değerini verir.
    System.out.println("!x :" + ( !x ) );//false olmalı.
    System.out.println("!y :" + (!y)  );//false olmalı.
    
    
    
    
    
    
        
    }
}
