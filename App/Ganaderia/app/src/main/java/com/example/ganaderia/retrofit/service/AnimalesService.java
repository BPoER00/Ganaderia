package com.example.ganaderia.retrofit.service;

import com.example.ganaderia.models.Animal;
import com.example.ganaderia.models.Direccion;
import com.example.ganaderia.models.Reply;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.Header;
import retrofit2.http.Headers;
import retrofit2.http.POST;
import retrofit2.http.Query;

public interface AnimalesService {

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @GET("Animales")
    Call<Reply<List<Animal>>> obtenerAnimales(
    ) throws Exception;

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @POST("Animales")
    @FormUrlEncoded
    Call<Reply<Animal>> guardarAnimales(
            @Field("cui") String cui,
            @Field("nit") String nit

    ) throws Exception;
}
