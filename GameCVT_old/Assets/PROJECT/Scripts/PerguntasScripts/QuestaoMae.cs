using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestaoMae : MonoBehaviour
{
    private int QuestionPoints = 0;
    public int Pontuacao
    { 
        get{
            return QuestionPoints;
        }
        set{
            QuestionPoints = value;
        } 
    }
}
