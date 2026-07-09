using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class hp_script : MonoBehaviour
{
    [SerializeField] float hp;
    [SerializeField] Text helloSir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
