using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GargoyleScript : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform gargoyle;

    private Vector3 thisAngle;


    
    void Awake()
    {
        gargoyle = transform;
        player = GameObject.Find("JohnLemon").transform;
        thisAngle = new Vector3(0f, 1f, 0f);

    }

    // Update is called once per frame 
    void Update()
    {
        Vector3 directionFacing = player.position - gargoyle.position;

        directionFacing.Normalize();

        float angle = Mathf.Acos(Vector3.Dot(Vector3.forward, directionFacing)) * Mathf.Rad2Deg;

        //gargoyle.localRotation = new Quaternion(0f, angle, 0f, 0f);

        thisAngle.y = angle;

        gargoyle.eulerAngles = thisAngle;

    }
}
