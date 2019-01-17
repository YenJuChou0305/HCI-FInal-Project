using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMove : MonoBehaviour {

    float Speed = 20;
    private Rigidbody rb;
    public AudioSource M;
    //public AudioClip Hit_Sound;
    //public AudioClip Good;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        M = GetComponent<AudioSource>();
    }


    void FixedUpdate()
    {
        if(Raycast.hit_object == gameObject.name && Game_Control.blow == 1)
        {
            Vector3 movement = new Vector3(Raycast.X, 0.0f, Raycast.Z);
            rb.AddForce(movement * Speed);
            //M.clip = Hit_Sound;
            M.Play();

        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("trash can"))
        {
            Destroy(gameObject);
            Game_Control.garbage_count--;

        }
    }

    void play()
    {
        //M.clip = Good;
        M.Play();
    }


}
