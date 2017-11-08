using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle_Order : MonoBehaviour {

    public bool bl_AllLit = false;
    private int in_Current_Value;                                 //Creates an int for testing

   
    static GameObject go_candle1;                                //Creates a GameObject class for Candle1
    Raycast_for_Candle Candle1;                                  //Creates Candle1 Class
    private int in_candle1 = 1;                                  //Creates an int for testing

    
    static GameObject go_candle2;
    Raycast_for_Candle Candle2;
    private int in_candle2 = 2;

    
    static GameObject go_candle3;
    Raycast_for_Candle Candle3;
    private int in_candle3 = 3;


    static GameObject go_candle4;
    Raycast_for_Candle Candle4;
    private int in_candle4 = 4;

    static GameObject go_candle5;
    Raycast_for_Candle Candle5;
    private int in_candle5 = 5;

    static GameObject go_candle6;
    Raycast_for_Candle Candle6;
    private int in_candle6 = 6;

    static GameObject go_candle7;
    Raycast_for_Candle Candle7;
    private int in_candle7 = 7;

    static GameObject go_candle8;
    Raycast_for_Candle Candle8;
    private int in_candle8 = 8;



    void Start()
    {
        in_Current_Value = 0;

       go_candle1 = GameObject.Find("Candle1");                  //Find The Object in the Scene
       Candle1 = go_candle1.GetComponent<Raycast_for_Candle>(); //Find the components of the object

       go_candle2 = GameObject.Find("Candle2");
       Candle2 = go_candle2.GetComponent<Raycast_for_Candle>();

       go_candle3 = GameObject.Find("Candle3");
       Candle3 = go_candle3.GetComponent<Raycast_for_Candle>();

       go_candle4 = GameObject.Find("Candle4");
       Candle4 = go_candle4.GetComponent<Raycast_for_Candle>();

       go_candle5 = GameObject.Find("Candle5");
       Candle5 = go_candle5.GetComponent<Raycast_for_Candle>();

       go_candle6 = GameObject.Find("Candle6");
       Candle6 = go_candle6.GetComponent<Raycast_for_Candle>();

       go_candle7 = GameObject.Find("Candle7");
       Candle7 = go_candle7.GetComponent<Raycast_for_Candle>();

       go_candle8 = GameObject.Find("Candle8");
       Candle8 = go_candle8.GetComponent<Raycast_for_Candle>();


    }


    void Update()
    {     

        if ((Candle2.bl_Is_Hit == true) && (Candle1.bl_Is_Hit == false))                //if the current candle is pressed and the previous has not been pressed then reset all
        {
            CandleOff();
        }
        if ((Candle3.bl_Is_Hit == true) && (Candle2.bl_Is_Hit == false))
        {
            CandleOff();
        }
        if((Candle4.bl_Is_Hit == true) && (Candle3.bl_Is_Hit == false))
        {
            CandleOff();
        }
       if((Candle5.bl_Is_Hit == true) && (Candle4.bl_Is_Hit == false))
        {
            CandleOff();
        }
       if((Candle6.bl_Is_Hit == true) && (Candle5.bl_Is_Hit == false))
        {
            CandleOff();
        }
       if((Candle7.bl_Is_Hit == true) && (Candle6.bl_Is_Hit == false))
        {
            CandleOff();
        }
       if((Candle8.bl_Is_Hit == true) && (Candle7.bl_Is_Hit == false))
        {
            CandleOff();
        }
        else if ((Candle8.bl_Is_Hit == true) && (Candle7.bl_Is_Hit == true))
        {
            bl_AllLit = true;
        }





        if ((Candle1.bl_Is_Hit == true) && (in_Current_Value == 0) )        //Testing if order works
        {
            in_Current_Value += 1;
            Debug.Log("Candle 1 Lit");
        }
        if ((Candle2.bl_Is_Hit == true) && (in_Current_Value == 1)) 
        {
            in_Current_Value += 1;
            Debug.Log("Candle 1 and 2 Lit");
        }
        if ((Candle3.bl_Is_Hit == true) && (in_Current_Value == 2)) 
        {
            in_Current_Value += 1;
            Debug.Log("Candle 1,2 & 3 Lit");
        }      
    }

    private void CandleOff()                                //Resets all Hit Bools
    {
        in_Current_Value = 0;
        Candle1.bl_Is_Hit = false;
        Candle2.bl_Is_Hit = false;
        Candle3.bl_Is_Hit = false;
        Candle4.bl_Is_Hit = false;
        Candle5.bl_Is_Hit = false;
        Candle6.bl_Is_Hit = false;
        Candle7.bl_Is_Hit = false;
        Candle8.bl_Is_Hit = false;
        Debug.Log("All Candles OFF");
    }

    private void CandleLit()   
    {
     Debug.Log("Candle Lit");
    }

}


