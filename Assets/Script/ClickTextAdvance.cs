using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; // 追加
using UnityEngine.SceneManagement;
using System.Linq;


public class ClickTextAdvance : MonoBehaviour
{
    [SerializeField] private Text textLabel;      // Unity標準のText
    [SerializeField] private CSVLoader provider; // ← CSV読み込み側をInspectorで割り当て

    [Header("イベント設定")]
    public UnityEvent onTextFinished;

    private string[] lines; // 行ごとの文章
    private int index = 0;  // 現在の行番号
    private DayCount day; // ← ここでは宣言だけ
    private SubjectStatus s;



    void Awake()
    {
        day = FindObjectOfType<DayCount>(); // ← Awakeで探す
        s = FindObjectOfType<SubjectStatus>(); // ← Awakeで探す
    }

    void Start()
    {
        var scene = SceneManager.GetActiveScene();

        if (scene.name == "TextScene") // ← 特定シーン名を指定
        {
            // シーン起動時の処理
            ChangeText();
        }
        if (scene.name == "TalkScene") // ← 特定シーン名を指定
        {
            // シーン起動時の処理
            ChangeTalk();
        }
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
        else if (day.dayCount == 9)
        {
            if (s.status['H'] < 30)
            {
                lines = provider.GetLines("EndA");
            }
            else if (s.status['U'] < 30)
            {
                lines = provider.GetLines("EndA");
            }
            else if (s.status['M'] < 50)
            {
                lines = provider.GetLines("EndB");
            }
            else if (s.status['T'] > 80)
            {
                lines = provider.GetLines("EndC");
            }
            else
            {
                lines = provider.GetLines("EndB");
            }
        }
        else
        {
            SceneManager.LoadScene("TalkScene");
        }
    }
    void ChangeTalk()
    {
        if (day.dayCount == 1)
        {
            lines = provider.GetLines("day1_talk");


        }
        else if (day.dayCount == 2)
        {
            lines = provider.GetLines("day2_talk");
        }
        else if (day.dayCount == 3)
        {
            lines = provider.GetLines("dayElse_talk");
            if (s.status['H'] < 30)
            {
                string[] extra = provider.GetLines("Talk_H");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['U'] < 30)
            {
                string[] extra = provider.GetLines("Talk_U");
                lines = lines.Concat(extra).ToArray();
            }
        }
        else if (day.dayCount == 4)
        {
            lines = provider.GetLines("dayElse_talk");
            if (s.status['H'] < 30)
            {
                string[] extra = provider.GetLines("Talk_H");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['U'] < 30)
            {
                string[] extra = provider.GetLines("Talk_U");
                lines = lines.Concat(extra).ToArray();
            }
        }
        else if (day.dayCount == 5)
        {
            lines = provider.GetLines("day5_talk");
        }
        else if (day.dayCount == 6)
        {
            lines = provider.GetLines("dayElse_talk");
            if (s.status['H'] < 30)
            {
                string[] extra = provider.GetLines("Talk_H");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['U'] < 30)
            {
                string[] extra = provider.GetLines("Talk_U");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['M'] < 50)
            {
                string[] extra = provider.GetLines("Talk_M");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['T'] < 80)
            {
                string[] extra = provider.GetLines("Talk_T");
                lines = lines.Concat(extra).ToArray();
            }
        }
        else if (day.dayCount == 7)
        {
            lines = provider.GetLines("dayElse_talk");
            if (s.status['H'] < 30)
            {
                string[] extra = provider.GetLines("Talk_H");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['U'] < 30)
            {
                string[] extra = provider.GetLines("Talk_U");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['M'] < 50)
            {
                string[] extra = provider.GetLines("Talk_M");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['T'] < 80)
            {
                string[] extra = provider.GetLines("Talk_T");
                lines = lines.Concat(extra).ToArray();
            }
        }
        else if (day.dayCount == 8)
        {
            lines = provider.GetLines("dayElse_talk");
            if (s.status['H'] < 30)
            {
                string[] extra = provider.GetLines("Talk_H");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['U'] < 30)
            {
                string[] extra = provider.GetLines("Talk_U");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['M'] < 50)
            {
                string[] extra = provider.GetLines("Talk_M");
                lines = lines.Concat(extra).ToArray();
            }
            else if (s.status['T'] < 80)
            {
                string[] extra = provider.GetLines("Talk_T");
                lines = lines.Concat(extra).ToArray();
            }
        }
        else if (day.dayCount == 9)
        {
            if (s.status['H'] < 30)
            {
                lines = provider.GetLines("EndH");
            }
            else if (s.status['U'] < 30)
            {
                lines = provider.GetLines("EndU");
            }
            else if (s.status['M'] < 50)
            {
                lines = provider.GetLines("EndM");
            }
            else if (s.status['T'] > 80)
            {
                lines = provider.GetLines("EndT");
            }
            else
            {
                lines = provider.GetLines("EndElse");
            }
        }
    }

    public void Advance()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        index++;
        if (index < lines.Length)
        {
            AppendLine();
        }
        else if (sceneName == "TalkScene" && day.dayCount == 9)
        {
            SceneManager.LoadScene("EndScene");
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
