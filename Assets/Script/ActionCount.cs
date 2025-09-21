using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class ActionCount : MonoBehaviour
{
    public Text countText;
    public int count = 3;
    public UnityEvent onTextFinished;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button[] buttons = FindObjectsOfType<Button>();

        foreach (Button btn in buttons)
        {
            btn.onClick.AddListener(OnAnyButtonClicked);
        }

    }

    void OnAnyButtonClicked()
    {
        count -= 1;
        countText.text = $"{count}";

        if (count == 0)
        {
            StartCoroutine(DelayedProcess());
        }
    }
    IEnumerator DelayedProcess()
    {
        Debug.Log("処理開始");
        yield return new WaitForSeconds(1.5f);  // 3秒待機
        Debug.Log("3秒後に処理実行");
        onTextFinished?.Invoke();
    }
}
