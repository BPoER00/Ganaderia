package com.example.ganaderia.viewModel.activity;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.KeyEvent;
import android.widget.ImageButton;

import com.example.ganaderia.MainActivity;
import com.example.ganaderia.R;

public class Activity_registros_razas extends AppCompatActivity {

    private ImageButton btn_volver;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registros_razas);
        this.InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.btn_volver = findViewById(R.id.btn_img_volver_razas);
        this.btn_volver.setOnClickListener(v -> volverMenu());
    }

    private void volverMenu()
    {
        Intent intent = new Intent(Activity_registros_razas.this, MainActivity.class);
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