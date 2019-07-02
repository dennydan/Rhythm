using RhythmAssets;

public class GameData
{
    public int Score;

    public GameData(Character_Warrior character)
    {
        Score = character.Rhythm_GM.Score;
    }
}