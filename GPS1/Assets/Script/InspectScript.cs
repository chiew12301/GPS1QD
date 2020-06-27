using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectScript : MonoBehaviour
{
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Time.timeScale = 1;
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }

    }

}
