using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    public static ObjectPoolingManager instance;

    public List<GameObject> pool = new List<GameObject>();

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoolList(GameObject i)
    {
        pool.Add(i);
        Debug.Log("Pool added");
        foreach (GameObject obj in pool)
        {
            Debug.Log(obj.name);
        }
        i.gameObject.SetActive(false);
    }

    public void setPoolObjActive(GameObject i)
    {
        i.gameObject.SetActive(true);
    }

    public void FindObjectinPool(GameObject i)
    {
        foreach (GameObject inpool in pool)
        {
            Debug.Log("2nd");
            if (inpool.tag == i.tag)
            {
                Debug.Log("Search desc");
                if (inpool.GetComponent<PickUp>().item.desc == i.GetComponent<PickUp>().item.desc)
                {
                    setPoolObjActive(inpool);
                    Vector3 dropSpawnPos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0f);
                    inpool.gameObject.transform.position = dropSpawnPos;
                    RemovePoolList(inpool);
                    return;
                }
            }

        }
    }

    public void RemovePoolList(GameObject i)
    {
        pool.Remove(i);
        Debug.Log("Pool obj remove");
        Debug.Log(i.name);
    }

}
