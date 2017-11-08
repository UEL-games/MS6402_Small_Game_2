using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Movement : MonoBehaviour {

    bool bl_IsDown;

	// Use this for initialization
	void Start () {

        bl_IsDown = false;

    }
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetKeyDown(KeyCode.LeftArrow)) && (bl_IsDown == false))
        {
            transform.Rotate(new Vector2(0, 90));
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow)) && (bl_IsDown == false))
        {
            transform.Rotate(new Vector2(0, -90));
        }
        if ((Input.GetKeyDown(KeyCode.DownArrow)) && (bl_IsDown == false))
        {
            transform.Rotate(new Vector2(90, 0));
            bl_IsDown = true;
        }
        if ((Input.GetKeyDown(KeyCode.UpArrow)) && (bl_IsDown == true))
        {
            transform.Rotate(new Vector2(-90, 0));
            bl_IsDown = false;
        }

    }
}
