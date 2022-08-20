using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class BossControl : MonoBehaviour
{
    public float lookRadius=10f;
	Transform target;
	NavMeshAgent agent;
	public float speed=100.0f;
	float countdown;
	public float delay =1f;
	public Rigidbody pro;
	public Transform sp;
	public Transform sp2;
    public GameObject bhb;
    void Start()
    {
		target=Playerman.instance.player.transform;
		agent=GetComponent<NavMeshAgent>();
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
		

	
		float distance = Vector3.Distance(target.position,transform.position);
		if(distance<=lookRadius)
		{
           bhb.SetActive(true);
			agent.SetDestination(target.position);
			countdown-=Time.deltaTime;
			if(countdown<=0f)
			{
				Shoot();
				countdown=delay;
			}
			if(distance<agent.stoppingDistance)
			{ 
				FaceTarget();
			}
		}
    }
  
	void FaceTarget()
	{
		Vector3 direction = (target.position-transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x,0,direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime*5f);
	}
	void OnDrawGizmosSelected()
	{
		Gizmos.color=Color.red;
		Gizmos.DrawWireSphere(transform.position,lookRadius);
	}
   void Shoot()
	{
		Rigidbody proj = (Rigidbody)Instantiate(pro, sp.position, sp.rotation);
		proj.velocity = sp.TransformDirection(new Vector3(0,0,speed)); 
		Rigidbody proj2 = (Rigidbody)Instantiate(pro, sp2.position, sp2.rotation);
		proj2.velocity = sp2.TransformDirection(new Vector3(0,0,speed)); 

	}
}
