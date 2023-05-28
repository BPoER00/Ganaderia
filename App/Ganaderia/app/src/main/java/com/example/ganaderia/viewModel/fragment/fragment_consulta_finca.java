package com.example.ganaderia.viewModel.fragment;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.ganaderia.R;
import com.example.ganaderia.controllers.adapters.AnimalesAdapter;
import com.example.ganaderia.controllers.adapters.FincaAdapter;
import com.example.ganaderia.models.Animal;
import com.example.ganaderia.models.Finca;
import com.example.ganaderia.viewModel.activity.Activity_consulta_animales;

import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

import java.util.ArrayList;
import java.util.List;

public class fragment_consulta_finca extends Fragment {

    private Activity_consulta_animales activity_consulta_animales;
    private RecyclerView rv_item_finca;

    public fragment_consulta_finca(Activity_consulta_animales activity_consulta_animales)
    {
        super(R.layout.fragment_consulta_finca);
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
        return inflater.inflate(R.layout.fragment_consulta_finca, container, false);
    }

    @Override
    public void onViewCreated(@NotNull View view, @Nullable Bundle savedInstanceState){
        super.onViewCreated(view, savedInstanceState);

        this.inicializarComponentes(view);
    }

    private void inicializarComponentes(View view)
    {
        this.rv_item_finca = view.findViewById(R.id.rv_registro_fincas);
        this.agregarAnimal();
    }


    private void agregarAnimal()
    {

        Finca finca = new Finca();

        finca.setNombre("Los Primos");
        finca.setId_ubicacion(1);

        List<Finca> fincas = new ArrayList<>();
        fincas.add(finca);
        GridLayoutManager layoutManager = new GridLayoutManager(activity_consulta_animales, 1);
        this.rv_item_finca.setLayoutManager(layoutManager);
        rv_item_finca.setAdapter(new FincaAdapter(fincas));
    }
}