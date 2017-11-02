using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAdd : MonoBehaviour
{
    public Collider coll;
    public static bool bl_IsHit;
    private GameObject[] PCInventory;
    private int num;

    void Start()
    {
        Camera.main.GetComponent<Inventory>().PC_Inventory = PCInventory;
        
        coll = GetComponent<Collider>();
    }


    void Update()
    {
        GameObject HitItem;
        Debug.Log(bl_IsHit);
        if (Input.GetMouseButtonDown(0))
        {
            //raycast to mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //if raycast hits collider, return true 
            if (coll.Raycast(ray, out hit, 100.0F))
            {
                //HitItem = coll.gameObject;
                bl_IsHit = true;
                break;
            }
        }
        if (bl_IsHit)
        {
           // PCInventory[num] = HitItem;
        }
    }
}
