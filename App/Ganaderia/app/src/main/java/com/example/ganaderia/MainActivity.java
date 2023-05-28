package com.example.ganaderia;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.KeyEvent;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.ganaderia.viewModel.activity.Activity_consulta_animales;
import com.example.ganaderia.viewModel.activity.Activity_registro_animales;
import com.example.ganaderia.viewModel.activity.Activity_registro_corral;
import com.example.ganaderia.viewModel.activity.Activity_registro_finca;
import com.example.ganaderia.viewModel.activity.Activity_registro_rango;
import com.example.ganaderia.viewModel.activity.Activity_registros_direcciones;
import com.example.ganaderia.viewModel.activity.Activity_registros_razas;

public class MainActivity extends AppCompatActivity {

    private ImageButton Consultar_datos, Animal, Finca, Corral, Direccion, Raza, Rango;
    private TextView Consultar_datos_text, Animal_text, Finca_text, Corral_text, Direccion_text, Raza_text, Rango_text;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        this.InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        //consultar
        this.Consultar_datos = findViewById(R.id.btn_img_consultar);
        this.Consultar_datos_text = findViewById(R.id.btn_consultar);
        this.Consultar_datos.setOnClickListener(v -> irConsultar());
        this.Consultar_datos_text.setOnClickListener(v -> irConsultar());

        //animal
        this.Animal = findViewById(R.id.btn_img_registrar);
        this.Animal_text = findViewById(R.id.btn_registrar);
        this.Animal.setOnClickListener(v -> irAnimales());
        this.Animal_text.setOnClickListener(v -> irAnimales());

        //finca
        this.Finca = findViewById(R.id.btn_img_finca);
        this.Finca_text = findViewById(R.id.btn_finca);
        this.Finca.setOnClickListener(v -> irFinca());
        this.Finca_text.setOnClickListener(v -> irFinca());

        //corral
        this.Corral = findViewById(R.id.btn_img_corral);
        this.Corral_text = findViewById(R.id.btn_corral);
        this.Corral.setOnClickListener(v -> irCorral());
        this.Corral_text.setOnClickListener(v -> irCorral());

        //direccion
        this.Direccion = findViewById(R.id.btn_img_direcciones);
        this.Direccion_text = findViewById(R.id.btn_direcciones);
        this.Direccion.setOnClickListener(v -> irDirecciones());
        this.Direccion_text.setOnClickListener(v -> irDirecciones());

        //raza
        this.Raza = findViewById(R.id.btn_img_raza);
        this.Raza_text = findViewById(R.id.btn_raza);
        this.Raza.setOnClickListener(v -> irRaza());
        this.Raza_text.setOnClickListener(v -> irRaza());

        //rango
        this.Rango = findViewById(R.id.btn_img_rango);
        this.Rango_text = findViewById(R.id.btn_rango);
        this.Rango.setOnClickListener(v -> irRango());
        this.Rango_text.setOnClickListener(v -> irRango());
    }

    private void irConsultar()
    {
        Intent intent = new Intent(MainActivity.this, Activity_consulta_animales.class);
        startActivity(intent);
        finish();
    }

    private void irAnimales()
    {
        Intent intent = new Intent(MainActivity.this, Activity_registro_animales.class);
        startActivity(intent);
        finish();
    }

    private void irFinca()
    {
        Intent intent = new Intent(MainActivity.this, Activity_registro_finca.class);
        startActivity(intent);
        finish();
    }

    private void irCorral()
    {
        Intent intent = new Intent(MainActivity.this, Activity_registro_corral.class);
        startActivity(intent);
        finish();
    }

    private void irDirecciones()
    {
        Intent intent = new Intent(MainActivity.this, Activity_registros_direcciones.class);
        startActivity(intent);
        finish();
    }

    private void irRango()
    {
        Intent intent = new Intent(MainActivity.this, Activity_registro_rango.class);
        startActivity(intent);
        finish();
    }

    private void irRaza()
    {
        Intent intent = new Intent(MainActivity.this, Activity_registros_razas.class);
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
}