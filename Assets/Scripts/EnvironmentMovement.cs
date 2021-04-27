using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        EnvironmentSettings.OnSpeedChanged += SetSpeed;
        SetSpeed();
    }

    private void SetSpeed()
    {
        rb.velocity = new Vector3(0, -EnvironmentSettings.EnvironmentSpeed * Time.deltaTime, 0);
    }

    public void OnDestroy()
    {
        EnvironmentSettings.OnSpeedChanged -= SetSpeed;
    }
}
