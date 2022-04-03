package hesaplar;
public class kodlar {
  
    public static void main(String[] args) {
        
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
         
    }
}
