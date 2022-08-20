using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winganimation : MonoBehaviour
{
    public float countdown=1f;
    public float delay=1f;
    public PlayMode swing;
    
    void Update()
    {
        countdown-=Time.deltaTime;
        if(countdown<=0)
       {
           
                 
                   GetComponent<Animation>().Play(swing);
             countdown=delay;
                   
                
             
        }
    }
}
