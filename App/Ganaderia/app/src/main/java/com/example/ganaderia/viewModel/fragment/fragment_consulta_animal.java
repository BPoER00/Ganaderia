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
import com.example.ganaderia.models.Animal;
import com.example.ganaderia.viewModel.activity.Activity_consulta_animales;

import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

import java.util.ArrayList;
import java.util.List;

public class fragment_consulta_animal extends Fragment {

    private Activity_consulta_animales activity_consulta_animales;
    private RecyclerView rv_item_animal;

    public fragment_consulta_animal(Activity_consulta_animales activity_consulta_animales) {
        super(R.layout.fragment_consulta_animal);
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
        return inflater.inflate(R.layout.fragment_consulta_animal, container, false);
    }

    @Override
    public void onViewCreated(@NotNull View view, @Nullable Bundle savedInstanceState){
        super.onViewCreated(view, savedInstanceState);

        this.inicializarComponentes(view);
    }

    private void inicializarComponentes(View view)
    {
        this.rv_item_animal = view.findViewById(R.id.rv_registro_animales);
        this.agregarAnimal();
    }


    private void agregarAnimal()
    {

        Animal animal = new Animal();

        animal.setId(1);
        animal.setId_corral(1);
        animal.setId_raza(1);

        List<Animal> animals = new ArrayList<>();
        animals.add(animal);
        GridLayoutManager layoutManager = new GridLayoutManager(activity_consulta_animales, 1);
        this.rv_item_animal.setLayoutManager(layoutManager);
        rv_item_animal.setAdapter(new AnimalesAdapter(animals));
    }


}