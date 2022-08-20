using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rune : MonoBehaviour
{
    public int sl;
	public pausemenu pm;
	public GameObject w;
	public GameObject b;
    public GameObject door;
	void Start()
    {

		sl=SceneManager.GetActiveScene().buildIndex+1;
		
		
    }
    public void nl()
    {
        pm.gamepause(true);
			Debug.Log("You Died!");
			Time.timeScale=0f;
			w.SetActive(false);
			b.SetActive(false);
			Cursor.lockState=CursorLockMode.None;
			Cursor.visible=true;
				SceneManager.LoadScene(sl);
			if(sl>PlayerPrefs.GetInt("levelAt"))
				{
				PlayerPrefs.SetInt("levelAt",sl);
				}
    }
    public void destroydoor()
    {
        Destroy(door);
    }
}
