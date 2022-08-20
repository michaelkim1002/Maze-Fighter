using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float delay =1f;
	public float countdown=1f;
	public float blast=5f;
	public float force=700f;
	public  float damage = 10f;
	bool exploded=false;
   public void OnTriggerEnter()
	{
		
			
		Collider[] collidersDa =Physics.OverlapSphere(transform.position,blast);
		foreach (Collider nearbyObject in collidersDa)
		{
			Health target= nearbyObject.transform.GetComponent<Health>();
			if(target!=null)
			{
                countdown=-Time.deltaTime;
                if(countdown<=0)
                {
				target.TakeDamage(damage);
                countdown=delay;
                }
			}
		}
		Collider[] collidersD =Physics.OverlapSphere(transform.position,blast);
		foreach (Collider nearbyObject in collidersD)
		{
			destroyedbox d=nearbyObject.GetComponent<destroyedbox>();
			if(d!=null)
			{
				d.Destroy();
			}
		}
	}
}
