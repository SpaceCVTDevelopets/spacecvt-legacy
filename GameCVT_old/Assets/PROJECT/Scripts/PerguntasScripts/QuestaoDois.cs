using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestaoDois : QuestaoMae
{

    public GameObject perguntas;

    [SerializeField] private List<GameObject> respostas = new List<GameObject>(2);


    void Start()
    {   
        Pontuacao = 0;

        for (int i = 0; i < respostas.Count; i++)
        {
            VerificaResposta(respostas[i]); // atribui um listener para cada botão
        }
    }



    public void VerificaResposta(GameObject resposta){

        Button btn = resposta.transform.GetComponent<Button>();
        btn.onClick.AddListener(() => OnRespostaClick(resposta));

    }



    private void OnRespostaClick(GameObject resposta)
    {

        greenOrRed(resposta.tag, resposta); 

        Debug.Log(Pontuacao);
        perguntas.GetComponent<Pergunta>().play(2);
        
    }



    private void greenOrRed(string tag, GameObject obj){
        switch (tag)
        {
            case "Verdadeiro":
                Pontuacao = 20;
                green(obj);
                break;
            default:
                red(obj);
                break;
        }
        
    }



    public void green(GameObject objeto){
        ColorBlock colors = objeto.GetComponent<Button>().colors;
        colors.normalColor = Color.green;
        objeto.GetComponent<Button>().colors = colors;
    }

    public void red(GameObject objeto){
        ColorBlock colors = objeto.GetComponent<Button>().colors;
        colors.normalColor = Color.red;
        objeto.GetComponent<Button>().colors = colors;
    }


}
