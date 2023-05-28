package com.example.ganaderia.controllers.adapters;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.ganaderia.R;
import com.example.ganaderia.models.Corral;

import java.util.List;

public class CorralAdapter extends RecyclerView.Adapter<CorralAdapter.CorralViewHolder>{

    private List<Corral> listaCorral;

    public CorralAdapter(List<Corral> listaCorral)
    {
        this.listaCorral = listaCorral;
    }

    @NonNull
    @Override
    public CorralViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_registros_corral, null, false);
        return new CorralViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull CorralViewHolder holder, int position) {
        Corral corral = this.listaCorral.get(position);

        holder.tv_finca.setText(String.valueOf(corral.getId_finca()));
        holder.tv_cantidad.setText(String.valueOf(corral.getCantidad_corral()));
        holder.tv_actual.setText(String.valueOf(corral.getCantidad_actual()));
    }

    @Override
    public int getItemCount() {
        return this.listaCorral.size();
    }

    public class CorralViewHolder extends RecyclerView.ViewHolder {
        TextView tv_finca, tv_cantidad, tv_actual;
        public CorralViewHolder(@NonNull View itemView) {
            super(itemView);

            tv_finca = itemView.findViewById(R.id.txt_item_finca);
            tv_cantidad = itemView.findViewById(R.id.txt_item_cantidad);
            tv_actual = itemView.findViewById(R.id.txt_item_actual);

        }
    }
}
