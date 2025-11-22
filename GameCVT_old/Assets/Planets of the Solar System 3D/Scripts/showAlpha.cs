using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class showAlpha : MonoBehaviour
{

    Animation showAnim;
    public GameObject Earth;
    
    // Start is called before the first frame update
    void Start()
    {
        // Initialize the showAnim variable by getting the Animation component from the Earth GameObject
        showAnim = Earth.GetComponent<Animation>();
        showAnim["showPlanet"].speed = 0;
    }


    public void Show()
    {
        showAnim["showPlanet"].speed = 2;
        showAnim["showPlanet"].time = 0;
        showAnim.Play("showPlanet");
    }
}
