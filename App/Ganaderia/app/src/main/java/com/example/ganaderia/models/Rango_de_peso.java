package com.example.ganaderia.models;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class Rango_de_peso implements Serializable, Parcelable {

    @SerializedName("id")
    @Expose
    private int id;

    @SerializedName("rango_de_peso")
    @Expose
    private String rango_de_peso;

    @SerializedName("descripcion")
    @Expose
    private String descripcion;

    @SerializedName("estado")
    @Expose
    private int estado;


    protected Rango_de_peso(Parcel in) {
        id = in.readInt();
        rango_de_peso = in.readString();
        descripcion = in.readString();
        estado = in.readInt();
    }

    public static final Creator<Rango_de_peso> CREATOR = new Creator<Rango_de_peso>() {
        @Override
        public Rango_de_peso createFromParcel(Parcel in) {
            return new Rango_de_peso(in);
        }

        @Override
        public Rango_de_peso[] newArray(int size) {
            return new Rango_de_peso[size];
        }
    };

    @Override
    public int describeContents() {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel dest, int flags) {
        dest.writeInt(id);
        dest.writeString(rango_de_peso);
        dest.writeString(descripcion);
        dest.writeInt(estado);
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getRango_de_peso() {
        return rango_de_peso;
    }

    public void setRango_de_peso(String rango_de_peso) {
        this.rango_de_peso = rango_de_peso;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
}
