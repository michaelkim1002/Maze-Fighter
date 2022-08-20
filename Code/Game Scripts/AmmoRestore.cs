using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoRestore : MonoBehaviour
{
   public AmmoBar hb;
	public void HealDamage()
	{
		if(hb)
		{
			hb.decrease(-80);
			Destroy(gameObject);

		}
	}
}
