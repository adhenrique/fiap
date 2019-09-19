package br.com.fiap.persistenciasqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.List;

public class MainActivity extends AppCompatActivity {

    ListView lstUsuarios;
    MeuDB meuDb;
    List<Usuario> usuarios;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        meuDb = new MeuDB(this);
        lstUsuarios = findViewById(R.id.lstUsuarios);
        lstUsuarios.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Usuario usuario = usuarios.get(i);

                Intent it = new Intent(MainActivity.this, FormUsuario.class);
                it.putExtra("usuario", usuario);
                startActivity(it);
            }
        });
    }

    @Override
    protected void onResume() {
        super.onResume();

        usuarios = meuDb.listarUsuarios();
        ArrayAdapter<Usuario> adapter = new ArrayAdapter<>(this,
                android.R.layout.simple_list_item_1, usuarios);
        lstUsuarios.setAdapter(adapter);
    }

    public void inserir(View view) {
        Intent it = new Intent(this, FormUsuario.class);
        startActivity(it);
    }
}
