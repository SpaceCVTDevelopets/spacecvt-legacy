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



    public Jogador criaJogador(){

        Jogador jogador = new Jogador(
            perguntas[0].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[1].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[2].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[3].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[4].GetComponent<QuestaoMae>().Pontuacao,
            perguntas[5].GetComponent<QuestaoMae>().Pontuacao
        );



        int pontos = jogador.pontuacaoTotal(); 

        if (pontos != 0){

            textoFinal.text = pontos+" pontos";

        } else {
            textoFinal.text = "0 pontos";
        }
        

        return jogador;

    }




    public void Restart(){
        SceneManager.LoadScene("CVTE");
    }


}
