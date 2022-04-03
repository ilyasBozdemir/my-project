package Progtem;
import java.util.Scanner;
public class kosul02 {
    public static void main(String[] args) {
        byte sayi = 5;
        switch (sayi) {
            case 1 :
                System.out.println("SAYI 1'dir.");
                break;
            case 2 :
                System.out.println("SAYI 2'dir.");
                break;
            case 3 :
                System.out.println("SAYI 3'tür.");
                break;
            case 4 :
                System.out.println("SAYI 4'tür.");
                break;
            case 5 :
                System.out.println("SAYI 5'tir."); 
                break;
            default ;
                 System.err.println("SAYI 0-5 aralığında değildir."); 
                break;
           }
        }
        
    }

