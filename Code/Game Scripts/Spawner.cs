using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
     public float countdown=7f;
    public float delay=7f;
   public Rigidbody pro;
   public Transform sp;
    
    void Update()
    {
        countdown-=Time.deltaTime;
        if(countdown<=0)
       {
           
                 
        Rigidbody proj = (Rigidbody)Instantiate(pro, sp.position, sp.rotation);
		proj.velocity = sp.TransformDirection(new Vector3(0,0,0)); 
             countdown=delay;
                   
                
             
        }
    }
}
