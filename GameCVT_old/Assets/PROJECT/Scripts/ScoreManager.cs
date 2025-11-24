using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
using System;


public class ScoreManager : MonoBehaviour
{
    private readonly string password = ".#$paceCVT_D@nil0_kisl@n#._";
    private string getEndPoint = "http://192.168.31.100:80/SpaceCVT_Data/ServerConnection.php";
    private string sendEndPoint = "http://192.168.31.100:80/SpaceCVT_Data/ServerSendConnection.php";
    private UnityWebRequest httpGet;
    private UnityWebRequest httpPost;
    private string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    [SerializeField] private string username;
    [SerializeField] private int finalScore; 
    [SerializeField] private List<int> pontos = new List<int>(5); // pontos individuais

    public List<int> Pontos {
        get => pontos; 
        set => pontos = value;
    }
    


    void Start()
    {
        // SubmitScore();
        // StartCoroutine(GetDataBaseInfo());
    }

    public void SubmitScore()
    {
        StartCoroutine(SendInfoToDataBase());
    }




    public IEnumerator GetDataBaseInfo()
    {

        httpGet = UnityWebRequest.Get(getEndPoint);
        yield return httpGet.SendWebRequest(); // yield � parecido com o await

        string res = httpGet.downloadHandler.text;
        Debug.Log(res);
    }





    private IEnumerator SendInfoToDataBase()
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("scorePost", finalScore);
        form.AddField("timePost", time);
        form.AddField("passwordPost", password);

        httpPost = UnityWebRequest.Post(sendEndPoint, form);
        yield return httpPost.SendWebRequest();

        if(httpPost.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(httpPost.error);
        } else
        {
            string res = httpPost.downloadHandler.text;
            Debug.Log(res);
        }


        httpPost.Dispose(); // finaliza requisção para n ocupar memória;
    }

    
}
