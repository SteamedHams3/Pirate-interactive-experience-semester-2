using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_behaviour : MonoBehaviour
{
    public AudioClip chestSound;
    public AudioClip pirateChest;
    public GameObject ui;

    bool will_open = false;
    


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
           StartCoroutine(ChestOpening());
        }
    }

    IEnumerator ChestOpening()
    {
             animator.SetTrigger("Open");
             gameObject.GetComponent<AudioSource>().PlayOneShot(chestSound);
             HideUI();
             yield return new WaitForSeconds(1);
              gameObject.GetComponent<AudioSource>().PlayOneShot(pirateChest);
              will_open = false;
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
