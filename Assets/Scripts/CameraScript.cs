using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public float speed;

    float rotH;
    float rotW;
	void Start ()
    {
	
	}
	void Update ()
    {
        rotW = Input.GetAxis("Mouse X");
        rotH = Input.GetAxis("Mouse Y");

        this.transform.eulerAngles += new Vector3(-rotH * speed, rotW * speed);
	}
}
