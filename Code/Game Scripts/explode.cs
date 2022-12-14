using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    public float delay =3f;
    public GameObject effect;
    float countdown;
	public float blast=5f;
	public float force=700f;
	public  float damage = 10f;
    bool exploded=false;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown-=Time.deltaTime;
        if(countdown<=0f&&!exploded)
        {
            Explode();
            exploded=true;
        }
    }
    void Explode()
    {
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
