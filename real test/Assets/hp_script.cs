using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class hp_script : MonoBehaviour
{
    private float hp;
    [SerializeField] Text helloSir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp = 100f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        helloSir.text = ("hp " + hp );
    }
}
