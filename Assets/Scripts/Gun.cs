using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    private float speed = 100.0f;

    public GameObject shot;

    public Transform shotSpawn;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal2") * speed;

        rotation *= Time.deltaTime;

        transform.Rotate(new Vector3(0, rotation, 0));

        if(Input.GetButtonDown("Jump"))
        {
            audioSource.Play();
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }      
    }

}
