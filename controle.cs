using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{
    public Vector2 speed = Vector2.one;
    public Animator anim;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rp;
    public int health = 7;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rp= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        if(inputX != 0f || inputY!=0f)
        {
            anim.SetBool("IS WALKING", true);
            flip(inputX);
        }
        else
        {
            anim.SetBool("IS WALKING", false);
        }

        Vector3 movment = new Vector3(speed.x * inputX,speed.y * inputY, 0);
        transform.Translate(movment * Time.deltaTime);

        if( health == 0)
        {
            //Lose 
            Time.timeScale = 0;
        }
        
    }
    void flip(float x)
{
	if ( x < 0)
	{
        // activer le flip 
        spriteRenderer.flipX = true;
	}else
	{
		// desactiver le flip
		spriteRenderer.flipX = false;
	}
}
void OnCollisionEnter2D(Collision2D col)
{
    if (col . gameObject.tag == "SCORPION")
    {
        Debug.Log("SCORPION");
        rp.AddForce(transform.up * 8, ForceMode2D.Impulse);
        health = health - 1;
    }
}

}












