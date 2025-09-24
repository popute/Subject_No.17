using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class BGMPlayer1 : MonoBehaviour
{
    public static BGMPlayer1 Instance { get; private set; }

    private AudioSource src;
    private static bool started;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        src = GetComponent<AudioSource>();
        src.playOnAwake = false;
        src.loop = true;
        src.spatialBlend = 0f;

        // シーン切替イベント登録
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Update()
    {
        if (!started && (Input.GetMouseButtonDown(0) || Input.touchCount > 0 || Input.anyKeyDown))
        {
            StartBGM();
        }
    }

    public void StartBGM()
    {
        if (started) return;
        if (src.clip == null)
        {
            Debug.LogWarning("[BGMPlayer] AudioSource.clip が未設定です。");
            return;
        }
        src.Play();
        started = true;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // EndScene に入ったら停止
        if (scene.name == "EndScene")
        {
            StopBGM();
        }
    }

    public void StopBGM()
    {
        if (src.isPlaying)
        {
            src.Stop();
            started = false;
        }
    }
}
