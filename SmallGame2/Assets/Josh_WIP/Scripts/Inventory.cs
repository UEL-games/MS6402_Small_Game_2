using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject[] PC_Inventory = new GameObject[5];
    public int InvNum = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void AddItem()
    {
        InvNum++;
    }
}
