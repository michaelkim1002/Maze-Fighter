using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shield : MonoBehaviour
{
    public bool loaded;
	public AmmoBar ab;
	public int x;
    public GameObject shield;
    public GameObject shieldb;
    public GameObject hb;
    public bool sh;
    public Collisiondamage d;
    void Start()
    {
        ab.ua();
        sh=false;
    }

    // Update is called once per frame
    void Update()
    {
        ab.aa(x);

		if(ab.isloaded()||x==0)
			{
                if(!sh)
                {
		if(Input.GetButtonDown("Fire1"))
			{
				
					UseShield();
                    d.activateShield();
			}
         }
		}
    }
    public void UseShield()
    {
        shield.SetActive(true);
        shieldb.SetActive(true);
        ab.decrease(x);
        sh=true;
    }
    public void deactivate()
    {
        d.deactivateShield();
        shield.SetActive(false);
        shieldb.SetActive(false);
        sh=false;
    }
}
