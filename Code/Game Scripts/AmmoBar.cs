using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoBar : MonoBehaviour
{
    public float ammo;
	public float startammo;

	public Image ammoBar;
	public GameObject orb;
	public int am;
	public Text ammmo;
	public Text ac;
	public Text acname;
	public GameObject load1;
	public GameObject load2;
	


	void Update()
	{
		amst();

	}
	public void aa(int x)
	{
		am=x;
	
	}
	public void ua()
    {
		//ammo=startammo;
        ammoBar.fillAmount=ammo/startammo;
	
	}

	public void decrease(int a)
	{
		am=a;
			ammo=ammo-a;
			ammoBar.fillAmount=ammo/startammo;
		if(ammo>=startammo)
		{
			ammo=startammo;
		}
		if(ammo<=0)
		{
			ammo=0;
		}
	}

	public bool isloaded()
	{
		if(ammo>0&&am<=ammo)
		{
			load1.SetActive(true);
			load2.SetActive(true);
		return true;
		}
		else
		{
			load1.SetActive(false);
			load2.SetActive(false);
		return false;
		}
	}
	public void amst()
	{
		ammmo.text="Ammo: "+ ammo+"/"+startammo;
		ac.text="Ammo Cost: "+am;
		
	}
	
}

