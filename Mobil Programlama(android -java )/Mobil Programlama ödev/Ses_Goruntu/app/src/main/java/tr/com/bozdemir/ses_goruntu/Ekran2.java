package tr.com.bozdemir.ses_goruntu;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
/**
 * Created by İlyas70 on 20.10.2017.
 */

public class Ekran2 extends AppCompatActivity {
    Button oynat,duraklat,durdur;
    MediaPlayer medya;
    @Override
       protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.ekran2);
oynat =(Button)findViewById(R.id.button);
       oynat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
medya= MediaPlayer.create(Ekran2.this,R.raw.poyraz_karayel);
                medya.start();
            }
        });
        duraklat =(Button)findViewById(R.id.button2);
        duraklat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                medya.pause();
            }
        });
        durdur =(Button)findViewById(R.id.button3);
        durdur.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                medya.stop();
            }
        });

    }
}
