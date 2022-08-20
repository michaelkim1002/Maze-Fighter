using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChoosenWeapon : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject weapon;
	public Text name;
	public void pw() 
	{
		pickweapon(weapon);
	}
	public void pickweapon(GameObject w)
	{
		weapon=w;

	}
	public void wn()
	{
		name.text+=" "+weapon.name;
	}
}
