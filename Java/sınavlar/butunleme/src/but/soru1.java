
package but;

public class soru1 {
    public static void main(String[] args) {
     //iki sayıyın mutlak farkını alan program kodlayınız.
     //iki tane değişken tanımlıyoruz. int veri tipinde sayı yüksek de olabilir.
     int a=7 , b=3;
     //sonucu mutlak değer olması için pozitif cıkması lazım onun için 
     //iki durumda değerlendirilir.ilk sayı ikinci sayıdan küçük olursa negatif 
     //cıkar onun içi if else kullanrark durumu çözebiliriz
     int  sonuc1,sonuc2 ; //sonuc nesnesini int veri tipine atadık 
     
    sonuc1=a-b; // a'nın büyük olduğu durum 
    sonuc2=(a-b)*(-1);// b'nin büyük olduğu durum
    // -1 ile carmamızın nedeni pozitif cıkması içindir
     if (a>b) // if içindeki önerme true olursa calısır
     {
        System.out.println(sonuc1);//a b'den buyuk oldugu zaman pozitif cıkacagı
        //için sonuç böyle yaptık.
     } 
     else // ifdeki sartlar dısında calısır
     {
         System.out.println(sonuc2);
     }
        
         
    }    
             
   
    
}