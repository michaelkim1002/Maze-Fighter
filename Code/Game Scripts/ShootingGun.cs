using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShootingGun : MonoBehaviour
{
	public  float damage = 10f;
	public float range= 100f;
	public Transform sp;
	public Camera fpsCam;
	public ParticleSystem ps;
	public bool loaded;
	public AmmoBar ab;
	public int x;
	public  float countdown;
    public  float delay;
	public bool shot;
	void Start()
	{
		
		ab.ua();
	}
     void Update()
	{
		ab.aa(x);
		if(ab.isloaded()||x==0)
			{
		if(Input.GetButtonDown("Fire1")&&countdown==1)
			{
				
					Shoot(); 
					shot=true;
			}
			if(Input.GetButton("Fire1"))
        	{
           		if(sp!=null)
            	{
					
                if(countdown<=0||!shot)
                {
                Shoot();
				
                }
             	}
        	}
			}
			if(shot)
            	{
        		countdown-=Time.deltaTime;
				if(countdown<=0)
				{
				
					countdown=delay;
					shot=false;
				}
				}

	}
	void Shoot()
	{
		ps.Play();
		ab.decrease(x);
		shot=true;
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
			Health target= hit.transform.GetComponent<Health>();
			if(target!=null)
			{
				target.TakeDamage(damage);

			}
		}
	}

}