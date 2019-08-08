package br.com.fiap.exemplodesp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    EditText edtUsuario;
    EditText edtSenha;
    CheckBox chkManterConectad;
    SharedPreferences sp;
    SharedPreferences.Editor editor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edtUsuario = findViewById(R.id.edtUsuario);
        edtSenha = findViewById(R.id.edtSenha);
        chkManterConectad = findViewById(R.id.chkManterConectado);
        sp = getPreferences(MODE_PRIVATE); // pega os dados salbos nessa activity
        editor = sp.edit();
//                sp = getSharedPreferences(); // pega os dados para serem usados em outras janelas

        boolean conectado = sp.getBoolean("conectado", false);

        if (conectado) {
            edtUsuario.setText(sp.getString("usuario", null));
            edtSenha.setText(sp.getString("senha", null));
            chkManterConectad.setChecked(conectado);
        }
    }

    public void login(View view) {
        String usuario = edtUsuario.getText().toString().trim();
        String senha = edtSenha.getText().toString();
        Boolean manterConectado = chkManterConectad.isChecked();

        if (usuario.isEmpty() || senha.isEmpty()) {
            Toast.makeText(this, getString(R.string.informe_os_dados_correamente), Toast.LENGTH_SHORT).show();
            return;
        }

        if (!usuario.equals("fiap")) {
            Toast.makeText(this, getString(R.string.usuario_inexistente), Toast.LENGTH_SHORT).show();
        }

        if (!senha.equals("fiap")) {
            Toast.makeText(this, getString(R.string.senha_invalida), Toast.LENGTH_SHORT).show();
        }

        if (usuario.equals("fiap") && senha.equals("fiap")) {
            if (manterConectado) {
                editor.putString("usuario", usuario);
                editor.putString("senha", senha);
                editor.putBoolean("conectado", true);
                editor.commit();
            } else {
                editor.clear();
                editor.commit();
            }

            //lógica para abrir outra janela
            Toast.makeText(this, getString(R.string.usuario_logado), Toast.LENGTH_SHORT).show();
            return;
        }

        Toast.makeText(this, getString(R.string.usuario_invalido), Toast.LENGTH_SHORT).show();
    }
}
