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
    private bool Acabou = false;
    
    void Start()
    {

        if (sliderObj != null && botaoObj != null) {
            slider = sliderObj.GetComponent<Slider>(); 
            botao = botaoObj.GetComponent<Button>();
        }
        Pontuacao = 0;
        slider.value = 0;
        texto.text = "0°";
    }


    void Update()
    {
        slider.onValueChanged.AddListener(delegate {

            verificaSlider(slider);
            
        });


        if ( verificaBotao(slider) ) {
            perguntas.GetComponent<Pergunta>().play(4);

            return;
        }


    }




    public void verificaSlider(Slider slider){

        texto.text = slider.value.ToString("0")+"°";

    }





    public bool verificaBotao(Slider slider){
        
        botao.onClick.AddListener(delegate {

            int altitudePlaneta = planetInfo.GetAltitudeGeo();
            
            if ( slider.value == altitudePlaneta) {
                Pontuacao = 20;

            } else {
                Pontuacao = 0;
            }
              
            Acabou = true;

        });

        return Acabou;

    }
}
