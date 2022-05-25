using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addgas : MonoBehaviour
{
   [SerializeField] private float rotateSpeed = 50f;

    private void Update()
    {

        Rotate();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        GasBar.gas += 20f;

        if (GasBar.gas > 100f)
        {
            GasBar.gas = 100f;
        }

        Destroy(gameObject);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
}
