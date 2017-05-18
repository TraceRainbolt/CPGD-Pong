using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

	void Update () {
		Vector3 mouse = Input.mousePosition;	//	Get the mouse position (in screen coordinates)
        mouse.z = 10;							//	Specifiy the z coordinate
												
		//	Translate to world coordinates and follow the mouse's y position
        transform.position = new Vector2(transform.position.x, Camera.main.ScreenToWorldPoint(mouse).y);	
	}

}
