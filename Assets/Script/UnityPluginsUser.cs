using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class UnityPluginsUser : MonoBehaviour
{
    #if UNITY_ANDROID
    //multiply function
	[DllImport ("testsofile")]
	private static extern float multiply(float x, float y);//LibTestSoFile.so ' multiply() ;

	//Unity Technologies Sample for android NDK plugins 
	[DllImport("native")]
	private static extern float add(float x, float y);
    #else
    //multiply function
    [DllImport("TestDllFile")]
	private static extern float multiply(float x, float y);//TestDllFile.dll ' multiply() ;//四捨五入到小數點第三位//Math.Round(f , 3);
	[DllImport("TestDllFile")]
	private static extern float add(float x, float y);//TestDllFile.dll ' multiply() ;//四捨五入到小數點第三位;//Math.Round(f , 3);
    #endif

    void Awake()
    {

    }
	// Use this for initialization
	void Start () 
    {
	
	}	
	// Update is called once per frame
	void Update () 
    {
	
	}
    //
    void OnGUI()
    {

    }
    //
    public static float callMultiply(float x, float y)
    {
        return multiply(x, y);
    }
	//
	public static float callAdd(float x, float y)
	{
		return add(x , y) ;
	}
}
