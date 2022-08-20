using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collisiondamage : MonoBehaviour
{
   public Healthbar hb;
   public ShieldBar sb;
   public GameObject potion;
	public AmmoBar ab;
	public GameObject hurts;
	float countdown;
	public float delay =3f;
	public bool hurt;
	public bool shield;
	
	//public GameObject orb;
	void Start()
	{
		countdown=delay;
		hurt=false;
		shield=false;
	}
	void Update()
	{
		if(hurt)
		{
		Hs();
		}
		if(countdown<=0)
		{
			hurts.SetActive(false);
			hurt=false;
			countdown=delay;
		}

	}
   void OnCollisionEnter(Collision col)
   {
	   
       if(col.gameObject.tag=="enemy")
       {
		if(!shield)
		{
           if(hb)
           {
               hb.takeDamage(2);
				Destroy(col.gameObject);
				hurt=true;
           }
		}
		if(shield)
		{
			if(sb)
			{
				sb.takeSDamage(2);
				Destroy(col.gameObject);
			}
		}
	   }
	   if(col.gameObject.tag=="otb")
       {
		
           if(hb)
           {
               hb.takeDamage(100);
				hurt=true;
           }
	   }
	   if(col.gameObject.tag=="fire")
       {
		
           if(hb)
           {
               hb.takeDamage(2);
				hurt=true;
           }
	   }
			else
				if(col.gameObject.tag=="ammo")
				{
					if(ab)
					{
						ab.decrease(-4);
						Destroy(col.gameObject);

					}
				}
				
   }
   public void activateShield()
	{
		shield=true;
	}
	public void deactivateShield()
	{
		shield=false;
	}
	public void Hs()
	{
		hurts.SetActive(true);
		countdown-=Time.deltaTime;
	}
	public void pause()
	{
		hurts.SetActive(false);
		hurt=false;
	}
	
}
