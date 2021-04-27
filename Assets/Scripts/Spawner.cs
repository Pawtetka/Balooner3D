using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;

    private List<GameObject> objects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        SpawnNewObject();
    }

    public void Update()
    {
        if (/*Input.GetKeyDown(KeyCode.UpArrow)*/Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            SpawnNewObject();
        }
    }

    private void SpawnNewObject()
    {
        GameObject gameObject = Instantiate(_spawnObject, new Vector3(Random.Range(-10, 10), 20, 0), Quaternion.identity, this.gameObject.transform);
        objects.Add(gameObject);
    }
}
