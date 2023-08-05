using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PanelDetail
{
    public GameObject panelObj;
    public float panelDelay;
}
public class MainMenuManager : MonoBehaviour
{
    public List<PanelDetail> panelDetails;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MenuHandler());
    }

    IEnumerator MenuHandler()
    {
        for(int j = 0; j < panelDetails.Count; j++)
        {
            panelDetails[j].panelObj.SetActive(true);
            yield return new WaitForSeconds(panelDetails[j].panelDelay);
            
            if (j < panelDetails.Count - 1)
            {
                panelDetails[j].panelObj.SetActive(false);
            }
            
            
        }

    }
}
