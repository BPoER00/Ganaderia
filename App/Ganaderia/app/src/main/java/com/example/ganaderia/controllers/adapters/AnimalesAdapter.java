package com.example.ganaderia.controllers.adapters;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.ganaderia.models.Animal;

import java.util.List;

import com.example.ganaderia.R;


public class AnimalesAdapter extends RecyclerView.Adapter<AnimalesAdapter.AnimalesViewHolder> {

    private List<Animal> listaAnimal;

    public AnimalesAdapter(List<Animal> listaAnimal)
    {
        this.listaAnimal = listaAnimal;
    }


    @NonNull
    @Override
    public AnimalesViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_registros_animales, null, false);
        return new AnimalesViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull AnimalesViewHolder holder, int position) {

        Animal animal = this.listaAnimal.get(position);

        holder.tv_numero.setText(String.valueOf(animal.getId()));
        holder.tv_raza.setText(String.valueOf(animal.getId_raza()));
        holder.tv_corral.setText(String.valueOf(animal.getId_corral()));
    }

    @Override
    public int getItemCount() {
        return this.listaAnimal.size();
    }

    public class AnimalesViewHolder extends RecyclerView.ViewHolder {

        TextView tv_numero, tv_raza, tv_corral;

        public AnimalesViewHolder(@NonNull View itemView) {
            super(itemView);

            this.tv_numero = itemView.findViewById(R.id.txt_item_numero);
            this.tv_raza = itemView.findViewById(R.id.txt_item_raza);
            this.tv_corral = itemView.findViewById(R.id.txt_item_corral);
        }
    }
}
