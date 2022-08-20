using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class nextlevel : MonoBehaviour
{
	public int sl;
	public pausemenu pm;
	public GameObject w;
	public GameObject b;
   
    void Start()
    {

		sl=SceneManager.GetActiveScene().buildIndex+1;
		
		
    }
	
	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Player")
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
		}
}