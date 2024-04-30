using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startingUI : MonoBehaviour
{
    public GameObject ui;
    
    void Start()
    {
        ShowUI();
        StartCoroutine(closeUI());
    }

    IEnumerator closeUI() 
    {
        yield return new WaitForSeconds(5);
        HideUI();
    }



   
    void Update()
    {
        
    }

    private void ShowUI()
    {
        ui.SetActive(true);
    }

    private void HideUI()
    {
        ui.SetActive(false);
    }

}
