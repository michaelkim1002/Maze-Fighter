using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -18.8f;
    public Transform ground;
    public float groundDistance=0.4f;
    public LayerMask gmask;
    Vector3 velocity;
    bool isground;
    public float jumph=3f;
	public Healthbar hb;

	public Camera fpsCam;
	public float pick= 10f;
    public float pick2= 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isground=Physics.CheckSphere(ground.position,groundDistance,gmask);
        if(isground&&velocity.y<0)
        {
            velocity.y=-2f;
        }
        float x=Input.GetAxis("Horizontal");
        float z=Input.GetAxis("Vertical");
        Vector3 move =transform.right*x+transform.forward*z;
        controller.Move(move*speed*Time.deltaTime);
        if(Input.GetButtonDown("Jump")&&isground)
        {
            velocity.y=Mathf.Sqrt(jumph*-2f*gravity);
        }
        velocity.y+=gravity*Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
		if(Input.GetButtonDown("Fire2"))
		{
			PickUp();
            CollectRune();
		}
    }
	void PickUp()
	{
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit,pick))
		{
			Debug.Log(hit.transform.name);
			HealthRestore target= hit.transform.GetComponent<HealthRestore>();
			if(target!=null)
			{
				target.HealDamage();

			}
            
			AmmoRestore target2= hit.transform.GetComponent<AmmoRestore>();
			if(target2!=null)
			{
				target2.HealDamage();

			}
			Key target3= hit.transform.GetComponent<Key>();
			if(target3!=null)
			{
				target3.collect();

			}
		}
	}
    void CollectRune()
	{
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit,pick2))
		{
			Debug.Log(hit.transform.name);
			Rune target= hit.transform.GetComponent<Rune>();
			if(target!=null)
			{
				target.nl();

			}
		}
	}
}
