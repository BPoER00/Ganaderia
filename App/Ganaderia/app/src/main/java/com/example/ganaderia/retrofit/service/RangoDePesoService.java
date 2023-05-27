package com.example.ganaderia.retrofit.service;

import com.example.ganaderia.models.Rango_de_peso;
import com.example.ganaderia.models.Reply;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.POST;

public interface RangoDePesoService {

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @GET("RangoDePeso")
    Call<Reply<List<Rango_de_peso>>> obtenerRangoDePeso(
    ) throws Exception;

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @POST("RangoDePeso")
    @FormUrlEncoded
    Call<Reply<Rango_de_peso>> guardarRangoDePeso(
            @Field("cui") String cui,
            @Field("nit") String nit

    ) throws Exception;
}
