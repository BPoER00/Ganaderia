package com.example.ganaderia.retrofit.service;

import com.example.ganaderia.models.Animal;
import com.example.ganaderia.models.Corral;
import com.example.ganaderia.models.Reply;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.POST;

public interface CorralService {

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @GET("Corral")
    Call<Reply<List<Corral>>> obtenerCorral(
    ) throws Exception;

    @Headers({"Accept: application/json; Content-Type: application/json"})
    @POST("Corral")
    @FormUrlEncoded
    Call<Reply<Corral>> guardarCorral(
            @Field("cui") String cui,
            @Field("nit") String nit

    ) throws Exception;
}
