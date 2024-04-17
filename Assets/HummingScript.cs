using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HummingScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] AudioSource hummingSFX;

    bool hasPlayed = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col) {
        if (col.transform.CompareTag("Player") && !hasPlayed) {
            hummingSFX.Play();
            hasPlayed = true;
        }
    }
}
