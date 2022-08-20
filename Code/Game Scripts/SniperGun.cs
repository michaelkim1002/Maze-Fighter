using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SniperGun : MonoBehaviour
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
    public GameObject aim;
    public GameObject saim;
    public GameObject scope;
    public bool usingscope=false;
    public MLook sense;
	void Start()
	{
		saim.SetActive(false);
		ab.ua();
	}
     void Update()
	{
      aim.SetActive(false);
		ab.aa(x);
        if(Input.GetButtonDown("Fire2"))
			{
				if(!usingscope)
                {
                saim.SetActive(true);
                sense.Scope(6);
                scope.SetActive(true);
                usingscope=true;
                }
                else
                {
                    saim.SetActive(false);
                sense.unScope(6);
                scope.SetActive(false);
                usingscope=false;
                
                }
					
			}
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
		saim.SetActive(false);
        sense.unScope(6);
        scope.SetActive(false);
        usingscope=false;
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
    public void snipe()
    {
         saim.SetActive(false);
                scope.SetActive(false);
                usingscope=false;
    }

}
