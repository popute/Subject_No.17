using UnityEngine;
using UnityEngine.SceneManagement;

public class DayCount : MonoBehaviour
{

    public static DayCount Instance { get; private set; }

    public int dayCount = 0;   // 保持したい変数

    void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "TextScene") // ← 特定シーン名を指定
        {
            // シーン起動時の処理
            dayCount++;
        }
    }
}
