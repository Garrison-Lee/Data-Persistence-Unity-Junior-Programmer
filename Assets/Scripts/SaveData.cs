/// <summary>
/// Everything we need to save the high score and name
/// </summary>
[System.Serializable]
public class SaveData
{
    public int highScore;
    public string playerName;

    public SaveData()
    {
        highScore = 0;
        playerName = "N/A";
    }
}
