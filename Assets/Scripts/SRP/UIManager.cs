using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject aboutPanel;
    [SerializeField] private GameObject playMessageText;

    private void Start()
    {
        if (aboutPanel != null)
            aboutPanel.SetActive(false);

        if (playMessageText != null)
            playMessageText.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (playMessageText != null && playMessageText.activeSelf)
            {
                HidePlayMessage();
            }
        }
    }

    public void ShowAboutPanel()
    {
        if (aboutPanel != null)
            aboutPanel.SetActive(true);
    }

    public void HideAboutPanel()
    {
        if (aboutPanel != null)
            aboutPanel.SetActive(false);
    }

    public void ShowPlayMessage()
    {
        if (playMessageText != null)
            playMessageText.SetActive(true);
    }

    public void HidePlayMessage()
    {
        if (playMessageText != null)
            playMessageText.SetActive(false);
    }
}