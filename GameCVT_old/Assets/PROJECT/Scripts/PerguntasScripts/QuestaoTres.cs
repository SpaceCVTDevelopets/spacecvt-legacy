using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class QuestaoTres: QuestaoMae
{
    // verificar se todos campos de content foram respondidos

    public GameObject perguntas;
    public GameObject resposta;

    private TMP_Dropdown dropdown;

    void Start()
    {
        Pontuacao = 0;
        dropdown = resposta.GetComponent<TMP_Dropdown>();
        VerificaResposta();

    }



    public void VerificaResposta()
    {
        dropdown.onValueChanged.AddListener(delegate { verificaDropDown(); }); //por algum motivo n consegui colocar arrowFunction nesse listener, o OnValueChanged
    }



    public void verificaDropDown(){

       
        if ( dropdown.value == 2 ) {
            Pontuacao = 20;
        }
        Debug.Log(Pontuacao);
        perguntas.GetComponent<Pergunta>().play(3);


    }

}
