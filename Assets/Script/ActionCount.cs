using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

[DisallowMultipleComponent]
public class ActionCount : MonoBehaviour
{
    [Header("UI")]
    public Text countText;               // TextMeshProならTMP_Textに
    public Button[] targetButtons;       // 入力を止めたいボタンをInspectorで登録

    [Header("Settings")]
    public int count = 3;

    [Header("Events")]
    public UnityEvent onTextFinished;

    private bool isLocked = false;

    void Start()
    {
        // 初期表示
        UpdateCountText();

        // イベント登録（Inspectorで指定したボタンのみに限定）
        foreach (var btn in targetButtons)
        {
            if (btn != null)
            {
                btn.onClick.AddListener(OnAnyButtonClicked);
            }
        }
    }

    void OnDestroy()
    {
        // 後片付け（重複登録防止）
        foreach (var btn in targetButtons)
        {
            if (btn != null)
            {
                btn.onClick.RemoveListener(OnAnyButtonClicked);
            }
        }
    }

    void OnAnyButtonClicked()
    {
        if (isLocked) return;

        count = Mathf.Max(0, count - 1); // 0未満にしない
        UpdateCountText();

        if (count == 0)
        {
            LockInputs();                 // 物理的に押せなくする
            StartCoroutine(DelayedProcess());
        }
    }

    void UpdateCountText()
    {
        if (countText != null) countText.text = $"{count}";
    }

    void LockInputs()
    {
        isLocked = true;

        // ボタン無効化
        foreach (var btn in targetButtons)
        {
            if (btn != null) btn.interactable = false;
        }
    }

    IEnumerator DelayedProcess()
    {
        Debug.Log("処理開始");
        yield return new WaitForSeconds(1.5f);
        Debug.Log("1.5秒後に処理実行");
        onTextFinished?.Invoke();
    }

    // 動的に生成したボタンを後から登録したい場合用（任意）
    public void RegisterButton(Button btn)
    {
        if (btn == null) return;
        btn.onClick.AddListener(OnAnyButtonClicked);
        if (isLocked) btn.interactable = false; // 既にロック済みなら即無効化
    }
}
