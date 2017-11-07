using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> PC_Inventory = new List<GameObject>();
    public bool Showing = true;
    public List<GameObject> InvPanels = new List<GameObject>();
    public bool Equipped = false;
    public int SlotNum;

    // Use this for initialization
    void Start()
    {
        SlotNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ShowInventory();
        for (int i = 0; i < PC_Inventory.Count; i++)
        {
            if (PC_Inventory[i].activeSelf == false && Showing == true)   // CHECK IF INVENTORY IS SHOWING. IF IT IS SHOW NEW ITEMS
            {
                PC_Inventory[i].SetActive(true);
            }
        }
    }

    public void AddItem(GameObject clicked)
    {
        //Debug.Log("Adding!");
        PC_Inventory.Add(clicked);
    }

    public void ShowInventory()
    {
        
        if (Input.GetKeyDown("i") && Showing == true)       // IF I IS PRESSED AND INVENTORY IS SHOWING TURN IT OFF
        {

            for (int i = 0; i < PC_Inventory.Count; i++)
            {

                //Debug.Log("I WAS PRESSED");
                foreach (GameObject panel in InvPanels)
                {
                    panel.SetActive(false);
                }
                PC_Inventory[i].SetActive(false);
                Showing = false;
            }
            
        }
        else if (Input.GetKeyDown("i") && Showing == false)   // ELSE IF I IS PRESSED AND INVENTORY IS NOT SHOWING THEN TURN IT ON
        {
            for (int i = 0; i < PC_Inventory.Count; i++)
            {
                foreach (GameObject panel in InvPanels)
                {
                    panel.SetActive(true);
                }
                PC_Inventory[i].SetActive(true);
                Showing = true;
            }
            
        }
    }

}
