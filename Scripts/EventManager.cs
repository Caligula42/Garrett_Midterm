using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	public delegate void ChangeColour(string colour);
    public static event ChangeColour colourChange;
    
    void OnControllerColliderHit(ControllerColliderHit collider)
    {
        if (collider.gameObject.tag == "Green") {
            colourChange("Green");
        }
        else if (collider.gameObject.tag == "Blue") {
            colourChange("Blue");
        }
    
    }
}
