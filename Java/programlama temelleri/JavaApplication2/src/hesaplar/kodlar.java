package hesaplar;
public class kodlar {
  
    public static void main(String[] args) {
        /* Kenar uzunlukları kullanıcı tarafından girilen bir
        dikdörtgenin alanını ve cevresini hesaplayarak ekrana yzdıran programı 
        kodlayınız.
        NOT: Hespalamalar farklı bir paketteki bir sınıf içerisnde yapılcaktır.
        */ 
        Scanner bilgi= new Scanner(System.in);
        System.out.print("Birinci Kenarı Giriniz :");
        int a= bilgi.nextInt();
        System.out.print("İkinci Kenarı Giriniz :");
        int b= bilgi.nextInt();
      // Dikdörtgen kontrolü 
        if  ((a==b) || a<=0 || b<=0 ) {
            System.err.println("Kenar uzunlularını aynı girdiniz\n"
            +"Kenar uzunlukları aynı olursa kare olur."
            +"\n\nProgram Sonlandırıldı.. !");
            
        }
        else  {
          System.out.println("Kenar uzunlukları :" + a + "," + b);
          System.out.println("Alanı :" + islemlerr. 
          System.out.println("Çevresi :" + islemlerr.
        }
    }
}
