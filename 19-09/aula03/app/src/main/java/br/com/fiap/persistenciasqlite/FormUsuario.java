package br.com.fiap.persistenciasqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class FormUsuario extends AppCompatActivity {

    EditText edtNome;
    EditText edtEmail;
    Button btnExcluir;
    MeuDB meuDB;
    Usuario usuario;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_form_usuario);

        edtNome = findViewById(R.id.edtNome);
        edtEmail = findViewById(R.id.edtEmail);
        btnExcluir = findViewById(R.id.btn_excluir);
        meuDB = new MeuDB(this);

        Bundle extras = getIntent().getExtras();
        if (extras != null) {
            usuario = (Usuario) extras.get("usuario");
            if (usuario != null) {
                btnExcluir.setVisibility(View.VISIBLE);
                edtNome.setText(usuario.getNome());
                edtEmail.setText(usuario.getEmail());
                Log.d("ADE", usuario.getEmail());
            }
        }
    }

    public void salvar(View view) {

        String nome = edtNome.getText().toString().trim();
        String email = edtEmail.getText().toString().trim();


        if(nome.isEmpty() || email.isEmpty()) {
            Toast.makeText(this, getString(R.string.dados_incorretos), Toast.LENGTH_SHORT).show();
            return;
        }

        if (usuario == null ) {
            usuario = new Usuario(nome, email);
            meuDB.inserir(usuario);
        } else {
            usuario.setNome(nome);
            usuario.setEmail(email);
            meuDB.atualizar(usuario);
        }

        Toast.makeText(this, getString(R.string.usuario_salvo), Toast.LENGTH_SHORT).show();
        finish();

    }

    public void excluir(View view) {
        meuDB.excluir(usuario.getCodigo());
        Toast.makeText(this, getString(R.string.usuario_excluido), Toast.LENGTH_SHORT).show();
        finish();
    }
}
