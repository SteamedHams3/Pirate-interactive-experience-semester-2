using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starfruit_falling : MonoBehaviour
{
   
  public Animator animator;
  public AudioClip starfruitFall;
  public AudioClip pirateReaction;
   

   bool will_play_fruit_sound = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !will_play_fruit_sound)
        {
           StartCoroutine(starfruitDrop());
        }
    }

    IEnumerator starfruitDrop()
    {
         animator.SetTrigger("FruitFalling");
         yield return new WaitForSeconds(1);
         gameObject.GetComponent<AudioSource>().PlayOneShot(starfruitFall);
         yield return new WaitForSeconds(0.5f);
          gameObject.GetComponent<AudioSource>().PlayOneShot(pirateReaction);
         will_play_fruit_sound = true;
    }
}
