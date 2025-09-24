using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

public class SubjectStatus : MonoBehaviour
{
    Scene scene;
    public static SubjectStatus Instance { get; private set; }
    private DayCount day; // ← ここでは宣言だけ

    void Awake()
    {
        day = FindObjectOfType<DayCount>(); // ← Awakeで探す


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
    private void OnSceneLoaded(Scene loadedScene, LoadSceneMode mode)
    {
        if (loadedScene.name == "EndScene")
        {
            ResetStatus();
        }
    }
    public void ResetStatus()
    {
        status['H'] = 0;
        status['M'] = 0;
        status['T'] = 0;
        status['U'] = 0;
        Debug.Log("SubjectStatus: EndScene でステータスをリセットしました。");
    }
    void OnEnable()
    {
        // シーンがロードされたときに呼ばれるイベント
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public static implicit operator SubjectStatus(BGMPlayer1 v)
    {
        throw new NotImplementedException();
    }
}
