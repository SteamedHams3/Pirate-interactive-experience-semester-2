using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starfruit_inspect : MonoBehaviour
{
   
 public AudioClip starfruitVoice;
    public GameObject ui;
    bool will_play_starfruit;
    
    void Start()
    {
        HideUI();
    }

 
    void Update()
    {
        if(Input.GetKeyDown("e") && will_play_starfruit)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(starfruitVoice);
        }
        }
    

    

    private void OnTriggerEnter (Collider other)
       {
        will_play_starfruit = true;
        ShowUI();
    
       }

    private void OnTriggerExit (Collider other)
       {
        will_play_starfruit = false;
        HideUI();
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

