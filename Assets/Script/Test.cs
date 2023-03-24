using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject testObj;
    public Transform testTf;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject);
        Debug.Log(col.transform);
        Debug.Log(col.collider);
        Debug.Log(col.rigidbody);
        Debug.Log(col.relativeVelocity);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject);
        Debug.Log(col.transform);
        
    }

    private void Awake()
    {
        throw new NotImplementedException();
    }
}
