using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script that just tracks the name the player enters from the start scene to the main scene. Uses a singleton pattern just for practice.
/// </summary>
public class NameTrackerSingleton : MonoBehaviour
{
    public static NameTrackerSingleton Instance;
    private string playerName;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            return;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
    }

    public void SetName(string newName)
    {
        playerName = newName;
    }

    public string GetName()
    {
        return playerName;
    }
}
