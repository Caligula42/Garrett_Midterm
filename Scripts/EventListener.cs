using UnityEngine;
using System.Collections;

public class EventListener : MonoBehaviour {

    void colourChange(string colour) {
        if (colour == "Green")
        {
            renderer.material.color = Color.red;
        }

        else if (colour == "Blue")
        {
            renderer.material.color = Color.yellow;
        }
    
    }
    void OnDisable()
    {
        EventManager.colourChange -= colourChange;
    }
    void OnEnable()
    {
        EventManager.colourChange += colourChange;
    }
	
}
