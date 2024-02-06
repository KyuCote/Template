using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuages : MonoBehaviour
{
    private float _positionX;
    private float _positionY;
    private float _positionZ;
    [SerializeField] private float _vitesse;

    void Start()
    {
        _positionX = transform.position.x;
        _positionY = transform.position.y;
        _positionZ = transform.position.z; 
    }

    void Update()
    {
        BougeNuage();
    }

    void BougeNuage(){
        
        //------------------------------------------------------- Sert à changer la position x des nuages

        // transform.position = new Vector3(_positionX += (_vitesse*Time.deltaTime), _positionY, _positionZ);

        //------------------------------------------------------- Sert à avancer le nuage

        transform.Translate(Vector3.forward *_vitesse *Time.deltaTime);
        transform.Translate(Vector3.up *_vitesse *Time.deltaTime);

    }
}
