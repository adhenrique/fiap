package br.com.fiap.exemplodefile;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;

public class MainActivity extends AppCompatActivity {

    EditText editObservacoes;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editObservacoes = findViewById(R.id.observacoes);
    }

    public void salvar(View view) {
        String texto = editObservacoes.getText().toString().trim();

        try {
            FileOutputStream fos = openFileOutput("observacoes.txt", MODE_PRIVATE);
            fos.write(texto.getBytes());
            fos.close();

            Toast.makeText(this, getString(R.string.salvo), Toast.LENGTH_SHORT).show();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void ler(View view) {
        try {
            FileInputStream fis = openFileInput("observacoes.txt");
            BufferedReader br = new BufferedReader(new InputStreamReader(fis));
            String txt = br.readLine();

            fis.close();
            Toast.makeText(this, txt, Toast.LENGTH_SHORT).show();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
