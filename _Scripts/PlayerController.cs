using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField, Range(-200, 200), Tooltip("Velocidad movimiento hacia adelante")] 
    private float speedForward =20; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speedForward * Time.deltaTime);
    }
}
