using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle_Order : MonoBehaviour {

    private int in_Current_Value;

   
    static GameObject go_candle1;                                //Creates a GameObject class for Candle1
    Raycast_for_Candle Candle1;                                  //Creates Candle1 Class
    private int in_candle1 = 1;

    
    static GameObject go_candle2;
    Raycast_for_Candle Candle2;
    private int in_candle2 = 2;

    
    static GameObject go_candle3;
    Raycast_for_Candle Candle3;
    private int in_candle3 = 3;

   


    void Start()
    {
        in_Current_Value = 0;

       go_candle1 = GameObject.Find("Candle1");                  //Find The Object in the Scene
       Candle1 = go_candle1.GetComponent<Raycast_for_Candle>(); //Find the components of the object

       go_candle2 = GameObject.Find("Candle2");
       Candle2 = go_candle2.GetComponent<Raycast_for_Candle>();

       go_candle3 = GameObject.Find("Candle3");
       Candle3 = go_candle3.GetComponent<Raycast_for_Candle>();

    }


     void Update()
    {
        //Debug.Log(in_Current_Value);
        if ((Candle1.bl_Is_Hit == true) && (in_Current_Value == (in_candle1-1)))
        {
            in_Current_Value += 1;
            Debug.Log("Candle 1 Lit");
        }
        if ((Candle2.bl_Is_Hit == true) && (in_Current_Value == (in_candle2-1)))
        {
            in_Current_Value += 1;
            Debug.Log("Candle 1 and 2 Lit");
        }
        if ((Candle3.bl_Is_Hit == true) && (in_Current_Value == (in_candle3-1)))
        {
            in_Current_Value += 1;
            Debug.Log("Candle 1,2 & 3 Lit");
        }
       /* else
        {
            in_Current_Value = 0;
            Candle1.bl_Is_Hit = false;
            Candle2.bl_Is_Hit = false;
            Candle3.bl_Is_Hit = false;
            Debug.Log("Candles Reset");
        } */
        


    }

}
