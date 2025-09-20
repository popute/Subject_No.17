using UnityEngine;
using System.Collections.Generic;

public class SubjectStatus : MonoBehaviour
{
    public static SubjectStatus Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public Dictionary<char, int> status = new Dictionary<char, int>
    {
        { 'H', 0 },
        { 'M', 0 },
        { 'T', 0 },
        { 'U', 0 }
    };
    public void AddScore(char type, int value)
    {
        if (status.ContainsKey(type))
        {
            status[type] += value;
            Debug.Log($"{type} に {value} 加算 → 現在 {status[type]}");
        Debug.Log($"H={status['H']}, M={status['M']}, T={status['T']}, U={status['U']}");

        }
        else
        {
            Debug.LogWarning($"未定義のタイプ {type} にアクセスしました");
        }
    }
}
