using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var main = ps.main;
        main.startColor = Color.gray;
        main.startSize = 0.25f;
        main.startLifetime = 0.5f;

        
    }

    // Update is called once per frame
    void Update()
    {
        //Produce particles when the player presses the space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ParticleSystem ps = GetComponent<ParticleSystem>();
            ps.Play();
        }
        
    }
}
