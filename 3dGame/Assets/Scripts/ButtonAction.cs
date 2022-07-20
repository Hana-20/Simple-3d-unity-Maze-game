using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton()
    {
        manager.StartGame();
        Debug.Log("Start");
        
    }
    public void ExitButton()
    {
        manager.EXIT();
    }
    public void PlayAgain()
    {
        manager.PlayAgain();
    }
}
