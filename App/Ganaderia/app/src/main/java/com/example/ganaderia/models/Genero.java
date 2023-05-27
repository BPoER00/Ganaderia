package com.example.ganaderia.models;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class Genero implements Serializable, Parcelable {

    @SerializedName("id")
    @Expose
    private int id;

    @SerializedName("nombre")
    @Expose
    private String nombre;

    @SerializedName("estado")
    @Expose
    private int estado;

    protected Genero(Parcel in) {
        id = in.readInt();
        nombre = in.readString();
        estado = in.readInt();
    }

    public static final Creator<Genero> CREATOR = new Creator<Genero>() {
        @Override
        public Genero createFromParcel(Parcel in) {
            return new Genero(in);
        }

        @Override
        public Genero[] newArray(int size) {
            return new Genero[size];
        }
    };

    @Override
    public int describeContents() {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel dest, int flags) {
        dest.writeInt(id);
        dest.writeString(nombre);
        dest.writeInt(estado);
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
}
