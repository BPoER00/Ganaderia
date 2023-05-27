package com.example.ganaderia.viewModel.fragment;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.ganaderia.R;
import com.example.ganaderia.viewModel.activity.Activity_consulta_animales;

public class fragment_consulta_corral extends Fragment {

    private Activity_consulta_animales activity_consulta_animales;

    public fragment_consulta_corral(Activity_consulta_animales activity_consulta_animales)
    {
        super(R.layout.fragment_consulta_corral);
        this.activity_consulta_animales = activity_consulta_animales;
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_consulta_corral, container, false);
    }
}