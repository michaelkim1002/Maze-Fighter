using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MLook : MonoBehaviour
{
    public float mouseSensitivity =400f;
    public Transform playerBody;
    float xRotation=0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
		Cursor.visible=false;
     //Screen.lockCursor=false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY=Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime;

        xRotation-=mouseY;
        xRotation=Mathf.Clamp(xRotation,-90f,90f);

        transform.localRotation=Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up*mouseX);
        

       // float x=Input.GetAxis("Mouse X");
    }
    public void Scope(int s)
    {
        mouseSensitivity=mouseSensitivity/s;
    }
    public void unScope(int s)
    {
        mouseSensitivity=mouseSensitivity*s;
    }
    public void ori()
    {
        mouseSensitivity=400f;
    }
}
