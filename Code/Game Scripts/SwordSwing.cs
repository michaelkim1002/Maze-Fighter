using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwordSwing : MonoBehaviour
{
    public float countdown=0.5f;
    public float delay=0.5f;
    public bool use;
    public AmmoBar ab;
    public int x;
    public PlayMode swing;
    public  float damage = 1f;
	public float range= 5f;
    public Transform sp;
    public Rigidbody rb;
	public Camera fpsCam;
    public bool vampire;
    public Healthbar hb;
    void Start()
    {
        use=false;
         countdown=delay;
        ab.ua();
    }

    // Update is called once per frame
    void Update()
    {
        ab.aa(x);
         if(!use)
                {
                 if(Input.GetButtonDown("Fire1")||Input.GetButton("Fire1"))
			    { 
                 
                    use=true;
                    GetComponent<Animation>().Play(swing);
                   Shoot();
                   
                }

                }
                if(use)
                    {
                        countdown-=Time.deltaTime;
                    }
                if(countdown<=0)
                {
                countdown=delay;
                use=false;
                }
                
			}
        void Shoot()
	{
		
		ab.decrease(x);
		use=true;
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
			Health target= hit.transform.GetComponent<Health>();
			if(target!=null)
			{
				target.TakeDamage(damage);

			}
            

		}
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
        enemybullet target2= hit.transform.GetComponent<enemybullet>();
			if(target2!=null)
			{
				target2.destroybullet();

			}
        }
        
        if(vampire)
        {
             hb.drain(2);
        }
       
	}
}
