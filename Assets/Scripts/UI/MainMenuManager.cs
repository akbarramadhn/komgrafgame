using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public AudioSource musicSource;
    public int volume = 100;

    public void SelectLevel()
    {
        SceneManager.LoadScene("ChooseLevel");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MusicVolume()
    {
        volume += 10;
        if (volume > 100) volume = 0;

        musicSource.volume = volume / 100f;
    }
}
