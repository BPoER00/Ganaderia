package com.example.ganaderia.models;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class Finca implements Serializable, Parcelable {

    @SerializedName("id")
    @Expose
    private int id;

    @SerializedName("nombre")
    @Expose
    private String nombre;

    @SerializedName("id_ubicacion")
    @Expose
    private int id_ubicacion;

    @SerializedName("estado")
    @Expose
    private int estado;

    protected Finca(Parcel in) {
        id = in.readInt();
        nombre = in.readString();
        id_ubicacion = in.readInt();
        estado = in.readInt();
    }

    public static final Creator<Finca> CREATOR = new Creator<Finca>() {
        @Override
        public Finca createFromParcel(Parcel in) {
            return new Finca(in);
        }

        @Override
        public Finca[] newArray(int size) {
            return new Finca[size];
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
        dest.writeInt(id_ubicacion);
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

    public int getId_ubicacion() {
        return id_ubicacion;
    }

    public void setId_ubicacion(int id_ubicacion) {
        this.id_ubicacion = id_ubicacion;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
}
