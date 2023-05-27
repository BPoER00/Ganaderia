package com.example.ganaderia.viewModel.activity;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.os.Bundle;
import android.view.KeyEvent;
import android.widget.ImageButton;

import com.example.ganaderia.MainActivity;
import com.example.ganaderia.R;
import com.example.ganaderia.viewModel.fragment.fragment_consulta_animal;
import com.example.ganaderia.viewModel.fragment.fragment_consulta_corral;
import com.example.ganaderia.viewModel.fragment.fragment_consulta_finca;

public class Activity_consulta_animales extends AppCompatActivity {

    //fragments
    private final fragment_consulta_animal fragment_consulta_animal = new fragment_consulta_animal(this);
    private final fragment_consulta_corral fragment_consulta_corral = new fragment_consulta_corral(this);
    private final fragment_consulta_finca fragment_consulta_finca = new fragment_consulta_finca(this);

    //botones
    private ImageButton btn_img_volver;
    private ImageButton btn_animal;
    private ImageButton btn_finca;
    private ImageButton btn_corral;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consulta_animales);
        this.InicializarComponentes();

        this.fragmentDefault(savedInstanceState);
    }

    private void InicializarComponentes()
    {
        this.btn_img_volver = findViewById(R.id.btn_img_volver);
        this.btn_animal = findViewById(R.id.btn_img_animal);
        this.btn_finca = findViewById(R.id.btn_img_finca);
        this.btn_corral = findViewById(R.id.btn_img_corral);

        this.btn_img_volver.setOnClickListener(v -> volverMenu());
        this.btn_animal.setOnClickListener(v -> setFragment_consulta_animal());
        this.btn_finca.setOnClickListener(v -> setFragment_consulta_finca());
        this.btn_corral.setOnClickListener(v -> setFragment_consulta_corral());

    }

    private void volverMenu()
    {
        Intent intent = new Intent(Activity_consulta_animales.this, MainActivity.class);
        startActivity(intent);
        finish();
    }

    private void cambiarFragment_ventas(Fragment fragment){
        getSupportFragmentManager().beginTransaction()
                .replace(R.id.fcv_mostrar_consultas, fragment, null)
                .setReorderingAllowed(true)
                .setTransition(FragmentTransaction.TRANSIT_FRAGMENT_OPEN)
                .addToBackStack("replacement")
                .commit();
    }

    private void fragmentDefault(Bundle savedInstanceState)
    {
        this.cambiarFragment_ventas(this.fragment_consulta_animal);
    }

    private void setFragment_consulta_animal()
    {
        this.cambiarFragment_ventas(this.fragment_consulta_animal);

    }

    private void setFragment_consulta_corral()
    {
        this.cambiarFragment_ventas(this.fragment_consulta_corral);

    }

    private void setFragment_consulta_finca()
    {
        this.cambiarFragment_ventas(this.fragment_consulta_finca);

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
}