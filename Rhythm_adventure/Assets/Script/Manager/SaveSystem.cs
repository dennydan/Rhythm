using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using RhythmAssets;


public static class SaveSystem
{
    public static void SaveData(Rhythm_GameMode gm)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/GameData.rhythm";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(gm);
        formatter.Serialize(stream, data);

        stream.Close();
    }
    
    public static GameData LoadData(Rhythm_GameMode gm)
    {
        string path = Application.persistentDataPath + "/GameData.rhythm";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();
            return data;
        }
        else
        {
            return null;
        }
    }
}
