using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class PauseButtonUI : MonoBehaviour
{
    public event EventHandler OnPlauseGame;
    [SerializeField] Button pauseButton;
    void Start() {
        pauseButton.onClick.AddListener( ()=> {
            OnPlauseGame?.Invoke(this, EventArgs.Empty);
        });
    }

}
