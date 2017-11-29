﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    bool posicion = false;
    bool saltando = false;
    public Rigidbody2D bird;
    public Vector2 LeftToRightMovement = new Vector2(5f, 8f);
    public Vector2 RightToLeftMovement = new Vector2(-5f, 8f);
    // Use this for initialization
    void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
	        
		///INPUTS
        if (Input.GetKeyDown(KeyCode.Space))
        {
			if (saltando == false)
			{
				Movimiento ();
				saltando = true;
			}
            print(bird.transform.position.y);

        }

        if (this.transform.position.x <= -2 || this.transform.position.x >= 2)
        {
            bird.velocity = Vector2.down;
        }
			
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Trigger de Salto")) 
		{
			saltando = false;
		}
	}


    public void Movimiento()
    {
        if (posicion == false)
        {
            bird.velocity = Vector2.zero;
            bird.AddForce(LeftToRightMovement * 10f);
            posicion = true;
        }
        else
        {
            bird.velocity = Vector2.zero;
            bird.AddForce(RightToLeftMovement * 10);
            posicion = false;
        }
        print("posicion: " + posicion + ", saltando: " + saltando);

    }

}
