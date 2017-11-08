using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Rotate : MonoBehaviour {

    
    private int in_isrotated;

    static GameObject go_Sword;
    Raycast_for_Candle Sword;

    // Use this for initialization
    void Start () {

      

        go_Sword = GameObject.Find(gameObject.name);
        Sword = go_Sword.GetComponent<Raycast_for_Candle>();

    }

    // Update is called once per frame
    void Update () {

        if (Sword.bl_Is_Hit == true)
        {
            transform.Rotate(new Vector3(0,0,-45));
            Sword.bl_Is_Hit = false;
            in_isrotated += 1;
        }
        if (in_isrotated >= 8)
        {
            in_isrotated = 0;
        }
        
		
	}
}
