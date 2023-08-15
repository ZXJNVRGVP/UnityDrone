using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region Variables
    public float speed = 2.5f;
    public Transform FollowTrans;
    public Vector3 Offset;
    #endregion


    // Start is called before the first frame update
    private void Awake()
    {
        Offset = transform.position - FollowTrans.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (FollowTrans != null)
        {
            transform.position = Vector3.Lerp(Offset, (FollowTrans.position + Offset), speed * Time.deltaTime);
        }
    }
}
