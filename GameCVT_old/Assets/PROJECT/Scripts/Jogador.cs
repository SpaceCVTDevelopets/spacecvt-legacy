using System.IO;
using Newtonsoft.Json;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]

public class Jogador
{



    [SerializeField]
    private int quest1;
    [SerializeField]
    private int quest2;
    [SerializeField]
    private int quest3;
    [SerializeField]
    private int quest4;
    [SerializeField]
    private int quest5;
    [SerializeField]
    private int quest6;
    [SerializeField]
    private int quest7;
    [SerializeField]
    private int quest8;

    [SerializeField]
    private int scoreFinal;

    public int jogo = 0;

    public Jogador(int quest1 = 0, int quest2 = 0, int quest3 = 0, int quest4 = 0, int quest5 = 0, int quest6 = 0, int quest7 = 0, int quest8 = 0)
    {
        this.quest1 = quest1;
        this.quest2 = quest2;
        this.quest3 = quest3;
        this.quest4 = quest4;
        this.quest5 = quest5;
        this.quest6 = quest6;
        this.quest7 = quest7;
        this.quest8 = quest8;
    }


    public int Quest1
    {
        get { return Quest1; }
        set { Quest1 = value; }
    }

    public int Quest2
    {
        get { return Quest2; }
        set { Quest2 = value; }
    }

    public int Quest3
    {
        get { return Quest3; }
        set { Quest3 = value; }
    }

    public int Quest4
    {
        get { return Quest4; }
        set { Quest4 = value; }
    }

    public int Quest5
    {
        get { return Quest5; }
        set { Quest5 = value; }
    }

    public int Quest6
    {
        get { return Quest6; }
        set { Quest6 = value; }
    }

    public int Quest7
    {
        get { return Quest7; }
        set { Quest7 = value; }
    }


    public int Quest8
    {
        get { return Quest8; }
        set { Quest8 = value; }
    }


    public void SetJogo(int jogo){
        this.jogo = jogo;
    }


    public void Save(int player = 0){

        if (jogo != 0){
            player = jogo;
        }
        string json = JsonUtility.ToJson(this, true);
        string path = Application.dataPath + "/Jogadores/Jogador"+player+".txt";
        
        PlayerPrefs.SetString("Jogador", json);

        File.WriteAllText(path, json);
    }





    public int pontuacaoTotal()
    {
        scoreFinal = quest1 + quest2 + quest3 + quest4 + quest5 + quest6 + quest7 + quest8;
        return scoreFinal;
    }



}