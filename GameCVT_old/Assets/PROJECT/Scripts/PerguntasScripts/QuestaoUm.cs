using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class QuestaoUm : QuestaoMae
{
    // verificar se todos campos de content foram respondidos

    public GameObject perguntas;
    public List<ShowInfo> planetasInfo = new List<ShowInfo>();
    [SerializeField] private List<GameObject> enunciados = new List<GameObject>(3);
    [SerializeField] private List<GameObject> respostas = new List<GameObject>(8);

    private bool[] jaRespondida;
    private int count = 0; // quantas perguntas já foram respondidas

    


    void Start()
    {   
        Pontuacao = 0;
        jaRespondida = new bool[respostas.Count];

        for (int i = 0; i < respostas.Count; i++)
        {
            VerificaResposta(respostas[i], i); // atribui um listener para cada botão
        }
    }


    

    public void VerificaResposta(GameObject resposta, int indice){

        Button btn = resposta.transform.GetComponent<Button>();
        btn.onClick.AddListener(() => OnRespostaClick(indice, resposta));

    }



    private void OnRespostaClick(int index, GameObject resposta)
    {
        // se já respondeu essa, não faz nada
        if (jaRespondida[index]) 
            return;


        jaRespondida[index] = true; // marca como respondida
        greenOrRed(resposta.tag, resposta); 
        count++;
        if (count == 4)
        {
            Debug.Log(Pontuacao);
            perguntas.GetComponent<Pergunta>().play(1);
        }
    }






    private void greenOrRed(string tag, GameObject obj){
        switch (tag)
        {
            case "Netune":
            case "Jupiter":
            case "Saturn":
            case "Mercury":
                Pontuacao += 5;
                green(obj);
                break;

            default:
                red(obj);
                break;
        }
        
    }




    public void criaTexto() {


        TextMeshProUGUI textoNetuno = enunciados[0].GetComponent<TextMeshProUGUI>();
        string infoNetuno = planetasInfo[0].GetMagintude().ToString(); 
        textoNetuno.text = "A magnitude de Netuno é de aproximadamente "+infoNetuno; // Netuno


        TextMeshProUGUI textoUrano = enunciados[1].GetComponent<TextMeshProUGUI>();
        string infoUrano = planetasInfo[1].GetAzimute().ToString();
        textoUrano.text = "O ângulo de azimute de Urano é aproximadamente "+infoUrano; // Urano


        TextMeshProUGUI textoSaturno = enunciados[2].GetComponent<TextMeshProUGUI>();
        string infoSaturno = planetasInfo[2].GetDistanciaTerra().ToString();
        textoSaturno.text = "A distância de Saturno em relação a terra é de "+ infoSaturno +" milhões de Km."; // Saturno


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
