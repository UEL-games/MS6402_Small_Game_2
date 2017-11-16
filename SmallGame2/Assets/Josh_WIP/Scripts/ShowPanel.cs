using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;
    public bool IsVisible = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hide()
    {
        button.SetActive(true);
        panel.SetActive(false);
        IsVisible = false;
    }

    public void Show()
    {
        button.SetActive(false);
        panel.SetActive(true);
        IsVisible = true;
    }
}
