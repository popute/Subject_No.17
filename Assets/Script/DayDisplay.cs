using UnityEngine;
using UnityEngine.UI;

public class DayDisplay : MonoBehaviour
{
    void Awake()
    {
        day = FindObjectOfType<DayCount>(); // ← Awakeで探す

    }
    private DayCount day; // ← ここでは宣言だけ
    public Text dayText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dayText.text = $"{day.dayCount}";
    }
}
