using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ModeSwitch : MonoBehaviour
{
    public GameObject mode1;
    public GameObject mode2;
    public bool m1;
    
    void Start()
    { 
     
         mode1.SetActive(true);
          m1=true;
           
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(m1)
            {
                mode2.SetActive(true);
                mode1.SetActive(false);
                m1=false;
            }
           else
          
            {
				mode1.SetActive(true);
                 mode2.SetActive(false);
                m1=true;
            }
        }
    }
}
