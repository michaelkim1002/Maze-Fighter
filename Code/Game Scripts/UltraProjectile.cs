using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UltraProjectile : MonoBehaviour
{
    	  public float chance;
	public float speed=100.0f;
	public Rigidbody[] pro;
    public float size;
	public Transform sp;
	public bool loaded;
	public AmmoBar ab;
	public int x;
	public  float countdown;
    public  float delay;
	public bool shot;
    //public int num;
	void Start()
	{
	//	chance=Random.Range(0.0f, size);
	//	pro.tag=("grenades");
		ab.ua();
		shot=false;
        size=pro.Length;
	}


  void Update()
	{
		chance=(int)Random.Range(0.0f, size);
		ab.aa(x);
		if(ab.isloaded()||x==0)
		{
		if(Input.GetButtonDown("Fire1")&&countdown==1)
			{
					Shoot();
					shot=true;
					chance=(int)Random.Range(0.0f, size);
					
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
				chance=(int)Random.Range(0.0f, size);
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
		Rigidbody proj = (Rigidbody)Instantiate(pro[(int)chance], sp.position, sp.rotation);
		proj.velocity = sp.TransformDirection(new Vector3(0,0,speed)); 
		shot=true;

	}
}
