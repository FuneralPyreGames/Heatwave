using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExit : MonoBehaviour
{
    public PersistentData persistentData;
    public SceneChangeManager sceneChangeManager;
    public int currentLevel;
    private void Awake()
    {
        while (GameObject.Find("PersistentComponents(Clone)") == null)
        {
            print("Unable to find components");
        }
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        persistentData = persistentComponents.GetComponent<PersistentData>();
        sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sceneChangeManager.LoadLevel("MainMenu");
        }
    }
}
