package oparatörler;
public class opr {
 public static void main(String[] args) {
        // 1.a)Aritmetik Oparatörler 
        double s1=2, s2=5;
 System.out.println("Toplam :"+ (s1 + s2));
 System.out.println("Fark :"+ (s1 - s2));
 System.out.println("Çarpma :"+ (s1 * s2));
 System.out.println("Bölme :"+ (s2 / s1));
 //Aritmetik Azaltma-Artırma
 s1++;
 s2--;
 System.out.println(s1);
 System.out.println(s2);
 ++s1;
 --s2;
 System.out.println(s1);
 System.out.println(s2);
  //2.Karşılaştırma oparatörleri
 byte a=2, b=4;
 System.out.println(a==b);
 System.out.println(a!=b);
 System.out.println(a<b);
 System.out.println(a>b);
 System.out.println(a<=b);
 System.out.println(a>=b);
 //Mantıksal Oparatörler
 //And
 byte x=4, y=5, z=7 ;
 System.out.println(x<y && z>y);
 System.out.println(x>0 && y<0);
 System.out.println(y<x && z>y );
 //Or 
 System.out.println(x<0 || y>0);
 System.out.println(x<y || x<z);
 System.out.println(x<0 || y<0 || z>x);
 

 
    }
    
}
