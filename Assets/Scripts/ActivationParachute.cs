using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationParachute : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject _zoneDanger;
    [SerializeField] private GameObject _parachute;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == _zoneDanger.gameObject.tag){
            
            _parachute.SetActive(true);
        }
    }
}
