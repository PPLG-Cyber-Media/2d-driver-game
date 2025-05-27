using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool hasPackage = false;

  [SerializeField] Color32 hasPackageColor = new Color32(107, 255, 0, 255);
  [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("Aduh Nabrak");
  }


  private void OnTriggerEnter2D(Collider2D other)
  {

    if (other.CompareTag("Packages") && !hasPackage)
    {
      Debug.Log("Pick Up Package");
      Destroy(other.gameObject);
      hasPackage = true;
    }

    if (other.CompareTag("Customers") && hasPackage)
    {
      Debug.Log("Package Delivered");
      hasPackage = false;

      // mengambil komponen SpriteRenderer dari Player dan mengubah warnanya
      GetComponent<SpriteRenderer>().color = noPackageColor;
    }
  }
  

  void Update()
  {
    if (hasPackage)
    {
      GetComponent<SpriteRenderer>().color = new Color32(
        (byte)(Mathf.Sin(Time.time) * 255),
        255,
        255,
        255);
    }
  }
}
