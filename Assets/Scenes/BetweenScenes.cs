using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BetweenScenes : MonoBehaviour
{

    private static BetweenScenes instance;

    [System.NonSerialized]
    public string input = "Text has not been defined";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        instance = this;

        loadInput();
    }


    [System.Serializable]
    class SaveData
    {
        public string Saveinput;
    }

    public void saveInput()
    {
        SaveData data = new SaveData();
        data.Saveinput = input;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void loadInput()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            input = data.Saveinput;
        }
    }
}
