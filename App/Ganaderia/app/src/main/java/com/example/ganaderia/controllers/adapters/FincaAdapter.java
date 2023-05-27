package com.example.ganaderia.controllers.adapters;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.ganaderia.R;
import com.example.ganaderia.models.Animal;
import com.example.ganaderia.models.Finca;

import java.util.List;

public class FincaAdapter extends RecyclerView.Adapter<FincaAdapter.FincasViewHolder>{

    private List<Finca> listaFinca;

    public FincaAdapter(List<Finca> listaFinca)
    {
        this.listaFinca = listaFinca;
    }

    @NonNull
    @Override
    public FincasViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_registros_finca, null, false);
        return new FincasViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull FincasViewHolder holder, int position) {
        Finca finca = this.listaFinca.get(position);

        holder.tv_nombre.setText(String.valueOf(String.valueOf(finca.getNombre())));
        holder.tv_ubicacion.setText(String.valueOf(String.valueOf(finca.getId_ubicacion())));
    }

    @Override
    public int getItemCount() {
        return this.listaFinca.size();
    }

    public class FincasViewHolder extends RecyclerView.ViewHolder {

        TextView tv_nombre, tv_ubicacion;

        public FincasViewHolder(@NonNull View itemView) {
            super(itemView);
            tv_nombre = itemView.findViewById(R.id.txt_item_nombre);
            tv_ubicacion = itemView.findViewById(R.id.txt_item_ubicacion);
        }
    }
}
