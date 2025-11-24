using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestaoCinco : QuestaoMae
{

    public GameObject perguntas;
    private List<Toggle> toggles = new List<Toggle>();


    void Start()
    {
        Transform content = transform;
        Pontuacao = 0;
        for (int i = 1; i < content.childCount; i++){

            Transform listItem = content.Find("ListItem"+i+"/OffsetAnchor/BooleanToggle");
            toggles.Add(listItem.GetComponent<Toggle>());

        }
    }


    void Update()
    {
        if (verificaContent()){
            Debug.Log(Pontuacao);
            perguntas.GetComponent<Pergunta>().play(5);

            return;
        }
    }






     public bool verificaContent(){


        for (int j = 0; j < toggles.Count; j++){

            if (toggles[j].isOn){
                if (j == 2){
                    Pontuacao = 10;
                    return true;
                }  

                return true;
                
            }

        }

        return false;

    }
}
