using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationParachute : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject _zoneDanger;
    [SerializeField] private GameObject _parachute;

    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        BougeMouton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void BougeMouton()
    {
        _rb.AddForce(Vector3.forward * 50,ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other){

        if(other.transform.tag == _zoneDanger.transform.tag)
        {
            OuvreParachute();
        }
    }

    void OuvreParachute()
    {
        _parachute.SetActive(true);
        _rb.drag = 10;
    }
}
