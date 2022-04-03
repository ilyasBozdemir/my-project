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
