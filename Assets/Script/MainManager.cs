using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance
    {
        get;
        private set;
    }
    public string playerName;
    public int bestScore;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void SavePlayer(string s)
    {
        playerName = s;
    }

    [System.Serializable]
    class JsonData
    {
        public int bestScore;
    }

    public void SaveJson()
    {
        JsonData data = new JsonData();
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", json);

    }

    public void LoadJson(){
        string path = Application.persistentDataPath + "/saveFile.json";

        if(File.Exists(path)){
            string json = File.ReadAllText(path);
            JsonData data = JsonUtility.FromJson<JsonData>(json);
            bestScore = data.bestScore;
        }
    }
}
