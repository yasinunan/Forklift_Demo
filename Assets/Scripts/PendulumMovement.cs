using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMovement : MonoBehaviour
{

    [SerializeField] float MaxAngle = 30.0f;
    [SerializeField] float SpeedOfPendulum = 1.0f;
    private Rigidbody pivot;
   
    // Start is called before the first frame update
    void Start()
    {
        pivot = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePendulum();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Palett"))
        {
            SceneManager.Instance.RestartScene();
        }
        else if (CompareTag("Load"))
        {
            SceneManager.Instance.RestartScene();
        }
        else if (CompareTag("Forklift"))
        {
            SceneManager.Instance.RestartScene();
        }
    }

    private void MovePendulum()
    {
        float angle = MaxAngle * Mathf.Sin(Time.time * SpeedOfPendulum);
        pivot.transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
    
}
