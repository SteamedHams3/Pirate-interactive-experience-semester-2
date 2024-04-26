using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_behaviour : MonoBehaviour
{
    public GameObject chest_opening_lid;
    public GameObject ui;
    bool will_open = false;
    bool closed;


    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e") && will_open )
        {
             animator.SetTrigger("Open");
             HideUI();
        }
    }



    private void OnTriggerExit (Collider other)
       {
        will_open = false;
        HideUI();
       }

       private void OnTriggerEnter (Collider other)
       {
        will_open = true;
        ShowUI();
    
       }


       public void HideUI()
       {
         ui.SetActive(false);
       }

       public void ShowUI()
       {
         ui.SetActive(true);
       }
}
