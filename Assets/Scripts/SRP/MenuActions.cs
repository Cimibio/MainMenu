using UnityEngine;

public class MenuActions : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;

    public void OnPlayButtonClick()
    {
        uiManager.ShowPlayMessage();
    }

    public void OnAboutButtonClick()
    {
        uiManager.ShowAboutPanel();
    }

    public void OnCloseAboutButtonClick()
    {
        uiManager.HideAboutPanel();
    }

    public void OnExitButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}