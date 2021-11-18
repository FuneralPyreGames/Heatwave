using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{
    public GameObject persistentComponentsPrefab;
    private void Awake()
    {
        if (GameObject.Find("PersistentComponents(Clone)") == null)
        {
            Instantiate(persistentComponentsPrefab, new Vector3(0, 0, 0), persistentComponentsPrefab.transform.rotation);
        }
        Destroy(gameObject);
    }
}
