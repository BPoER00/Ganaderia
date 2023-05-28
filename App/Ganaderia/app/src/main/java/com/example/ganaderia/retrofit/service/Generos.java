package com.example.ganaderia.retrofit.service;

import com.example.ganaderia.models.Reply;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.POST;

public interface Generos {

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @GET("Generos")
    Call<Reply<List<Generos>>> obtenerGeneros() throws Exception;

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @POST("Generos")
    @FormUrlEncoded
    Call<Reply<Generos>> guardarGeneros(
            @Field("cui") String cui,
            @Field("nit") String nit

    ) throws Exception;
}
