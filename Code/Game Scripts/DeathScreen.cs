using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeathScreen : MonoBehaviour
{
	
	public pausemenu pm;
	public void LoadMenu()
	{	
		pm.gamepause(false);
		SceneManager.LoadScene("Menu");
		Time.timeScale=1f;
		Cursor.lockState=CursorLockMode.Confined;
	}
	public void QuitGame()
	{
		Application.Quit();
	}
}
