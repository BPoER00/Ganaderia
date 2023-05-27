package com.example.ganaderia.viewModel.activity;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.KeyEvent;
import android.widget.ImageButton;

import com.example.ganaderia.MainActivity;
import com.example.ganaderia.R;

public class Activity_consulta_animales extends AppCompatActivity {

    private ImageButton btn_img_volver;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consulta_animales);
        this.InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.btn_img_volver = findViewById(R.id.btn_img_volver);
        this.btn_img_volver.setOnClickListener(v -> volverMenu());
    }

    private void volverMenu()
    {
        Intent intent = new Intent(Activity_consulta_animales.this, MainActivity.class);
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