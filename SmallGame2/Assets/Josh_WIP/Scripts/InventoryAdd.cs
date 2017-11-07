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
    //public GameObject InvPanel;
    public GameObject EquipPanel;

    void Start()
    {
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
                    for (int i = 0; i < Camera.main.GetComponent<Inventory>().InvPanels.Count; i++)
                    {
                        if (Camera.main.GetComponent<Inventory>().InvPanels[i] != null)
                        {
                            HitItem.transform.position = Camera.main.GetComponent<Inventory>().InvPanels[Camera.main.GetComponent<Inventory>().SlotNum].transform.position;
                            break;
                        }
                    }
                    num = Camera.main.GetComponent<Inventory>().SlotNum;
                    Camera.main.GetComponent<Inventory>().SlotNum++;
                    //HitItem.transform.position = InvPanel.transform.position;    // MOVE OBJECT TO INVENTORY PANEL SLOT
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
        if (!Camera.main.GetComponent<Inventory>().Equipped) // IF NOT EQUIPPED THEN EQUIP IT
        {
            if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.LeftShift) && InInv)  //IF IT IS CLICKED ON AND IN THE INVENTORY THEN EQUIP IT
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
        if (Camera.main.GetComponent<Inventory>().Equipped)  // IF ITEM IS EQUIPPED AND CLICKED ON THEN UNEQUIP IT
        {
            if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.LeftShift)  && !InInv)
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
                        Camera.main.GetComponent<Inventory>().Equipped = false;   // SET EQUIPPED TO FALSE
                        InInv = true;
                        HitItem.transform.position = Camera.main.GetComponent<Inventory>().InvPanels[num].transform.position;    // MOVE OBJECT BACK TO INVENTORY PANEL SLOT
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
