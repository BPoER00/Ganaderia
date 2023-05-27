package com.example.ganaderia.retrofit.service;

import com.example.ganaderia.models.Rango_de_peso;
import com.example.ganaderia.models.Raza;
import com.example.ganaderia.models.Reply;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.POST;

public interface Razas {

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @GET("Razas")
    Call<Reply<List<Raza>>> obtenerRazas(
    ) throws Exception;

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @POST("Razas")
    @FormUrlEncoded
    Call<Reply<Raza>> guardarRazas(
            @Field("cui") String cui,
            @Field("nit") String nit

    ) throws Exception;
}
