using UnityEngine;

public class test_script : MonoBehaviour
{
    public static int myCoolInt = 0;
    public int CoolerTest = 0;
    public static bool myCoolBool = false;
    public bool CoolerBool = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCoolInt += 2;
        CoolerTest += 2;
        print (myCoolInt);
        print (CoolerTest);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
