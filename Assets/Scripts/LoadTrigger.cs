using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            SceneManager.Instance.RestartScene();
        }
        else if (other.CompareTag("Ground"))
        {
            SceneManager.Instance.RestartScene();
        }
    }
}
