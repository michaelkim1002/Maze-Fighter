using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;	
public class Healthbar : MonoBehaviour
{
    public Image healthbar;
    public float health;
    public float startHealth;
	public GameObject d;
	public GameObject w;
	public GameObject b;
	public Text healt;
	public pausemenu pm;
	
	void Start()
	{
		startHealth=health;
	}
	void Update()
	{
		hest();

	}
    public void takeDamage(int damage)
    {
        health= health-damage;
        healthbar.fillAmount=health/startHealth;
        if(health>=startHealth)
        {
            health=startHealth;
        }
		if(health<=0)
		{
			pm.de(false);
			pm.gamepause(true);
			Debug.Log("You Died!");
			Time.timeScale=0f;
			d.SetActive(true);
			w.SetActive(false);
			b.SetActive(false);
			Cursor.lockState=CursorLockMode.None;
			Cursor.visible=true;

		}

    }
	public void drain(int damage)
	{
		health= health+damage;
	}
	public void hest()
	{
		healt.text="Health: "+ health+"/"+startHealth;

	}
	
}
