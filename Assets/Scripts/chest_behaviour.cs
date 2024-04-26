using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_behaviour : MonoBehaviour
{
    public GameObject chest_opening_lid;
    bool will_open = false;
    bool closed;


    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e") && will_open )
        {
             animator.SetTrigger("Open");
        }
    }



    private void OnTriggerExit (Collider other)
       {
        will_open = false;
       }

       private void OnTriggerEnter (Collider other)
       {
        will_open = true;
       }
}
