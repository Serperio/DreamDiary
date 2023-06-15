using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class save_load : MonoBehaviour
{
    private string file_path;
    [SerializeField]
    List<int> efectos;
    
    void Awake()
    {
        file_path = Path.Combine(Application.dataPath, "saveState.dat");    
    }

    public void SaveState(){
        Efectos_data data = new Efectos_data() { Efectos = efectos };
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(file_path, json);
    }

    public Efectos_data LoadState(){
        string json = File.ReadAllText(file_path);
        Efectos_data data = JsonUtility.FromJson<Efectos_data>(json);
        for(int i = 0; i < data.Efectos.Count; i++){
            Debug.Log(data.Efectos[i]);
        }
        return data;
    }
}
