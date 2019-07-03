using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using RhythmAssets;


public static class SaveSystem
{
    public static void SaveData(Character_Warrior warrior)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/GameData";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(warrior);
        formatter.Serialize(stream, data);

        stream.Close();
    }
    
    public static GameData LoadData(Character_Warrior warrior)
    {
        string path = Application.persistentDataPath + "/GameData";
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
