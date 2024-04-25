using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Audio : MonoBehaviour
{

    public AudioClip waterSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(waterSound);
            Debug.Log("player detected");
        }
    }

     private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().Stop();
            Debug.Log("player out of water");
        }
    }

  
}
