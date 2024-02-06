using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aigle : MonoBehaviour
{

    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BougeAigle(){
        _rb.velocity = 5;
    }
}
