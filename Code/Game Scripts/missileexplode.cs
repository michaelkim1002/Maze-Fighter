using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class missileexplode : MonoBehaviour
{
    
    public GameObject effect;
    
	public float blast=5f;
	public float force=700f;
	public  float damage=5f;
	private Rigidbody rb;
    // Start is called before the first frame update
	void Start()
	{
		rb=GetComponent<Rigidbody>();
	}
	void Update()
	{
		
	}
    // Update is called once per frame
    public void OnTriggerEnter()
    {
		//Instantiate(effect, transform.position, transform.rotation);
		//Destroy(gameObject);
		Instantiate(effect, transform.position, transform.rotation);
		Collider[] collidersD =Physics.OverlapSphere(transform.position,blast);
		foreach (Collider nearbyObject in collidersD)
		{
			destroyedbox d=nearbyObject.GetComponent<destroyedbox>();
			if(d!=null)
			{
				d.Destroy();
			}
		}
		Collider[] collidersM =Physics.OverlapSphere(transform.position,blast);
		foreach (Collider nearbyObject in collidersM)
		{
			Rigidbody rb=nearbyObject.GetComponent<Rigidbody>();
			if(rb!=null)
			{
				rb.AddExplosionForce(force,transform.position,blast);
			}
		}
		//Instantiate(effect, transform.position, transform.rotation);
		Collider[] collidersDa =Physics.OverlapSphere(transform.position,blast);
		foreach (Collider nearbyObject in collidersDa)
		{
			Health target= nearbyObject.transform.GetComponent<Health>();
			if(target!=null)
			{
				target.TakeDamage(damage);
			}
		}

		Destroy(gameObject);
    }
}

