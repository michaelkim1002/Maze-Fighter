using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class glaivedamage : MonoBehaviour
{
	public float blast=5f;
	public float force=10f;
	public  float damage = 10f;
	bool exploded=false;
	private Rigidbody rb;
    public  float countdown;
    public  float delay;
	// Start is called before the first frame update
	void Start()
	{
		rb=GetComponent<Rigidbody>(); 
		
	}
	void Update()
	{
     	//countdown=-Time.deltaTime;
        if(countdown<=0)
        {
            Destroy(gameObject);
        }
		
	}
	// Update is called once per frame
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
		
	}
}
