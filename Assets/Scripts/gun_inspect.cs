using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_inspect : MonoBehaviour
{
    public AudioClip gunVoice;
    public GameObject ui;
    bool will_play_gun;
    
    void Start()
    {
        HideUI();
    }

 
    void Update()
    {
        if(Input.GetKeyDown("e") && will_play_gun)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(gunVoice);
        }
        }
    

    

    private void OnTriggerEnter (Collider other)
       {
        will_play_gun = true;
        ShowUI();
    
       }

    private void OnTriggerExit (Collider other)
       {
        will_play_gun = false;
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
