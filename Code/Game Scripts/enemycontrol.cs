using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemycontrol : MonoBehaviour
{
	public float delay =1f;
	public float lookRadius=10f;
	public float speed=75.0f;
	float countdown;
	public Rigidbody pro;
	public Transform sp;
	Transform target;
	NavMeshAgent agent;
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

	}
}
