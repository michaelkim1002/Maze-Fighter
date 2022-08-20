using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriticalBullet : MonoBehaviour
{
    public float chance;
    public float delay =3f;
	float countdown;
	public float blast=5f;
	public float force=700f;
	public  float damage = 10f;
	bool exploded=false;
	private Rigidbody rb;
    public float prob;
	public float multiplier;
    void Start()
    {
        chance=Random.Range(0.0f, 10.0f);
        rb=GetComponent<Rigidbody>();
    }

    void Update()
	{
		
	}
	public void OnTriggerEnter()
	{
		
			
		Collider[] collidersDa =Physics.OverlapSphere(transform.position,blast);
		foreach (Collider nearbyObject in collidersDa)
		{
			Health target= nearbyObject.transform.GetComponent<Health>();
			if(target!=null)
			{
                if(chance<=prob)
                    {
                        target.TakeDamage(damage*multiplier);
                    }
                else
                {
                        target.TakeDamage(damage);
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
		Destroy(gameObject);
	}
}
