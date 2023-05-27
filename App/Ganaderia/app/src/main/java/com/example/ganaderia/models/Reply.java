package com.example.ganaderia.models;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Reply<E> {

    @SerializedName("code")
    @Expose
    private int code;

    @SerializedName("data")
    @Expose
    private E data;

    @SerializedName("message")
    @Expose
    private String message;

    public int getCode() {
        return code;
    }

    public void setCode(int code) {
        this.code = code;
    }

    public E getData() {
        return data;
    }

    public void setData(E data) {
        this.data = data;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }
}
