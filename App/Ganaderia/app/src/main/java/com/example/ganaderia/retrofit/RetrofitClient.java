package com.example.ganaderia.retrofit;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.util.concurrent.TimeUnit;

import okhttp3.OkHttpClient;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class RetrofitClient {

    public static String DEFAULT_IP = "";
    public static String URL = "https://" + DEFAULT_IP + "/api";

    //TIEMPO
    private static int TIMEOUT_CONNECT = 60;
    private static int TIMEOUT_READ = 60;
    private static int TIMEOUT_WRITE = 60;

    private static Gson gson_basic = new GsonBuilder()
            .setLenient()
            .excludeFieldsWithoutExposeAnnotation()
            .create();

    private static OkHttpClient okHttpClient = new OkHttpClient().newBuilder()
            .connectTimeout(TIMEOUT_CONNECT, TimeUnit.SECONDS)
            .readTimeout(TIMEOUT_READ, TimeUnit.SECONDS)
            .writeTimeout(TIMEOUT_WRITE, TimeUnit.SECONDS)
            .build();

    private static Retrofit.Builder builder = new Retrofit.Builder()
            .client(okHttpClient)
            .baseUrl(URL)
            .addConverterFactory(GsonConverterFactory.create(gson_basic));

    private static Retrofit retrofit = null;

    public static Retrofit getClient(){
        if(retrofit == null){
            retrofit = builder
                    .build();
        }

        return retrofit;
    }

}
