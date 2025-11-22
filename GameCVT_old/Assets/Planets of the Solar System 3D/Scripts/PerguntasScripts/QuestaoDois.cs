using System.Collections;
using System.Collections.Generic;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
public class QuestaoDois : QuestaoMae
{
    // verificar se todos campos de content foram respondidos

    public GameObject perguntas;
    public List<ShowInfo> planetasInfo = new List<ShowInfo>();
    public List<GameObject> respostas = new List<GameObject>();

    private int pontuacao;




    void Update()
    {


        pontuacao = 0;

        criaTexto();

        int acabou = verificaContent(); 


        
        if (acabou == 4){
            Pontuacao = pontuacao;

            perguntas.GetComponent<Pergunta>().play(2);
            return;
        }

        
    }


    public int verificaContent(){

        Transform content = transform;
        int count = 0;

        for (int i = 0; i < content.childCount; i++){

            Transform listItem = content.GetChild(i);

            for (int j = 0; j < listItem.childCount; j++){

                Transform resposta = listItem.GetChild(0);
                bool acertou = resposta.GetChild(j).GetComponent<Resposta>().Score;
                bool score = resposta.GetChild(j).GetComponent<Resposta>().Valor;

                if( acertou ){
                    pontuacao += 5;
                    count++;
                } else if( score ){
                    count++;
                }
            }
        }

        return count;
    }



    public void criaTexto() {




        TextMeshProUGUI textoNetuno = respostas[0].GetComponent<TextMeshProUGUI>();
        string infoNetuno = planetasInfo[0].GetMagintude().ToString(); 
        textoNetuno.text = "A magnitude de Netuno é de aproximadamente "+infoNetuno; // Netuno


        TextMeshProUGUI textoUrano = respostas[1].GetComponent<TextMeshProUGUI>();
        string infoUrano = planetasInfo[1].GetAzimute().ToString();
        textoUrano.text = "O ângulo de azimute de Urano é aproximadamente "+infoUrano; // Urano


        TextMeshProUGUI textoSaturno = respostas[2].GetComponent<TextMeshProUGUI>();
        string infoSaturno = planetasInfo[2].GetDistanciaTerra().ToString();
        textoSaturno.text = "A distância de Saturno em relação a terra é de "+ infoSaturno +" milhões de Km."; // Saturno


    }

}
