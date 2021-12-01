using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveManager
{
    private static string savePath = Application.persistentDataPath + "/HighScore.json";

    public static SaveData LoadTheData()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            return data;
        }

        else
            return new SaveData();
    }

    public static void SaveTheData(SaveData save)
    {
        string json = JsonUtility.ToJson(save);
        File.WriteAllText(savePath, json);
    }
}
