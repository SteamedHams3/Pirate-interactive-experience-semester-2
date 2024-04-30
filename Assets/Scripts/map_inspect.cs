using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_inspect : MonoBehaviour
{
    public AudioClip mapVoice;
    public GameObject ui;
    bool will_play_map;
    
    void Start()
    {
        HideUI();
    }

 
    void Update()
    {
        if(Input.GetKeyDown("e") && will_play_map)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(mapVoice);
        }
        }
    

    

    private void OnTriggerEnter (Collider other)
       {
        will_play_map = true;
        ShowUI();
    
       }

    private void OnTriggerExit (Collider other)
       {
        will_play_map = false;
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
