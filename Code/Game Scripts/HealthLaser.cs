using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthLaser : MonoBehaviour
{
    public GameObject laserprefab;
    public Transform firepoint;
    private GameObject spawnlaser;
    public AmmoBar ab;
    public  float countdown;
    public  float countdown2;
    public  float delay;
    public  float delay2;
     public  float countdown3;
    public  float delay3;
	public int x;
    public float range= 100f;
	public Camera fpsCam;
    public  float damage = 1f;
    public Healthbar hb;
    void Start()
    {
        countdown=delay;
         countdown2=delay2;
         ab.ua();
         laserprefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ab.aa(x);
		if(ab.isloaded())
		{
       if(Input.GetButtonDown("Fire1"))
			{
				 laserprefab.SetActive(true); 
                 Shoot();
                 ab.decrease(x);
			}
        if(Input.GetButton("Fire1"))
        {
           if(firepoint!=null)
            {
                countdown-=Time.deltaTime;
                countdown2-=Time.deltaTime;
                countdown3-=Time.deltaTime;
                
                if(countdown<=0)
                if(countdown<=0)
                {
                ab.decrease(x);
                countdown=delay;
                }
                if(countdown2<=0)
                {
                Shoot();
                countdown2=delay2;
                }
                if(countdown3<=0)
                {
                LifeSteal();
                countdown3=delay3;
                }
               
                 laserprefab.transform.position=firepoint.transform.position;
             }
        }
        if(Input.GetButtonUp("Fire1"))
        {
            laserprefab.SetActive(false);
          countdown=delay;
           countdown2=delay2;
           countdown3=delay3;

        }
        }
        else
        {
             laserprefab.SetActive(false);
        }
    }
     void Shoot()
	{
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
    void LifeSteal()
    {
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
			Health target= hit.transform.GetComponent<Health>();
			if(target!=null)
			{
                hb.takeDamage(-1);
                
			}
             
		}
	}
}
