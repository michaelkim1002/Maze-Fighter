using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyedbox : MonoBehaviour
{
	public GameObject dv;
	public void Destroy()
	{
		Instantiate(dv,transform.position,transform.rotation);
		Destroy(gameObject);
	}
  
}
