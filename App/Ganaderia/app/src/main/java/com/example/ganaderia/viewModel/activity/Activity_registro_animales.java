package com.example.ganaderia.viewModel.activity;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.KeyEvent;
import android.widget.Adapter;
import android.widget.ArrayAdapter;
import android.widget.ImageButton;
import android.widget.Spinner;

import com.example.ganaderia.MainActivity;
import com.example.ganaderia.R;
import com.example.ganaderia.models.Genero;
import com.example.ganaderia.models.Reply;
import com.example.ganaderia.retrofit.APIUtils;
import com.example.ganaderia.retrofit.service.Generos;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Activity_registro_animales extends AppCompatActivity {

    private ImageButton btn_volver;
    private Spinner spn_genero;
    private Spinner spn_corral;
    private Spinner spn_raza;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registro_animales);
        this.InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.btn_volver = findViewById(R.id.btn_img_volver_animales);
        this.spn_genero = findViewById(R.id.spn_genero);
        this.spn_corral = findViewById(R.id.spn_corral);
        this.spn_raza = findViewById(R.id.spn_raza);
        this.btn_volver.setOnClickListener(v -> volverMenu());

        this.obtenerGenero();
    }

    private void volverMenu()
    {
        Intent intent = new Intent(Activity_registro_animales.this, MainActivity.class);
        startActivity(intent);
        finish();
    }

    //no ir atras
    @Override
    public void onBackPressed() {
        // Do Here what ever you want do on back press;
    }

    @Override
    public boolean onKeyDown(int keyCode, KeyEvent event) {
        if (keyCode == KeyEvent.KEYCODE_BACK) {
            //preventing default implementation previous to android.os.Build.VERSION_CODES.ECLAIR
            return true;
        }
        return super.onKeyDown(keyCode, event);
    }

    public void obtenerGenero()
    {
        try {
            APIUtils.getGenerosService().obtenerGeneros().enqueue(new Callback<Reply<List<Generos>>>() {
                @Override
                public void onResponse(Call<Reply<List<Generos>>> call, Response<Reply<List<Generos>>> response) {
                    if(response.isSuccessful())
                    {
                        List<Generos> genero = response.body().getData();

                        System.out.println("traido: " + genero);

//                        ArrayAdapter<Genero> arrayAdapter = new ArrayAdapter<>(
//                                Activity_registro_animales.this,
//                                Adapter.IGNORE_ITEM_VIEW_TYPE,
//                                genero
//                        );
//
//                        spn_menuPrincipal_categorias.setAdapter(arrayAdapter);
                    }
                }

                @Override
                public void onFailure(Call<Reply<List<Generos>>> call, Throwable t) {

                }
            });
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}