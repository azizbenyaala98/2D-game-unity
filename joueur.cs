using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueur : MonoBehaviour
{
	public Vector2 speed = Vector2.one;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
    	float inputX = Input.GetAxis("Horizontal");
    	float inputY = Input.GetAxis("Vertical");


    	Vector3 movement = new Vector3(speed.x * inputX,speed.y * inputY, 0);
    	transform.Translate(movement * Time.deltaTime);
        
    }
}
