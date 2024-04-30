using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_falling : MonoBehaviour
{

   public Animator animator;
   public AudioClip ballSound;
   public AudioClip pirateScared;

   bool will_play_sound = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !will_play_sound)
        {
           StartCoroutine(ballFalling());
        }
    }

    IEnumerator ballFalling()
    {
         animator.SetTrigger("Fall");
         yield return new WaitForSeconds(0.5f);
         gameObject.GetComponent<AudioSource>().PlayOneShot(ballSound);
         yield return new WaitForSeconds(0.5f);
          gameObject.GetComponent<AudioSource>().PlayOneShot(pirateScared);
         will_play_sound = true;
    }
}
