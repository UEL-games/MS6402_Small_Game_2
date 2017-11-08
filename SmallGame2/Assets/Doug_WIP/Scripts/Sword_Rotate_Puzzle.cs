using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Rotate_Puzzle : MonoBehaviour {

    static GameObject go_Sword1;
    Sword_Rotate Sword1;
    public int in_Sword1Rot;
    private bool bl_Sword1;

    static GameObject go_Sword2;
    Sword_Rotate Sword2;
    public int in_Sword2Rot;
    private bool bl_Sword2;

    static GameObject go_Sword3;
    Sword_Rotate Sword3;
    public int in_Sword3Rot;
    private bool bl_Sword3;

    static GameObject go_Sword4;
    Sword_Rotate Sword4;
    public int in_Sword4Rot;
    private bool bl_Sword4;


    public bool bl_AllCorrect;

    // Use this for initialization
    void Start () {

        go_Sword1 = GameObject.Find("Sword1");
        Sword1 = go_Sword1.GetComponent<Sword_Rotate>();

        go_Sword2 = GameObject.Find("Sword2");
        Sword2 = go_Sword2.GetComponent<Sword_Rotate>();

        go_Sword3 = GameObject.Find("Sword3");
        Sword3 = go_Sword3.GetComponent<Sword_Rotate>();

        go_Sword4 = GameObject.Find("Sword4");
        Sword4 = go_Sword4.GetComponent<Sword_Rotate>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Sword1.in_isrotated == in_Sword1Rot)
        {
            bl_Sword1 = true;
        }
        if (Sword2.in_isrotated == in_Sword2Rot)
        {
            bl_Sword2 = true;
        }
        if (Sword3.in_isrotated == in_Sword3Rot)
        {
            bl_Sword3 = true;
        }
        if (Sword4.in_isrotated == in_Sword4Rot)
        {
            bl_Sword4 = true;
        }
        if ((bl_Sword1 == true) && (bl_Sword2 == true) && (bl_Sword3 == true) && (bl_Sword4 == true))
        {
            bl_AllCorrect = true;
        }
       


    }

    void IsCorrect(string Sword)
    {
        Debug.Log(Sword);
        
    }
}
