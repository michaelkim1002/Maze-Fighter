using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LaserScript : MonoBehaviour
{
    public GameObject laserprefab;
    public Transform firepoint;
    private GameObject spawnlaser;
    public AmmoBar ab;
    public  float countdown;
    public  float countdown2;
    public  float delay;
    public  float delay2;
	public int x;
    public float range= 100f;
	public Camera fpsCam;
    public  float damage = 1f;
    public GameObject impactEffect;
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
                 ShootImpact();
                 ab.decrease(x);
			}
        if(Input.GetButton("Fire1"))
        {
           if(firepoint!=null)
            {
                countdown-=Time.deltaTime;
                countdown2-=Time.deltaTime;
                ShootImpact();
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
                 laserprefab.transform.position=firepoint.transform.position;
             }
        }
        if(Input.GetButtonUp("Fire1"))
        {
            laserprefab.SetActive(false);
          countdown=delay;
           countdown2=delay2;
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
     void ShootImpact()
	{
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
            GameObject impactgo=Instantiate(impactEffect,hit.point,Quaternion.LookRotation(hit.normal));
            Destroy(impactgo,6f);
		}
	}
   
}
