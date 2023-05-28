package com.example.ganaderia.models;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class Corral implements Serializable, Parcelable {

    @SerializedName("id")
    @Expose
    private int id;

    @SerializedName("id_genero")
    @Expose
    private int id_genero;

    @SerializedName("id_rango_peso")
    @Expose
    private int id_rango_peso;

    @SerializedName("id_finca")
    @Expose
    private int id_finca;

    @SerializedName("numero_corral")
    @Expose
    private int numero_corral;

    @SerializedName("cantidad_corral")
    @Expose
    private int cantidad_corral;

    @SerializedName("cantidad_actual")
    @Expose
    private int cantidad_actual;

    @SerializedName("estado")
    @Expose
    private int estado;


    protected Corral(Parcel in) {
        id = in.readInt();
        id_genero = in.readInt();
        id_rango_peso = in.readInt();
        id_finca = in.readInt();
        numero_corral = in.readInt();
        cantidad_corral = in.readInt();
        cantidad_actual = in.readInt();
        estado = in.readInt();
    }

    public Corral()
    {}


    public static final Creator<Corral> CREATOR = new Creator<Corral>() {
        @Override
        public Corral createFromParcel(Parcel in) {
            return new Corral(in);
        }

        @Override
        public Corral[] newArray(int size) {
            return new Corral[size];
        }
    };

    @Override
    public int describeContents() {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel dest, int flags) {
        dest.writeInt(id);
        dest.writeInt(id_genero);
        dest.writeInt(id_rango_peso);
        dest.writeInt(id_finca);
        dest.writeInt(numero_corral);
        dest.writeInt(cantidad_corral);
        dest.writeInt(cantidad_actual);
        dest.writeInt(estado);
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getId_genero() {
        return id_genero;
    }

    public void setId_genero(int id_genero) {
        this.id_genero = id_genero;
    }

    public int getId_rango_peso() {
        return id_rango_peso;
    }

    public void setId_rango_peso(int id_rango_peso) {
        this.id_rango_peso = id_rango_peso;
    }

    public int getId_finca() {
        return id_finca;
    }

    public void setId_finca(int id_finca) {
        this.id_finca = id_finca;
    }

    public int getNumero_corral() {
        return numero_corral;
    }

    public void setNumero_corral(int numero_corral) {
        this.numero_corral = numero_corral;
    }

    public int getCantidad_corral() {
        return cantidad_corral;
    }

    public void setCantidad_corral(int cantidad_corral) {
        this.cantidad_corral = cantidad_corral;
    }

    public int getCantidad_actual() {
        return cantidad_actual;
    }

    public void setCantidad_actual(int cantidad_actual) {
        this.cantidad_actual = cantidad_actual;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
}
