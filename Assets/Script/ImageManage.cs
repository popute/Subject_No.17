using UnityEngine;

public class ImageManage : MonoBehaviour
{
    private DayCount day; // ← ここでは宣言だけ
    private SubjectStatus s;
    void Awake()
    {
        day = FindObjectOfType<DayCount>(); // ← Awakeで探す
        s = FindObjectOfType<SubjectStatus>(); // ← Awakeで探す
    }
    [SerializeField] private SpriteRenderer target; // 切り替える対象
    [SerializeField] private Sprite spriteA;        // 画像1
    [SerializeField] private Sprite spriteB;        // 画像2

    public void ChangeToA()
    {
        target.sprite = spriteA;
    }

    public void ChangeToB()
    {
        target.sprite = spriteB;
    }
    public void ChangeSize()
    {
        transform.localScale *= 2f;
    }
    public void DeleteImage()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        if (day.dayCount == 9)
        {
            if (s.status['H'] < 30)
            {
                DeleteImage();
            }
            else if (s.status['U'] < 30)
            {
                DeleteImage();
            }
            else if (s.status['M'] < 50)
            {
                ChangeToB();
                transform.localScale *= 2.5f;
            }
            else if (s.status['T'] > 80)
            {
                ChangeToA();
            }
        }
    }

}
