using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> PC_Inventory = new List<GameObject>();
    public bool Showing = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowInventory();
    }

    public void AddItem(GameObject clicked)
    {
        Debug.Log("Adding!");
        PC_Inventory.Add(clicked);
    }

    public void ShowInventory()
    {
        if (Input.GetKeyDown("i") && Showing == true)
        {

            for (int i = 0; i < PC_Inventory.Count; i++)
            {

                Debug.Log("I WAS PRESSED");
                PC_Inventory[i].SetActive(false);
                Showing = false;
            }
            
        }
        else if (Input.GetKeyDown("i") && Showing == false)
        {
            for (int i = 0; i < PC_Inventory.Count; i++)
            {

                PC_Inventory[i].SetActive(true);
                Showing = true;
            }
            
        }
    }

}
