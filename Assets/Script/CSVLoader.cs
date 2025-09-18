using UnityEngine;
using System.Collections.Generic;

public class CSVLoader : MonoBehaviour
{
    [SerializeField] private TextAsset[] csvFiles;

    private Dictionary<string, string[]> dict = new();

    void Awake()
    {
        foreach (var csv in csvFiles)
        {
            if (csv == null) continue;
            var raw = csv.text.Replace("\r\n", "\n").Replace("\r", "\n");
            var lines = raw.Split(new[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
            dict[csv.name] = lines; // ファイル名をキーにして格納
        }
    }

    public string[] GetLines(string key)
    {
        return dict.TryGetValue(key, out var lines) ? lines : null;
    }
    public string[] GetLines2(string key)
    {
        return dict.TryGetValue(key, out var lines) ? lines : null;
    }
}
