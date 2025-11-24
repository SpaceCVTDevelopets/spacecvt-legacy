using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarPontuacao : MonoBehaviour
{

    public Button botao;
    public GameObject perguntas;




    void Start()
    {
        verificaBotao();
    }


    public void verificaBotao(){

        botao.onClick.AddListener(delegate {
            perguntas.GetComponent<Pergunta>().play(7);
        });

    }
}
