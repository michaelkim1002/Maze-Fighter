using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Projectile3 : MonoBehaviour
{
    public float speed=100.0f;
	public Rigidbody pro;
	public Transform sp;
    public Transform sp2;
    public Transform sp3;
	public bool loaded;
	public AmmoBar ab;
	public int x;
	public  float countdown;
    public  float delay;
	public bool shot;
	void Start()
	{
		
	//	pro.tag=("grenades");
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
					//shot=true;
                //countdown-=Time.deltaTime;
                if(countdown<=0||!shot)
                {
                Shoot();
				
            	//countdown=delay;

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
	
			ab.decrease(x);
		Rigidbody proj = (Rigidbody)Instantiate(pro, sp.position, sp.rotation);
        Rigidbody proj2 = (Rigidbody)Instantiate(pro, sp2.position, sp2.rotation);
        Rigidbody proj3 = (Rigidbody)Instantiate(pro, sp3.position, sp3.rotation);
		proj.velocity = sp.TransformDirection(new Vector3(0,0,speed)); 
        proj2.velocity = sp2.TransformDirection(new Vector3(0,0,speed)); 
        proj3.velocity = sp3.TransformDirection(new Vector3(0,0,speed)); 
		shot=true;

	}
}
