package com.example.ganaderia.models;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class Animal implements Serializable, Parcelable {

    @SerializedName("id")
    @Expose
    private int id;

    @SerializedName("id_raza")
    @Expose
    private int id_raza;

    @SerializedName("id_corral")
    @Expose
    private int id_corral;

    @SerializedName("estado")
    @Expose
    private int estado;

    protected Animal(Parcel in) {
        id = in.readInt();
        id_raza = in.readInt();
        id_corral = in.readInt();
        estado = in.readInt();
    }

    public static final Creator<Animal> CREATOR = new Creator<Animal>() {
        @Override
        public Animal createFromParcel(Parcel in) {
            return new Animal(in);
        }

        @Override
        public Animal[] newArray(int size) {
            return new Animal[size];
        }
    };

    @Override
    public int describeContents() {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel dest, int flags) {
        dest.writeInt(id);
        dest.writeInt(id_raza);
        dest.writeInt(id_corral);
        dest.writeInt(estado);
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getId_raza() {
        return id_raza;
    }

    public void setId_raza(int id_raza) {
        this.id_raza = id_raza;
    }

    public int getId_corral() {
        return id_corral;
    }

    public void setId_corral(int id_corral) {
        this.id_corral = id_corral;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
}
