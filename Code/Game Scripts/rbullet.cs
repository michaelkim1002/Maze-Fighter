using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbullet : MonoBehaviour
{
     public Transform sp;
    public Rigidbody rb;
    public float speed=75f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void OnTriggerEnter()
	{
		Destroy(gameObject);
	}
   public void destroybullet()
   {
       Destroy(gameObject);
   }
   public void reflect()
   {
       Rigidbody proj = (Rigidbody)Instantiate(rb, sp.position, sp.rotation);
		        proj.velocity = sp.TransformDirection(new Vector3(0,0,speed)); 
   }
    
}
