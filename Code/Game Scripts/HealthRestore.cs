using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRestore : MonoBehaviour
{
	
	public Healthbar hb;
	public void HealDamage()
	{
		if(hb)
		{
			hb.takeDamage(-20);
			Destroy(gameObject);

		}
	}

}
