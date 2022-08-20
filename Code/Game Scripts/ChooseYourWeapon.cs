using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseYourWeapon : MonoBehaviour
{
	
	public Button[] lb;
	public GameObject cw;
	public GameObject cw2;
	public Text name;
	public Text name2;
	public WeaponSwitcher hand;
	// Start is called before the first frame update
	

	public void ch(GameObject c)
	{
		cw=c;
		name.text="Weapon 1:";
		name.text+=" "+cw.name;
		hand.weaponone(cw);

	}
	public void ch2(GameObject c2)
	{
		cw2=c2;
		name2.text="Weapon 2:";
		name2.text+=" "+cw2.name;
		hand.weapontwo(cw2);

	}
	public bool sameweapon()
	{
		if(cw=cw2)
		return false;
		else
		return true;	
	}
}
