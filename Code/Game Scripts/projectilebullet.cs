using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class projectilebullet : MonoBehaviour
{
	public float delay =3f;
	float countdown;
	public float blast=5f;
	public float force=700f;
	public  float damage = 10f;
	bool exploded=false;
	private Rigidbody rb;
	void Start()
	{
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
				target.TakeDamage(damage);
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
