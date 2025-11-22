using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class QuestaoSete : QuestaoMae
{
    // Start is called before the first frame update

    public GameObject perguntas;
    public List<GameObject> botoes = new List<GameObject>();


    // Update is called once per frame
    void Update()
    {

        int acabou = verificaBotoes();   

        if (acabou == 2){
        
            perguntas.GetComponent<Pergunta>().play(7);
            return;
        }
        

    }


    public int verificaBotoes(){

        int count = 0;
        int pontuacao = 0;



            for (int j = 0; j < botoes.Count; j++){


                bool acertou = botoes[j].GetComponent<RespostaSete>().Score();
                bool respondeu = botoes[j].GetComponent<RespostaSete>().Valor();

                if( acertou ){
                    pontuacao +=5;
                    count++;
                } else if( respondeu ){
                    count++;
                }
            }

            Pontuacao = pontuacao;


        return count;

    }


    
}
