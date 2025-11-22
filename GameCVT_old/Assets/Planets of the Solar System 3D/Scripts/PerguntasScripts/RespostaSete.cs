using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RespostaSete : MonoBehaviour
{



    public bool score;
    public bool valor;

        
    public bool Valor(){
        return valor;   
    }
    public bool Score(){
        return score  ;
    }

    void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(() => greenOrRed(transform.gameObject.tag));
    }



    public void greenOrRed(string tag){


        switch (tag)
        {
            case "Verdadeiro":
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
