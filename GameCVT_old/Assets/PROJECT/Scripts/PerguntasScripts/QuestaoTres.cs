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

    }

    void Update()
    {



        dropdown.onValueChanged.AddListener(delegate {

            Pontuacao = verificaDropDown(dropdown);
            perguntas.GetComponent<Pergunta>().play(3);
            return;
        });

        
    }


    public int verificaDropDown(TMP_Dropdown dropdown){

       
        if ( dropdown.value == 2 ) {
            return 20;
        }

        return 0;
    }

}
