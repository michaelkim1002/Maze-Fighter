using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChargedGun : MonoBehaviour
{
    	public float speed=100.0f;
	public Rigidbody pro;
	public Transform sp;
	public bool loaded;
	public AmmoBar ab;
	public int x;
	public  float countdown;
    public  float delay;
	public bool shot;
      public GameObject ps;
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
		if(Input.GetButtonDown("Fire1"))
			{
					
                    ps.SetActive(true);
                   
					
					
					
			}
			if(Input.GetButton("Fire1"))
        	{
           		if(sp!=null)
            	{ 
					countdown-=Time.deltaTime;
					//shot=true;
					//shot=true;
                //countdown-=Time.deltaTime;
                
                 ps.SetActive(true);
                   
                
                 
             	}
        	}
            if(Input.GetButtonUp("Fire1"))
        	{
				if(countdown<=0)
					{
					Shoot();
					}
            countdown=delay;
			shot=false;
              ps.SetActive(false);
                    
					
        }
		}
		//if(shot)
            	//{
        		//
			//	if(countdown<=0)
			//	{
				
					
				//}
				//}
		
	}
	void Shoot()
	{
	
			ab.decrease(x);
		Rigidbody proj = (Rigidbody)Instantiate(pro, sp.position, sp.rotation);
		proj.velocity = sp.TransformDirection(new Vector3(0,0,speed)); 
		shot=true;

	}
}
