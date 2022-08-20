using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeaponButtonUnlock : MonoBehaviour
{
    public Button[] lb;
	public Score sc;
    void Start()
	{
		int la = PlayerPrefs.GetInt("levelAt",2);
		
		for(int i=0; i<lb.Length;i++)
		{
	   if(i+1>la)
			{
				lb[i].interactable=false;
			}
		}
		
	}

    // Update is called once per frame
    void Update()
    {
      if(sc.un32()==true)
	   lb[32].interactable=true;
	   if(sc.un33()==true)
	   lb[33].interactable=true;
	   if(sc.un34()==true)
	   lb[34].interactable=true;
	   if(sc.un35()==true)
	   lb[35].interactable=true;
	   if(sc.un36()==true)
	   lb[36].interactable=true;
	   if(sc.un37()==true)
	   lb[37].interactable=true;
	   if(sc.un38()==true)
	   lb[38].interactable=true;
	   if(sc.un39()==true)
	   lb[39].interactable=true;
	   if(sc.un40()==true)
	   lb[40].interactable=true;
	   if(sc.un41()==true)
	   lb[41].interactable=true;
	   if(sc.un42()==true)
	   lb[42].interactable=true;
	   if(sc.un43()==true)
	   lb[43].interactable=true;
	   if(sc.un44()==true)
	   lb[44].interactable=true;
	   if(sc.un45()==true)
	   lb[45].interactable=true;
	   if(sc.un46()==true)
	   lb[46].interactable=true;
	   if(sc.un47()==true)
	   lb[47].interactable=true;
    }
	
}
