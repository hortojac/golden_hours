using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class OpeningJournalManager : MonoBehaviour
{
    [Header("Scene to Load")]
    [SerializeField] private SceneField _SceneJournal;

    public void Journal()
    {
        SceneManager.LoadSceneAsync(_SceneJournal, LoadSceneMode.Additive);
    }

    void Update()
    {
    }
}