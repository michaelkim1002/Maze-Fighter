using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
	public Button[] lb;

    // Start is called before the first frame update
    void Start()
    {
		int la = PlayerPrefs.GetInt("levelAt",2);
		for(int i=0; i<lb.Length;i++)
		{
			if(i+2>la)
				lb[i].interactable=false;
        
    	}

    }
}
