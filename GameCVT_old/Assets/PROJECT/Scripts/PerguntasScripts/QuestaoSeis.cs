using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestaoSeis : QuestaoMae
{
    // Start is called before the first frame update
    public GameObject perguntas;
    private List<Toggle> toggles = new List<Toggle>();




    void Start()
    {
        Transform content = transform;
        Pontuacao = 0;
        for (int i = 0; i < content.childCount - 1; i++){

            Transform listItem = content.Find("ListItem"+i+"/OffsetAnchor/BooleanToggle");
            toggles.Add(listItem.GetComponent<Toggle>());

        }
    }


    void Update()
    {
        if (verificaContent()){
            Debug.Log(Pontuacao);
            perguntas.GetComponent<Pergunta>().play(6);
            return;
        }
    }






     public bool verificaContent(){


        for (int j = 0; j < toggles.Count; j++){

            if (toggles[j].isOn){
                if (j == 1){
                    Pontuacao = 10;
                    return true;
                }  

                return true;
                
            }

        }

        return false;

    }
}
