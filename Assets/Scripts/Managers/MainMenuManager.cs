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

    public void StartGame()
    {
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

}