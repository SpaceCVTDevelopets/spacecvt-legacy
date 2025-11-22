using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resposta : MonoBehaviour
{

    [SerializeField]
    private bool score;

    [SerializeField]
    private bool valor;


    public bool Valor{
        get { return valor; }  
    }
    public bool Score{
        get { return score; }  
    }

    public void Start(){

        transform.GetComponent<Button>().onClick.AddListener(() => greenOrRed(transform.gameObject.tag));

    }


    private void greenOrRed(string tag){

        switch (tag)
        {
            case "Netune":
                valor = true;
                score = true;
                green();
                
                break;
            case "Jupiter":
                valor = true;
                score = true;
                green();

                break;
            case "Saturn":
                valor = true;
                score = true;
                green();

                break;

            case "Mercury":
                valor = true;
                score = true;
                green();
                
                break;
            default:
                valor = true;
                score = false;
                red();
                break;
        }
        
    }


    public void green(){
        ColorBlock colors = transform.GetComponent<Button>().colors;
        colors.normalColor = Color.green;
        transform.GetComponent<Button>().colors = colors;
    }

    public void red(){
        ColorBlock colors = transform.GetComponent<Button>().colors;
        colors.normalColor = Color.red;
        transform.GetComponent<Button>().colors = colors;
    }



}



