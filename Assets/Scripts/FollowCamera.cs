using System;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField] GameObject target; // The target object to follow

  // Update is called once per frame
  void Update()
  {
    transform.position = new Vector3(
      target.transform.position.x,
      target.transform.position.y,
      target.transform.position.z - 1f
    );
  }
}
