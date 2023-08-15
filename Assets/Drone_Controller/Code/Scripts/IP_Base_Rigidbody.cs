using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Xanmine
{
    [RequireComponent(typeof(Rigidbody))]
    public class IP_Base_Rigidbody : MonoBehaviour
    {
        #region Variables
        [Header("Rigidbody Property")]
        [SerializeField] private float weightInLbs = 1f;

        const float lbsToKg = 0.454f;

        protected Rigidbody rb;
        protected float starDrag;
        protected float starAngularDrag;
        #endregion

        #region Main Methods
        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            if(rb)
            {
                rb.mass = weightInLbs * lbsToKg;
                starDrag = rb.drag;
                starAngularDrag = rb.angularDrag;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(!rb)
            {
                return;
            }

            HandlePhysics();
        }
        #endregion

        #region Custom Methods;
        protected virtual void HandlePhysics() { }
        #endregion
    }
}