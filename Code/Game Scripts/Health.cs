
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
     
    public float health;
     public Image healthbar;
    public float startHealth;
    public Text healt;
    public GameObject bos;
    public Rune r;
    public Rigidbody pro;
	public Transform sp;
    public bool half;
    public bool finalboss;
    public GameObject floor;
    public bool score;
    public Score s;
  
     void Update()
    {
        hest();
        
    }
    public void TakeDamage(float amount)
    {

        health -=amount;
        if(health<=(startHealth/2))
        {
            if(half)
            {
            drop();
            half=false;
            }
        }
        if(health<=0f)
        {
            drop();
            Die();
            if(score)
             {
                 s.add();
             }
             if(finalboss)
             {
                 floor.SetActive(true);
             } 
             else
             {
                 r.destroydoor();
             }
             
        }
    }
    void Die()
    {
        Destroy(gameObject);
        Destroy(bos);
    }
     void drop()
    {
       Rigidbody proj = (Rigidbody)Instantiate(pro, sp.position, sp.rotation);
		proj.velocity = sp.TransformDirection(new Vector3(0,0,0)); 
       
    }
    public void hest()
	{
		//healt.text="Boss";
		healthbar.fillAmount=health/startHealth;
	}
    
}
