using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
    protected UnityCallAndroid pMyAndroid ;
    void Awake()
    {

    }
	// Use this for initialization
	void Start () 
    {
        // tips: this.transform = "Main Camera"
        pMyAndroid = this.transform.GetComponent<UnityCallAndroid>();
	}	
	// Update is called once per frame
	void Update () 
    {
	
	}
    //
	protected string sTemp = "" ;
	protected float fTemp = 0.0f ;
	protected string sPlatform = "" ;
    void OnGUI()
    {
		int iY = 10 ; 
		if (GUI.Button(new Rect(10, iY , 300, 30), "Unity Call Android ShowAlertDialog"))
        {
            pMyAndroid.UnityCallAndroidAlert("Complete!", "Retry?", "YES", "QUIT");
        }
		iY+=40 ;
		if (GUI.Button(new Rect(10, iY , 300, 30), "Unity Call Android ShowToast"))
        {
            pMyAndroid.UnityCallAndroidToast("Fail!");
        }
		iY+=40 ;
		#if UNITY_ANDROID
		sPlatform = "Unity plugins use so file" ;
		#else
		sPlatform = "Unity plugins use DLL file" ;
		#endif
		if (GUI.Button(new Rect(10, iY , 300, 30), sPlatform))
        {
			fTemp = UnityPluginsUser.callMultiply(3.1415926535f, 4.0f);
			sTemp = "4Pi="+fTemp ;		
		}
		iY+=40 ;
		if (GUI.Button(new Rect(10, iY , 300, 30), "Unity Tech sample"))
		{
			fTemp = UnityPluginsUser.callAdd(3.1415926535f , 3.1415926f ) ;
			sTemp = "2Pi="+fTemp ;
        }
		iY+=40 ;
		if (GUI.Button(new Rect(10, iY , 300, 30), sTemp)) {}
		iY+=40 ;
		if (GUI.Button(new Rect(10, iY , 300, 30), "Unity Call Android SDK Version")) 
		{
			int iV = pMyAndroid.UnityCallAndroidSDKVersion() ;
			sTemp = Application.unityVersion + ",AndroidSDK=" + iV ;
		}
		iY+=40 ;
		if (GUI.Button(new Rect(10, iY , 300, 30), "Unity Call Android Version Name"))
		{
			sTemp = pMyAndroid.UnityCallAndroidVersionName() ;
		}
		iY+=40 ;
		if (GUI.Button(new Rect(10, iY , 300, 30), "Unity Call Android ShowToast2"))
		{
			pMyAndroid.UnityCallAndroidToast2("Jar2!");
		}
    }
}
