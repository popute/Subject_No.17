using UnityEngine;
using System.Collections.Generic;

public class SubjectStatu : MonoBehaviour
{
    public static SubjectStatu Instance { get; private set; }

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

    private Dictionary<char, int> status = new Dictionary<char, int>
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
        }
        else
        {
            Debug.LogWarning($"未定義のタイプ {type} にアクセスしました");
        }
        Debug.Log($"H={status['H']}, M={status['M']}, T={status['T']}, U={status['U']}");
    }
}
