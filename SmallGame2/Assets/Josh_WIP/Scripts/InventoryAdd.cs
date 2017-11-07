using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAdd : MonoBehaviour
{
    public Collider coll;
    public static bool bl_IsHit;
    public List<GameObject> PCInventory = new List<GameObject>();
    public bool InInv = false;
    private int num;
    public GameObject InvPanel;
    public GameObject EquipPanel;

    void Start()
    {
        Camera.main.GetComponent<Inventory>().PC_Inventory = PCInventory;
        coll = GetComponent<Collider>();
    }


    void Update()
    {
        PlaceInInventory();
        EquipItem();
        
    }

    void PlaceInInventory()
    {

        if (Input.GetMouseButtonDown(1))
        {
            //raycast to mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //if raycast hits collider, return true 
            if (coll.Raycast(ray, out hit, 100.0F))
            {

                bl_IsHit = true;
                //Debug.Log(bl_IsHit);
                if (bl_IsHit)
                {
                    GameObject HitItem = coll.gameObject;
                    //Debug.Log(HitItem);
                    //Camera.main.GetComponent<Inventory>().PC_Inventory.Add(HitItem);
                    Camera.main.GetComponent<Inventory>().AddItem(HitItem);         // IF HIT ADD ITEM TO INVENTORY LIST
                    InInv = true;  // SET BOOLEAN ININVENTORY TO TRUE
                    HitItem.transform.position = InvPanel.transform.position;    // MOVE OBJECT TO INVENTORY PANEL SLOT
                    coll.gameObject.SetActive(false);   // tURN OBJECT OFF IN SCENE / PUT IN INVENTORY
                }
            }
            else
            {
                bl_IsHit = false;
            }
        }
    }

    void EquipItem()
    {
        if (!Camera.main.GetComponent<Inventory>().Equipped)
        {
            if (Input.GetMouseButtonDown(0) && InInv)
            {

                //raycast to mouse position
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                //if raycast hits collider, return true 
                if (coll.Raycast(ray, out hit, 100.0F))
                {

                    bl_IsHit = true;
                    if (bl_IsHit)
                    {
                        GameObject HitItem = coll.gameObject;
                        Camera.main.GetComponent<Inventory>().Equipped = true;
                        InInv = false;
                        HitItem.transform.position = EquipPanel.transform.position;    // MOVE OBJECT TO Equipped PANEL SLOT
                        coll.gameObject.SetActive(false);   // tURN OBJECT OFF IN SCENE / PUT IN INVENTORY
                    }
                }
                else
                {
                    bl_IsHit = false;
                }
            }          
        }
        if (Camera.main.GetComponent<Inventory>().Equipped)
        {
            if (Input.GetMouseButtonDown(0) && !InInv)
            {
                //raycast to mouse position
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                //if raycast hits collider, return true 
                if (coll.Raycast(ray, out hit, 100.0F))
                {

                    bl_IsHit = true;
                    if (bl_IsHit)
                    {
                        GameObject HitItem = coll.gameObject;
                        Camera.main.GetComponent<Inventory>().Equipped = false;
                        InInv = true;
                        HitItem.transform.position = InvPanel.transform.position;    // MOVE OBJECT TO INVENTORY PANEL SLOT
                        coll.gameObject.SetActive(false);   // tURN OBJECT OFF IN SCENE / PUT IN INVENTORY
                    }
                }
                else
                {
                    bl_IsHit = false;
                }
            }
        }
        
    }
    
}
