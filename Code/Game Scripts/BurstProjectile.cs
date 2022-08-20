using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BurstProjectile : MonoBehaviour
{
    public float speed=100.0f;
	public Rigidbody pro;
	public Transform sp;
	public bool loaded;
	public AmmoBar ab;
	public int x;
	public  float countdown;
    public  float delay;
    public  float countdown2=0.2f;
    public  float delay2=0.2f;
	public bool shot;
	void Start()
	{
		ab.ua();
		shot=false;
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
                countdown2=-Time.deltaTime;
                if(countdown2==0.1)
				{
				
					Shoot();
				}if(countdown2==0)
				{
				
					Shoot();
                    countdown2=delay2;
				}
				if(countdown<=0)
				{
				
					countdown=delay;
					shot=false;
				}
			}
	}
	void Shoot()
	{
       
			ab.decrease(x);
		Rigidbody proj = (Rigidbody)Instantiate(pro, sp.position, sp.rotation);
		proj.velocity = sp.TransformDirection(new Vector3(0,0,speed)); 
		shot=true;

	}
}
