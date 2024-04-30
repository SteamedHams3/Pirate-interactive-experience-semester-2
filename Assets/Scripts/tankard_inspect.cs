using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankard_inspect : MonoBehaviour
{
    public AudioClip tankardVoice;
    public GameObject ui;
    bool will_play_tankard;
    
    void Start()
    {
        HideUI();
    }

 
    void Update()
    {
        if(Input.GetKeyDown("e") && will_play_tankard)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(tankardVoice);
        }
        }
    

    

    private void OnTriggerEnter (Collider other)
       {
        will_play_tankard = true;
        ShowUI();
    
       }

    private void OnTriggerExit (Collider other)
       {
        will_play_tankard = false;
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
