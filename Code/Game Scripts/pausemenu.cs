using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pausemenu : MonoBehaviour
{
	public static bool GameIsPaused;
	public GameObject pmui;
	public GameObject wesm;
	public GameObject w;
	public GameObject b;
	public static bool death=true;
	public static bool ws;
	Transform plpos;
	public WeaponSwitcher weap;
	public Collisiondamage coll;
	public Score set;
	void Start()
	{
		set.setHscore();
		ws=true;
		death=true;
        GameIsPaused = true;
		Time.timeScale = 0f;
		w.SetActive(true);
		b.SetActive(true);
		Cursor.lockState=CursorLockMode.Confined;
		Cursor.visible=true;
		
		
	}
     void Update()
    {
		
        if(death)
			{
				if(!ws)
				{
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
				Cursor.lockState=CursorLockMode.Locked;
                Resume();
            }
            else
            {
				coll.pause();
				Cursor.lockState=CursorLockMode.Confined;
                Pause();
            }
        }
		}
		else{
			Cursor.lockState=CursorLockMode.Confined;
		}
		
    }
    }
	public void Resume()
    {
		coll.pause();
        pmui.SetActive(false);

        Time.timeScale = 1f;
        GameIsPaused = false;
		Cursor.lockState=CursorLockMode.Locked;
		Cursor.visible=false;
		w.SetActive(true);
		b.SetActive(true);
    }
	public void Begin()
    {
       if(weap.checkweapon())
	   {
		weap.startweapon();
		wesm.SetActive(false);
        Time.timeScale = 1f;
		Cursor.lockState=CursorLockMode.Locked;
		ws=false;
        GameIsPaused = false;
		Cursor.visible=false;
		w.SetActive(true);
		b.SetActive(true);
		
	   }
    }

   public void Pause()
    {
        
		GameIsPaused = true; 
		Time.timeScale = 0f;
		pmui.SetActive(true);
		w.SetActive(false);
		b.SetActive(false);
		Cursor.lockState=CursorLockMode.None;
		Cursor.visible=true;
    }
	
	public void LoadMenu()
	{	
		SceneManager.LoadScene("Menu");
		
		Time.timeScale=1f;
		GameIsPaused=false;
	}
	public void QuitGame()
	{
		Application.Quit();
	}
	public void de(bool b)
	{
		death=b;
	}
	public void gamepause(bool p)
	{

		GameIsPaused=p;
	}	
}