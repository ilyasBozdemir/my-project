/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package deneme;

/**
 *
 * @author İLYAS
 */
public class deneme01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
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
        
        System.out.println("4.Öğrencinin yazıl notu="+yazili[3]);       
        System.out.println("8.Öğrencinin sözlü notu="+sozlu[7]);
          // 5 isim yazıp 5.yi ekrana yazdıralım
          String [] isimler = new String[5];
        isimler[0]="İlyas bozdemir";
        isimler[1]="Aysel Gün";       
        isimler[2]="koriş Sümer";       
        isimler[3]="yağmur Çetin";       
        isimler[4]="Ramazan Optik";
         System.out.println("5.kişinin adı soyadı="+isimler[3]);
         
          String [] Akdeniz = new String[5];
           String [] Anadolu = new String[5];
           String [] Karadeniz  =new  String[5];
           
           Akdeniz[0]="Antalya";
           Akdeniz[1]="Mersin";     
           Akdeniz[2]="Isparta";        
           Akdeniz[3]="Adana";        
           Akdeniz[4]="Hatay";
           
           Anadolu[0]="Konya";
           Anadolu[1]="Ankara";
           Anadolu[2]="Sivas";        
           Anadolu[3]="Kayseri";        
           Anadolu[4]="Yozgat";
           
           Karadeniz[0]="Rize";
           Karadeniz[1]="Trabzon";       
           Karadeniz[2]="Samsun";       
           Karadeniz[3]="Ordu";       
           Karadeniz[4]="Zonguldak";
           System.out.println("Akdeniz Bölgesinin 3.İli="+Akdeniz[2]);
           System.out.println("İç Anadolu Bölgesinin 3.İli="+Anadolu[2]);      
           System.out.println("Karadeniz Bölgesinin 3.İli="+Karadeniz[2]);       
                
          
           
             String [][] IllerIlceler = new String[3][2];
             IllerIlceler[0][0] ="Ermenek"; //Karaman'ın İlçeleri
             IllerIlceler[0][1] ="Sarıveliler";//Karaman'ın İlçeleri
             IllerIlceler[1][0] ="Tarsus";//Mersin'in İlçeleri
             IllerIlceler[1][1] ="Anamur";//Mersin'in İlçeleri
             IllerIlceler[2][0] ="Meram";//Konya'nın İlçeleri
             IllerIlceler[2][1] ="Selçuklu";//Konya'nın İlçeleri 
             //Konya ilinin İlçelerini ekrana Yazdıralım
             System.out.println("Konya'nın İlçeleri:"+IllerIlceler[2][0]+","+
             IllerIlceler[2][1]);
        
        
        
        
    }
    
}
