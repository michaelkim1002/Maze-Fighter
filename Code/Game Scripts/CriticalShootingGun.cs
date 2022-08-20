using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CriticalShootingGun : MonoBehaviour
{
    	public  float damage = 10f;
	public float range= 100f;
	public Transform sp;
	public Camera fpsCam;
	public ParticleSystem ps;
    public ParticleSystem ps2;
	public bool loaded;
	public AmmoBar ab;
	public int x;
	public  float countdown;
    public  float delay;
	public bool shot;
    public float chance;
	void Start()
	{
		chance=Random.Range(0.0f, 10.0f);
		ab.ua();
	}
     void Update()
	{
		ab.aa(x);
		if(ab.isloaded()||x==0)
			{
		if(Input.GetButtonDown("Fire1")&&countdown==1)
			{
				if(chance<=1.5)
                    {
                        CriticalShoot();
                    }
                    else
                        {
                        Shoot();
                        }
					shot=true;
			}
			if(Input.GetButton("Fire1"))
        	{
           		if(sp!=null)
            	{
					
                if(countdown<=0||!shot)
                {
                    if(chance<=1.5)
                    {
                        CriticalShoot();
                    }
                    else
                        {
                        Shoot();
                        }
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
        chance=Random.Range(0.0f, 10.0f);
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
    void CriticalShoot()
	{
		ps2.Play();
		ab.decrease(x);
		shot=true;
		RaycastHit hit;
        chance=Random.Range(0.0f, 10.0f);
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
			Health target= hit.transform.GetComponent<Health>();
			if(target!=null)
			{
                    target.TakeDamage(damage*6);
			}
		}
	}
}
