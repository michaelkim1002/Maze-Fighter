using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    
	public Text ac;
	public ChooseYourWeapon cw;
	public GameObject chow;
	void Update()
	{
		//cw.wn();

	}
    public void PlayGame()
    {
        SceneManager.LoadScene("Level Select");
    }
	public void PlayEndlessGame()
    {
        SceneManager.LoadScene("Endless Mode");
    }
	public void QuitGame()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
	public void PickAWeapon()
	{

		cw.ch(chow);
	}

    
}

