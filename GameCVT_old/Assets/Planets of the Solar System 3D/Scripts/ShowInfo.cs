using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;



public class ShowInfo : MonoBehaviour
{
    private UnityWebRequest req;
    public PlanetData planetInfo; // classe que armazena o JSON 
    public TextMeshPro PlanetName;
    public TextMeshPro planetContent;
    public GameObject Planet;


    private float Magnitude;
    private float AltitudeGeometrica;

    private float Azimute;

    private int DistanciaTerra;

    void Start()
    
    {

        StartCoroutine(pegaDados()); // coroutine � parecido com o async
    }
    

    public IEnumerator pegaDados()      
    {

            string planetPoint = Planet.name;
            string endPoint = "http://192.168.31.100:8090/api/objects/info?name="+planetPoint+"&format=json";

           while (true){


                req = UnityWebRequest.Get(endPoint);
                yield return req.SendWebRequest(); // yield � parecido com o await


                var res = req.downloadHandler.text;
                planetInfo = JsonConvert.DeserializeObject<PlanetData>(res);    

                Magnitude = (float)planetInfo.vmag;
                AltitudeGeometrica = (float)planetInfo.altitude_geometric;
                Azimute = (float)planetInfo.azimuth;
                DistanciaTerra = (int)planetInfo.distance_km;

                PlanetName.text = planetInfo.localized_name;

                if (planetInfo.localized_name == "Terra"){
                    planetContent.text = "Tipo: Planeta\n" +
                             "Altitude: " + planetInfo.altitude + "\n" +
                             "Azimute: " + planetInfo.azimuth + "\n" +
                             "Constelação: " + planetInfo.iauConstellation + "\n" +
                             "Distância do sol: " + planetInfo.heliocentric_distance_km + "\n" +
                             "Magnitude: " + planetInfo.vmag + "\n";
                } else {
                    planetContent.text = "Tipo: Planeta\n" +
                             "Altitude: " + planetInfo.altitude + "\n" +
                             "Azimute: " + planetInfo.azimuth + "\n" +
                             "Albedo: " + planetInfo.albedo + "\n" +
                             "Constelação: " + planetInfo.iauConstellation + "\n" +
                             "Nascer: " + planetInfo.rise + "\n" +
                             "Pôr: " + planetInfo.set + "\n" +
                             "Distância em UA: " + planetInfo.distance + "\n" +
                             "Distância em Km: " + planetInfo.distance_km + "\n" +
                             "Distância do sol: " + planetInfo.heliocentric_distance_km + "\n" +
                             "Magnitude: " + planetInfo.vmag + "\n";
                }
                
                             
                yield return new WaitForSeconds(1);

            }
        
    }


    public float GetMagintude(){

            float roundedValue = Mathf.Round(Magnitude * 10f) / 10f;
            return roundedValue;

    }

    public int GetAltitudeGeo(){

            int roundedValue = Mathf.RoundToInt(AltitudeGeometrica);
            return roundedValue;

    }


    public float GetAzimute(){

            float roundedValue = Mathf.Round(Azimute * 10f) / 10f;
            return roundedValue;

    }


    public int GetDistanciaTerra(){

            int roundedValue = Mathf.RoundToInt(DistanciaTerra);
            return roundedValue/1000000;

    }



}

