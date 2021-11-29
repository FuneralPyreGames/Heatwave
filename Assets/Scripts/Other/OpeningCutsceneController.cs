using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCutsceneController : MonoBehaviour
{
    public Audio Audio;
    public SceneChangeManager sceneChangeManager;
    void Awake()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        Audio = persistentComponents.GetComponent<Audio>();
        sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
    }
    IEnumerator WaitForCutsceneToEnd()
    {
        yield return new WaitForSeconds(70f);
        sceneChangeManager.LoadLevel("Level 1");
    }
}
