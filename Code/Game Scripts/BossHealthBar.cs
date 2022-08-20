using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHealthBar : MonoBehaviour
{
    
     public Image healthbar;
    public float health;
    public float startHealth;
    public Text healt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hest();
    }
    
    public void TakeDamage(float amount)
    {
        health -=amount;
        healthbar.fillAmount=health/startHealth;
        if(health<=0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
     public void hest()
	{
		healt.text="Boss";

	}
}
