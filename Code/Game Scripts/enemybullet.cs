using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
  
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
   
}
