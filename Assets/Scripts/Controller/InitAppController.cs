﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class InitAppController : MonoBehaviour 
{
	private static bool s_resUpdateChecked = false;
	public  static void setResChecked(bool checked_) { s_resUpdateChecked = checked_; }

	private InputField m_accountField = null;

	void Start () 
	{
        AppConst.PrintPath();

		if (!GlobalRef.Init ())
			return;

		AssetBundle loginAB = ABManager.get(AppConst.AB_LOGIN);
		if (null == loginAB) 
			return;

		GameObject loginPrefab = loginAB.LoadAsset ("panel_login") as GameObject;
		if (null == loginPrefab)
		{
			Debug.LogError("loginprefab not found");
			return;
		}			
		GameObject loginRootGo = GameObject.Instantiate (loginPrefab);
		loginRootGo.transform.SetParent(GlobalRef.UIRoot, false);
		loginRootGo.name = "panel_login";

		if (s_resUpdateChecked) 
		{
			loginRootGo.transform.FindChild ("ResUpdate").gameObject.SetActive (false);

			GameObject accountInputGo = loginRootGo.transform.FindChild ("IptAccount").gameObject;
			m_accountField = accountInputGo.GetComponent<InputField> ();
			accountInputGo.SetActive (true);

			GameObject loginBtnGo = loginRootGo.transform.FindChild ("BtnLogin").gameObject;
			Button loginBtn = loginBtnGo.GetComponent<Button> ();
			loginBtn.onClick.AddListener(OnLoginClick);
			loginBtnGo.SetActive (true);
		} 
		else 
		{
			GameObject resUpdateGo = new GameObject("ResUpdate");
			resUpdateGo.transform.SetParent (GlobalRef.UIRoot, false);
			resUpdateGo.AddComponent<ResUpdateController> ().m_slider = null;
		}
	}


	public void OnLoginClick()
	{
		ulong accountId = ulong.Parse(m_accountField.text);
		Utility.Log ("login btn clicked:" + accountId);

		if (NetController.Instance.Init())
		{
			HandleMgr.Init();
			NetController.Instance.LoginToLoginServer("121.199.48.63", 8888, accountId);
			//NetController.Instance.LoginToLoginServer("192.168.0.75", 4444, accoundId);
		}
	}

    public void OnDestroy()
    {
		Utility.Log("init app controller destroy");
    }
}