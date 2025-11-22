using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class QuestaoUm : QuestaoMae
{
    public GameObject perguntas;
    public List<GameObject> sliderObjs = new List<GameObject>();
    // public TextMeshProUGUI texto;
    private List<Slider> sliders = new List<Slider>();
    public GameObject botaoObj;
    private Button botao;


    public List<ShowInfo> planetasInfo = new List<ShowInfo>();
    private bool acabou = false;

    void Start()
    {
        

        for (int i = 0; i < sliderObjs.Count; i++)
        {   
            Transform textTransform = sliderObjs[i].transform.GetChild(2);
            textTransform.GetComponent<TextMeshProUGUI>().text = "0.0°";

            if (sliderObjs != null)
            {
                sliders.Add(sliderObjs[i].GetComponent<Slider>());
                sliders[i].value = 0.0f;
            }
            else
            {
                Debug.Log("Slider não encontrado");
            }

        }

        botao = botaoObj.GetComponent<Button>();
        Pontuacao = 0;
    }


    void Update()
    {


        sliders[0].onValueChanged.AddListener(delegate
        {
            verificaSlider(sliders[0]);
        });
        sliders[1].onValueChanged.AddListener(delegate
        {
            verificaSlider(sliders[1]);
        });
        sliders[2].onValueChanged.AddListener(delegate
        {
            verificaSlider(sliders[2]);
        });

        verificaBotao(botao, sliders);

        if (acabou)
        {
            perguntas.GetComponent<Pergunta>().play(1);
            return;
        }


    }

    public void verificaSlider (Slider slider) {


        float roundedValue = Mathf.Round(slider.value * 10f) / 10f;
        slider.value = roundedValue; // Atualiza o valor do slider

        Transform textTransform = slider.transform.GetChild(2);

        textTransform.GetComponent<TextMeshProUGUI>().text = slider.value.ToString("0.0") + "°";

    }


    public void verificaBotao(Button botao, List<Slider> sliders)
    {


        float slider1 = sliders[0].value;
        float slider2 = sliders[1].value;
        float slider3 = sliders[2].value;




        botao.onClick.AddListener(delegate{

            float MagnitudeJupiter = planetasInfo[0].GetMagintude();
            float MagnitudeMarte = planetasInfo[1].GetMagintude();
            float MagnitudeVenus = planetasInfo[2].GetMagintude();

            // Tem que ser por text mesmo
            if (slider1 == MagnitudeJupiter && slider2 == MagnitudeMarte && slider3 == MagnitudeVenus)
            {
                Pontuacao = 10;

            }
            acabou = true;
        });

    }
}
