using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuestaoQuatro : QuestaoMae
{
    public GameObject perguntas;
    public GameObject sliderObj;
    public TextMeshProUGUI texto;
    private Slider slider;
    public GameObject botaoObj; //
    private Button botao;

    public ShowInfo planetInfo = new ShowInfo();

    
    void Start()
    {

        if (sliderObj != null && botaoObj != null) {
            slider = sliderObj.GetComponent<Slider>(); 
            botao = botaoObj.GetComponent<Button>();
        }
        Pontuacao = 0;
        slider.value = 0;
        texto.text = "0°";

        VerificaResposta();
        FormataSlider();

    }




    public void VerificaResposta(){
        
        botao.onClick.AddListener(() => OnRespostaClick());

    }


    public void OnRespostaClick()
    {
        int altitudePlaneta = planetInfo.GetAltitudeGeo();
            
        if ( slider.value == altitudePlaneta) {
            Pontuacao = 20;

        } 
        Debug.Log(Pontuacao);
        perguntas.GetComponent<Pergunta>().play(4);
            
    }




    public void FormataSlider(){

        slider.onValueChanged.AddListener(delegate {

            texto.text = slider.value.ToString("0")+"°";
            
        });

    }


}
