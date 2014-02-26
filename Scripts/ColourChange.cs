using UnityEngine;
using System.Collections;

public class ColourChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (gameObject.tag == "Blue")
        {
            renderer.material.color = Color.blue;
        }
        else if (gameObject.tag == "Green") {
            renderer.material.color = Color.green;
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
