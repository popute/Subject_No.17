using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; // 追加
using UnityEngine.SceneManagement;


public class ClickTextAdvance : MonoBehaviour
{
    [SerializeField] private Text textLabel;      // Unity標準のText
    [SerializeField] private CSVLoader provider; // ← CSV読み込み側をInspectorで割り当て
   
    [Header("イベント設定")]
    public UnityEvent onTextFinished;

    private string[] lines; // 行ごとの文章
    private int index = 0;  // 現在の行番号
    private DayCount day; // ← ここでは宣言だけ

    void Awake()
    {
        day = FindObjectOfType<DayCount>(); // ← Awakeで探す

    }

    void Start()
    {
        ChangeText();

        textLabel.text = "";  // 初期は空
        AppendLine();         // 最初の1行を表示
    }

    void ChangeText()
    {
        if (day.dayCount == 1)
        {
            lines = provider.GetLines("day1");
        }
        else if (day.dayCount == 2)
        {
            lines = provider.GetLines("day1_2");
        }
        else if (day.dayCount == 3)
        {
            lines = provider.GetLines("day2");
        }
        else if (day.dayCount == 4)
        {
            lines = provider.GetLines("day3");
        }
        else if (day.dayCount == 5)
        {
            lines = provider.GetLines("day4");
        }
        else if (day.dayCount == 6)
        {
            lines = provider.GetLines("day5");
        }
        else if (day.dayCount == 7)
        {
            lines = provider.GetLines("day6");
        }
        else if (day.dayCount == 8)
        {
            lines = provider.GetLines("day7");
        }
        else
        {
            SceneManager.LoadScene("TitleScene");
        } 
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
        textLabel.text = string.IsNullOrEmpty(textLabel.text) ? add : textLabel.text + "\n" + add;
    }
}
