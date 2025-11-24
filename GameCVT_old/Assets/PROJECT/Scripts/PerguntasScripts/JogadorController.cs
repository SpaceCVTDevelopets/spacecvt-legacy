using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class JogadorController : MonoBehaviour

{

    public TextMeshProUGUI textoFinal;
    public bool Ativo = false;

    public List<GameObject> perguntas = new List<GameObject>();

    void Update()
    {


        if ( Ativo ){
            
            Jogador player = criaJogador();
            Ativo = false;
            return;

        }

    }




    public Jogador criaJogador(){

        Jogador jogador = new Jogador(
            perguntas[0].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[1].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[2].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[3].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[4].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[5].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[6].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[7].GetComponent<QuestaoMae>().Pontuacao
        );



        int pontos = jogador.pontuacaoTotal(); 

        if (pontos != 0){

            for(int i = 1; i <= pontos; i++){
                textoFinal.text = i+" pontos";
            } 

        } else {
            textoFinal.text = "0 pontos";
        }
        

        return jogador;

    }


    public bool GetAtivo(){
        return Ativo;
    }
    public void SetAtivo(bool ativo){
        Ativo = ativo;
    }



    public void Restart(){
        SceneManager.LoadScene("CVTE");
    }


}
