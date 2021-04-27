using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSettings : MonoBehaviour
{
    public static float EnvironmentSpeed;
    [SerializeField] private float _speed;

    public delegate void SpeedChange();

    public static event SpeedChange OnSpeedChanged;

    public void Start()
    {
        if (_speed == 0)
        {
            _speed = 100;
        }
        EnvironmentSpeed = _speed;
    }

    public void UpSpeed()
    {
        EnvironmentSpeed += _speed;
        if (OnSpeedChanged != null)
        {
            OnSpeedChanged();
        }
    }

    public void Update()
    {
        if (/*Input.GetKeyDown(KeyCode.UpArrow)*/Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            UpSpeed();
        }
    }
}
