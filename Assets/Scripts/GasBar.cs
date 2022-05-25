using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GasBar : Singleton<GasBar>
{
    Image gasBar;
    public static float gas;
    readonly float maxGas = 100f;
    readonly float mingas = 0.1f;
    private const float decrease = 0.5f;
   
    private void Start()
    {
        gasBar = GetComponent<Image>();
        gas = maxGas ;
    }


    private void Update()
    {
        gas -= decrease * Time.deltaTime;
        gasBar.fillAmount = gas / maxGas;

        if (gas < mingas)
        {
            SceneManager.Instance.RestartScene();
        }

        
    }

    
}
