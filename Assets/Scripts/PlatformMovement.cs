using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    [SerializeField] Vector3 back = new Vector3(0, 0, 0); 
    [SerializeField] Vector3 forth = new Vector3(1, 1, 1);   
    [SerializeField] float speed = 1; 

    float phaseDirection = 1;
    float phase = 0;

    void Update()
    {
        transform.localPosition = Vector3.Lerp(back, forth, phase); 

        phase += Time.deltaTime * speed * phaseDirection; 

        if (phase >= 1 || phase <= 0)
        {
            phaseDirection *= -1;
        }
    }
}
