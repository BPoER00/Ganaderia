package com.example.ganaderia.retrofit.service;

import com.example.ganaderia.models.Direccion;
import com.example.ganaderia.models.Reply;

import org.json.JSONArray;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.Header;
import retrofit2.http.Headers;
import retrofit2.http.POST;
import retrofit2.http.Query;

public interface DireccionService {

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @GET("Direcciones")
    Call<Reply<List<Direccion>>> obtenerDireccion(
    ) throws Exception;

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @POST("Direcciones")
    @FormUrlEncoded
    Call<Reply<Direccion>> guardarDireccion(
            @Field("cui") String cui,
            @Field("nit") String nit

    ) throws Exception;
}
