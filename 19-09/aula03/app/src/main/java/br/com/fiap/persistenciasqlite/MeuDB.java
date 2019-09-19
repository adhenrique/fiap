package br.com.fiap.persistenciasqlite;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import java.util.ArrayList;
import java.util.List;

public class MeuDB extends SQLiteOpenHelper {

    public static final String DATABASE_NAME = "MeuDB";
    public static final int DATABASE_VERSION = 1;
    public final String TB_USUARIO = "usuario";

    public MeuDB(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {
        String sql = "CREATE TABLE " + TB_USUARIO + " (" +
                        "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                        "nome TEXT NOT NULL," +
                        "email TEXT NOT NULL UNIQUE" +
                    ")";

        sqLiteDatabase.execSQL(sql);

    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {

    }

    public void inserir(Usuario usuario) {
        // Pegando o banco para fazer uma escrita dentro dele
        SQLiteDatabase db = getWritableDatabase();

        ContentValues cv = new ContentValues();
        cv.put("nome", usuario.getNome());
        cv.put("email", usuario.getEmail());

            db.insert(TB_USUARIO, null, cv);
    }

    public void atualizar(Usuario usuario) {
        // Pegando o banco para fazer uma escrita dentro dele
        SQLiteDatabase db = getWritableDatabase();

        ContentValues cv = new ContentValues();
        cv.put("nome", usuario.getNome());
        cv.put("email", usuario.getEmail());

        db.update(
            TB_USUARIO,
            cv,
            "id = ?",
            new String[] { String.valueOf(usuario.getCodigo()) }
        );
    }

    public void excluir(int codigo) {
        SQLiteDatabase db = getWritableDatabase();

        db.delete(
            TB_USUARIO,
            "id = ?",
            new String[] {String.valueOf(codigo)}
        );
    }

    public List<Usuario> listarUsuarios() {
        List<Usuario> usuarios = new ArrayList<>();

        SQLiteDatabase db = getReadableDatabase();

        Cursor cursor = db.query(
            TB_USUARIO,
            new String[]{"id", "nome", "email"},
                null,
                null,
                null,
                null,
                "nome"
        );

        if (cursor.moveToFirst()) {
            do {
                Usuario usuario = new Usuario();
                usuario.setCodigo( cursor.getInt(0));
                usuario.setNome( cursor.getString(1));
                usuario.setEmail( cursor.getString(2));

                usuarios.add(usuario);
            } while (cursor.moveToNext());
        }
        return usuarios;
    }

    public Usuario buscarUsuarios(String nome) {

        SQLiteDatabase db = getReadableDatabase();

        Cursor cursor = db.query(
                TB_USUARIO,
                new String[]{"id", "nome", "email"},
                "nome = ?",
                new String[]{ nome },
                null,
                null,
                "nome"
        );

        if (cursor.moveToFirst()) {
            Usuario usuario = new Usuario();
            usuario.setCodigo(cursor.getInt(0));
            usuario.setNome( cursor.getString(1));
            usuario.setEmail( cursor.getString(2));

            return usuario;
        }
        return null;
    }
}
