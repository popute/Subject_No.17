using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; // 追加

public class ClickTextAdvance : MonoBehaviour
{
    [SerializeField] private Text textLabel;      // Unity標準のText
    [SerializeField] private TextAsset textAsset; // 表示用のテキストファイル

    [Header("イベント設定")]
    public UnityEvent onTextFinished;
    
    private string[] lines; // 行ごとの文章
    private int index = 0;  // 現在の行番号

    void Start()
    {
        if (textAsset == null || textLabel == null)
        {
            Debug.LogError("TextまたはTextAssetが未設定です");
            return;
        }

        // 改行で分割し、空行を除外
        var raw = textAsset.text.Replace("\r\n", "\n").Replace("\r", "\n");
        lines = raw.Split(new[] { '\n' });

        textLabel.text = "";  // 初期は空
        AppendLine();         // 最初の1行を表示
    }

    public void Advance()
    {
        index++;
        if (index < lines.Length)
        {
            AppendLine();
        }
        else
        {
            onTextFinished?.Invoke();
        }
    }

    private void AppendLine()
    {
        string add = lines[index];
        if (string.IsNullOrEmpty(textLabel.text))
            textLabel.text = add;       // 1行目
        else
            textLabel.text += "\n" + add; // 2行目以降は下に追加
    }
}
