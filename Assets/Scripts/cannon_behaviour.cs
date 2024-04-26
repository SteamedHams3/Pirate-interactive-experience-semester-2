using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon_behaviour : MonoBehaviour
{

    public AudioClip cannonShot; 
    public GameObject ui;
    bool will_fire = false;   

    void Start()
    {
        HideUI();
    }

   
    void Update()
    {
       if(Input.GetKeyDown("e") && will_fire )
        {
             gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);
             HideUI();
        } 
    }

private void OnTriggerExit (Collider other)
       {
        will_fire = false;
        HideUI();
       }

       private void OnTriggerEnter (Collider other)
       {
        will_fire = true;
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
