﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reset : MonoBehaviour
{
   
    
	void Update()
    {
		
		Reset();
    }
	public void Reset()
	{

		PlayerPrefs.DeleteAll();

	}
	public void GoBack()
	{
		SceneManager.LoadScene("Menu");
	}

}
