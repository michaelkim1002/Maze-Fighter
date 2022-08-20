using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerman : MonoBehaviour
{
   #region Singleton
	public static Playerman instance;
	void Awake()
	{
		instance=this;
	}
	#endregion
	public GameObject player;
}
