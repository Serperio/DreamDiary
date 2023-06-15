using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    private string file_path;
    [SerializeField]
    List<int> efectos;
    
    void Awake()
    {
        file_path = Path.Combine(Application.dataPath, "saveState.dat");    
    }

    public void SaveState(){
        EfectosData data = new EfectosData() { Efectos = efectos };
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(file_path, json);
    }

    public EfectosData LoadState(){
        string json = File.ReadAllText(file_path);
        EfectosData data = JsonUtility.FromJson<EfectosData>(json);
        for(int i = 0; i < data.Efectos.Count; i++){
            Debug.Log(data.Efectos[i]);
        }
        return data;
    }
}
