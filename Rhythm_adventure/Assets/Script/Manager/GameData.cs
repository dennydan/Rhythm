using RhythmAssets;

[System.Serializable]
public class GameData
{

    public int chap;
    public int Level;
    public LevelData[,] levelDatas = new LevelData[5,5];

    public GameData(Rhythm_GameMode gm)
    {
        levelDatas = gm.datas_GM;
        levelDatas[gm.Chap, gm.Level].Score = gm.Score;
    }
}

[System.Serializable]
public struct LevelData
{
    public int Score;
    public bool Level_Unlocked;
}