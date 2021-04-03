using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shotSpeed;
    public int shotCount = 10;
    private float shotInterval;
    private GameObject reloadText;

    // Start is called before the first frame update
    void Start()
    {
        this.reloadText = GameObject.Find("ReloadText");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            shotInterval += 1;

            if (shotInterval % 5 == 0 && shotCount > 0)
            {
                shotCount -= 1;

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                Destroy(bullet, 3.0f);
            }
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            shotCount = 10;
            this.reloadText.GetComponent<Text>().text = "";
        }

        if (shotCount <= 0)
        {
            this.reloadText.GetComponent<Text>().text = "Press the R";
        }
    }
}
