using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShieldBar : MonoBehaviour
{
    public Image shieldbar;
    public float shealth;
    public float startSHealth;
	public Text shealt;
	
    public Shield s;
    void Start()
    {
        startSHealth=shealth;
    }

    // Update is called once per frame
    void Update()
    {
        hest();
    }
    public void takeSDamage(int damage)
    {
        shealth= shealth-damage;
        shieldbar.fillAmount=shealth/startSHealth;
		if(shealth<=0)
		{   shealth+=startSHealth;
			shieldbar.fillAmount=startSHealth;
            s.deactivate();
             
		}

    }
    public void hest()
	{
		shealt.text="Shield: "+ shealth+"/"+startSHealth;

	}
}
