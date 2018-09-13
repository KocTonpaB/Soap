using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform player;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void LateUpdate()
    {
//        transform.LookAt(player);
        transform.position.Set(player.position.x, player.position.y, -100);
        Debug.Log(player.position.x);
        Debug.Log(player.position.y);
    }
}
