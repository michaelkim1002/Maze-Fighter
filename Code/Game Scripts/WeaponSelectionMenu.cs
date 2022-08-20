using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeaponSelectionMenu : MonoBehaviour
{
    public static bool GameIsPaused;
	public GameObject pmui;
	public GameObject w;
	public GameObject b;
	public static bool death=true;

	Transform plpos;
	
	void Start()
	{
		
		Cursor.lockState=CursorLockMode.Confined;
		Cursor.visible=true;
		GameIsPaused=true;
		death=true;
	}
     void Update()
    {
         pmui.SetActive(true);
		w.SetActive(false);
		b.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
		Cursor.lockState=CursorLockMode.Confined;
		Cursor.visible=true;
          
        
        
    
    }
	public void Resume()
    {
        pmui.SetActive(false);

        Time.timeScale = 1f;
        GameIsPaused = false;
		Cursor.lockState=CursorLockMode.Locked;
		Cursor.visible=false;
		w.SetActive(true);
		b.SetActive(true);
    }

  
	
	public void gamepause(bool p)
	{

		GameIsPaused=p;
	}	
}
