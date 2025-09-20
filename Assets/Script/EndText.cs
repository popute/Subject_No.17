using UnityEngine;
using UnityEngine.UI;

public class EndText : MonoBehaviour
{
    private SubjectStatus s; // ← ここでは宣言だけ

    void Awake()
    {
        s = FindObjectOfType<SubjectStatus>(); // ← Awakeで探す
    }

    public Text endName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowEnd();
    }

    // Update is called once per frame
    void ShowEnd()
    {
        if (s.status['H'] < 30)
            {
                endName.text = "管理人は被検体の健康を損ねました。";
            }
            else if (s.status['U'] < 30)
            {
                endName.text = "管理人は被検体の調査を怠りました。";
            }
            else if (s.status['M'] < 50)
            {
                endName.text = "管理人は被検体のメンタルケアを怠りました。";
            }
            else if (s.status['T'] > 80)
            {
                endName.text = "管理人は被検体との逃走を決意しました。";
            }
            else
            {
                endName.text = "管理人は被検体の管理を行い続けました。";
            }
    }
}
