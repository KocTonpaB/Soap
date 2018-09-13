using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouving : MonoBehaviour
{
    public float speed = 9.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed; //"Horizontal" и "Vertical" - это допонительные имена для сопоставления с клавматурой
        float deltaY = Input.GetAxis("Vertical") * speed;
        transform.Translate(deltaX * Time.deltaTime, deltaY * Time.deltaTime, transform.position.z);
    }
}
