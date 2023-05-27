package com.example.ganaderia.retrofit;

import com.example.ganaderia.retrofit.service.AnimalesService;
import com.example.ganaderia.retrofit.service.CorralService;
import com.example.ganaderia.retrofit.service.DireccionService;
import com.example.ganaderia.retrofit.service.Fincas;
import com.example.ganaderia.retrofit.service.Generos;
import com.example.ganaderia.retrofit.service.RangoDePesoService;
import com.example.ganaderia.retrofit.service.Razas;

public class APIUtils {

    public static AnimalesService getAnimalesService(){
        return RetrofitClient.getClient().create(AnimalesService.class);
    }

    public static CorralService getCorralService(){
        return RetrofitClient.getClient().create(CorralService.class);
    }

    public static DireccionService getDireccionService(){
        return RetrofitClient.getClient().create(DireccionService.class);
    }

    public static Fincas getFincasService(){
        return RetrofitClient.getClient().create(Fincas.class);
    }

    public static Generos getGenerosService(){
        return RetrofitClient.getClient().create(Generos.class);
    }

    public static RangoDePesoService getRangoDePesoService(){
        return RetrofitClient.getClient().create(RangoDePesoService.class);
    }

    public static Razas getRazasService(){
        return RetrofitClient.getClient().create(Razas.class);
    }
}
