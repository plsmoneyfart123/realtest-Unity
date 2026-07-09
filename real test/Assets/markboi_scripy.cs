using UnityEngine;

public class markboi_scripy : MonoBehaviour
{
    public GameObject mark;
    private float markmovespeed;
    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       mark.transform.position = new Vector2(15.36f, -1.04f);
      int goob = Random.Range(0,3);
        if (goob == 0)
        {
           sound1.Play();
        }else if (goob == 1)
        {
            sound2.Play();
        }else 
        {
            sound3.Play();
        }
       
        
            
        
    }

    // Update is called once per frame
    void Update ()
    {
         if (transform.position.x/*15.28f*/ >= 6.21f)
        {
            markmovespeed = 3f;
        }else
        {
            markmovespeed = 0f;
        }
        transform.position = transform.position + (Vector3.left * markmovespeed) * Time.deltaTime;

    }
}
