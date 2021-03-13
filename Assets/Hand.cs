using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    //手のオブジェクトを設定

    public GameObject targethand;

    private Vector3 offset;

    //調節用

    [SerializeField]
    float controlX;

    [SerializeField]
    float controlY;

    [SerializeField]
    float controlZ;

    private string path = "Prefab/Gun";

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(controlX, controlY, controlZ);

        HoldInHand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoldInHand()
    {
        GameObject obj = Instantiate(GunPrefab, targethand.transform);

        obj.transform.SetParent(targethand.transform);

        obj.transform.eulerAngles = offset;
    }

    public GameObject GunPrefab;
}
