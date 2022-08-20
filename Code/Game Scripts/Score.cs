using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;	
public class Score : MonoBehaviour
{
    public int score;
    public float hscore;

    public Text sc;
    public Text hsc;
     public Text t;
    public Text ht;
    public WeaponSwitcher wh;
    public float time;
    public float htime;
    public bool endless;
   // public int sl;
    void Start()
    {
        
    setHscore();
       
    }

    // Update is called once per frame
    void Update()
    {
        tick();
       un32();
       un33();
       un34();
       un35();
       un36();
       un37();
       un38();
       un39();
       un40();
       un41();
       un42();
       un43();
       un44();
       un45();
       un46();
       un47();
    }
    public void add()
    {
        score+=1;
        sc.text="Score: "+ score;
        if(score>PlayerPrefs.GetInt("HighScore",0))
        {
            if(endless)
            {
             PlayerPrefs.SetInt("HighScore",score);
              hsc.text="High Score: "+score;
            }
        }
       
    }
    public void tick()
    {
        time+=Time.deltaTime;
        t.text="Time: "+ (int)time;
        if(time>PlayerPrefs.GetInt("HighTime",0))
        {
            if(endless)
            {
             PlayerPrefs.SetInt("HighTime",(int)time);
              ht.text="Highest Time: "+(int)time+" seconds.";
            }
        }
       
    }
   
    public bool un32()
	{
		if(hscore>=1)
        return true;
        else
        return false;
	}
    public bool un33()
	{
		if(htime>=30)
        return true;
        else
        return false;
	}
    public bool un34()
	{
		if(hscore>=2)
        return true;
        else
        return false;
	}
    public bool un35()
	{
		if(hscore>=5)
        return true;
        else
        return false;
	}
    public bool un36()
	{
		if(hscore>=10)
        return true;
        else
        return false;
	}
    public bool un37()
	{
		if(htime>=60)
        return true;
        else
        return false;
	}
    public bool un38()
	{
		if(htime>=60)
        return true;
        else
        return false;
	}
    public bool un39()
	{
		if(hscore>=20)
        return true;
        else
        return false;
	}
    public bool un40()
	{
		if(hscore>=20)
        return true;
        else
        return false;
	}
    public bool un41()
	{
		if(htime>=90)
        return true;
        else
        return false;
	}
    public bool un42()
	{
		if(htime>=90)
        return true;
        else
        return false;
	}
    public bool un43()
	{
		if(hscore>=20)
        return true;
        else
        return false;
	}
    public bool un44()
	{
		if(htime>=180)
        return true;
        else
        return false;
	}
    public bool un45()
	{
		if(hscore>=50)
        return true;
        else
        return false;
	}
    public bool un46()
	{
		if(hscore>=50)
        return true;
        else
        return false;
	}
    public bool un47()
	{
		if(htime>=600)
        return true;
        else
        return false;
	}
    public void setHscore()
    {
         hscore=PlayerPrefs.GetInt("HighScore",(int)hscore);
        hsc.text="High Score: "+hscore;
        htime=PlayerPrefs.GetInt("HighTime",(int)htime);
        ht.text="Highest Time: "+htime+" seconds";
    }
    
}
