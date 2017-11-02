using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_for_Candle : MonoBehaviour {

    public Collider coll;
    public static bool bl_IsHit;


    void Start()
    {
        coll = GetComponent<Collider>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (coll.Raycast(ray, out hit, 100.0F))
            {
                bl_IsHit = true;
            }
        }
    }
}
