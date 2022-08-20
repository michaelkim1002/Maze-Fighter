using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class flamingbullet : MonoBehaviour
{
 public float delay =3f;
	public GameObject effect;
	//public float countdown;
	public float blast=5f;
	public float force=700f;
	public  float damage = 10f;
	bool exploded=false;
	private Rigidbody rb;
	public Transform emit;
	// Start is called before the first frame update
	void Start()
	{
		rb=GetComponent<Rigidbody>();
	}
	public void OnTriggerEnter()
	{
		 GameObject imp=Instantiate(effect, emit.position, emit.rotation);
			Destroy(imp,6f);
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
