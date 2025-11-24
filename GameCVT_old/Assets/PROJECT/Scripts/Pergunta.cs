using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pergunta : MonoBehaviour
{

    [SerializeField] private List<GameObject> listPerguntas = new List<GameObject>();
    private GameObject endGamePanel;
    private GameObject goToPontuacaoPanel;
    public GameObject perguntas;


    void Awake()
    {
        endGamePanel =  GameObject.Find("EndGame");
        goToPontuacaoPanel = GameObject.Find("GoToPontuacao");
        
    }



    void Start()
    {

        perguntas = GameObject.Find("Perguntas");
        
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform pergunta = transform.GetChild(i);
            listPerguntas.Add(pergunta.gameObject);

            if (i != 0)
            {
                pergunta.gameObject.SetActive(false); // deixa todas as perguntas invisíveis
            } 

            endGamePanel.SetActive(false);
            
        }

        play(0);

    }

    public void play(int pergunta){

        if (pergunta == 0){
            listPerguntas[pergunta].SetActive(true);

        } else if ( pergunta == 6 ) {

            //ativar tela de fim de jogo

            listPerguntas[pergunta-1].SetActive(false); //apague a última
            endGamePanel.SetActive(true); // ative a tela de fim de jogo

            endGamePanel.GetComponentsInChildren<JogadorController>()[0].criaJogador();

        } else if (pergunta == 7) {
            // se for mostrar pontuação
            
            perguntas.SetActive(false);
            
            goToPontuacaoPanel.SetActive(false); // desativa o painel de skip para a pontuação
            endGamePanel.SetActive(true);  // ativa o painel de pontuação

            endGamePanel.GetComponentsInChildren<JogadorController>()[0].criaJogador();
        } else {
            
            listPerguntas[pergunta-1].SetActive(false);
            listPerguntas[pergunta].SetActive(true);
            

        }


    }

        
  
        

}




