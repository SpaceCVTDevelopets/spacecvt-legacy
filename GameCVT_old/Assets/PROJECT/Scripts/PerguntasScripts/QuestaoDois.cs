using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestaoDois : QuestaoMae
{

    public GameObject perguntas;



    void Update()
    {
        bool acabou = verificaContent();

        if (acabou == true)
        {
            perguntas.GetComponent<Pergunta>().play(2);
            return;
        }

    }


    public bool verificaContent()
    {

        Transform content = transform;
        bool terminou = false;

        for (int i = 1; i < content.childCount; i++)
        {

            Transform listItem = content.GetChild(i);

            for (int j = 0; j < listItem.childCount; j++)
            {

                Transform resposta = listItem.GetChild(0);
                bool acertou = resposta.GetChild(j).GetComponent<RespostaDois>().Score;
                terminou = resposta.GetChild(j).GetComponent<RespostaDois>().Valor;

                //NAO ENTENDO COMO ISSO TA FUNCIONANDO
                if (acertou)
                {
                    Pontuacao = 15;
                    return true;
                }
                else if (terminou)
                {
                    return true;
                }

            }
        }



        return terminou;
    }

}
