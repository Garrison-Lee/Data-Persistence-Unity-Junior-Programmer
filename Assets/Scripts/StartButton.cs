using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// This script is very specific to the start scene for the Data-Persistence exercise and is not very "good". Just quickly slapped together haha
/// </summary>
public class StartButton : MonoBehaviour
{
    public void Play()
    {
        Text inputText = transform.parent.Find("InputField/Text").GetComponent<Text>();
        
        //Player must enter something, but no more rigorous checking than that
        if (inputText.text == "")
            return;

        NameTrackerSingleton.Instance.SetName(inputText.text);

        //Loads the main scene
        SceneManager.LoadScene(1);
    }
}
