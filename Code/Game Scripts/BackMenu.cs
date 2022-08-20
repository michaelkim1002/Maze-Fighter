using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackMenu : MonoBehaviour
{
    public int scene;
    // Start is called before the first frame update
   public void BackGame()
    {
        SceneManager.LoadScene("Menu");
    }
	public void PlayGame()
    {
        SceneManager.LoadScene(scene);
    }
}
