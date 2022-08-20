using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Nuke : MonoBehaviour
{
   
	public float speed=100.0f;
	public Rigidbody pro;
	public Transform sp;
	public bool loaded;
	public AmmoBar ab;
	public int x;
	public bool shot;
    public GameObject gfx;
    public GameObject message;
	void Start()
	{
		
	//	pro.tag=("grenades");
		ab.ua();
		shot=false;
	}


  void Update()
	{
		
		ab.aa(x);
		if(ab.isloaded()||x==0)
		{
		if(Input.GetButtonDown("Fire1")&&!shot)
			{
					Shoot();
					shot=true;
					gfx.SetActive(false);
					
			}
		}
	}
	void Shoot()
	{
	
			ab.decrease(x);
		Rigidbody proj = (Rigidbody)Instantiate(pro, sp.position, sp.rotation);
		proj.velocity = sp.TransformDirection(new Vector3(0,0,speed)); 
		shot=true;

	}
}
