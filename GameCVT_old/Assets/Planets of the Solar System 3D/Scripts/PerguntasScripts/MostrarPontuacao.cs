using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarPontuacao : MonoBehaviour
{

    public Button botao;
    public GameObject perguntas;
    private bool Acabou = false;
    void Start()
    {
        
    }


    void Update()
    {
        if ( verificaBotao(botao) ){
            return;
        }

    }


    public bool verificaBotao(Button botao){

        botao.onClick.AddListener(delegate {
            perguntas.GetComponent<Pergunta>().play(9);
            Acabou = true;
        });

        return Acabou;
        
    }
}
