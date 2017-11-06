using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> PC_Inventory = new List<GameObject>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            for (int i = 0; i < PC_Inventory.Count; i++)
            {
                if (PC_Inventory[i].name != null)
                {
                    Debug.Log(PC_Inventory[i].name + "TEST");
                }
            }

        }
    }

    public void AddItem(GameObject clicked)
    {
        Debug.Log("Adding!");
        PC_Inventory.Add(clicked);
    }
}
