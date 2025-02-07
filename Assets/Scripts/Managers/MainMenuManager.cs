using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [Header("Scene to Load")]
    [SerializeField] private SceneField _levelScenePolice;
    [SerializeField] private SceneField _levelSceneSettings;
    [SerializeField] private SceneField _levelSceneCredits;
    [SerializeField] private SceneField _levelSceneMainMenu;

    [Header("Animation")]
    public GameObject _mainMenu;
    public Sprite[] _mainMenuSprites;

    public void Start()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            StartCoroutine(AnimateMainMenu());
        }
    }

    public IEnumerator AnimateMainMenu()
    {
        SpriteRenderer spriteRenderer = _mainMenu.GetComponent<SpriteRenderer>();
        while (true)
        {
            foreach (Sprite sprite in _mainMenuSprites)
            {
                spriteRenderer.sprite = sprite;  // Set the sprite to the SpriteRenderer
                yield return new WaitForSeconds(0.2f);
            }
        }
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("Memory1Collected", 0); // Explicitly reset memory flag when starting a new game
        PlayerPrefs.SetInt("Memory2Collected", 0); // Explicitly reset memory flag when starting a new game
        PlayerPrefs.SetInt("Memory3Collected", 0); // Explicitly reset memory flag when starting a new game
        PlayerPrefs.Save();
        // Load the police scene
        SceneManager.LoadScene(_levelScenePolice, LoadSceneMode.Single);
    }

    public void Settings()
    {
        // Load the settings scene
        SceneManager.LoadScene(_levelSceneSettings, LoadSceneMode.Single);
    }

    public void Credits()
    {
        // Load the credits scene
        SceneManager.LoadScene(_levelSceneCredits, LoadSceneMode.Single);
    }

    public void MainMenu()
    {
        // Load the main menu scene
        SceneManager.LoadScene(_levelSceneMainMenu, LoadSceneMode.Single);
    }

    public void Update()
    {
        #if UNITY_WEBGL
            if (Input.GetKeyDown(KeyCode.Q)) // Use 'Q' as the escape key in WebGL
            {
                MainMenu();
            }
        #else
            if (Input.GetKeyDown(KeyCode.Escape)) // Use 'Escape' as the escape key in non-WebGL
            {
                MainMenu();
            }
        #endif
    }
}
