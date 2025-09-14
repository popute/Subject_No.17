using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class ActionCount : MonoBehaviour
{
    public Text countText;
    public int count=3;
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
            onTextFinished?.Invoke();
        }
    }
}
