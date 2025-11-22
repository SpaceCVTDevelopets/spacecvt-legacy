using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pergunta : MonoBehaviour
{

    private List<GameObject> perguntas = new List<GameObject>();


    void Start()
    {

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform pergunta = transform.GetChild(i);
            perguntas.Add(pergunta.gameObject);
            if (i != 9) { 
                pergunta.gameObject.SetActive(false);
            } else {
                pergunta.gameObject.SetActive(true);
            }


        }

        play(0);

    }

    public void play(int pergunta){

        if (pergunta == 0){
            perguntas[pergunta].SetActive(true);

        } else if ( pergunta == 8 ) {

            //ativar tela de fim de jogo

            perguntas[pergunta-1].SetActive(false);
            perguntas[pergunta].SetActive(true);
            perguntas[pergunta].GetComponentsInChildren<JogadorController>()[0].SetAtivo(true);

        } else if (pergunta == 9) {

            for (int i = 0; i < perguntas.Count; i++){
                perguntas[i].SetActive(false);
            }


            perguntas[pergunta].SetActive(false);
            perguntas[pergunta-1].SetActive(true);

            perguntas[pergunta-1].GetComponentsInChildren<JogadorController>()[0].SetAtivo(true);
        } else {
            
            perguntas[pergunta-1].SetActive(false);
            perguntas[pergunta].SetActive(true);
            

        }


    }

        
  
        

}




