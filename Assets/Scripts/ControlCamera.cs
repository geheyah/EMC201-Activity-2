using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject Subject;
    private Transform SubjectTransform;

    void Start()
    {
        if (Subject != null)
        {
            SubjectTransform = Subject.GetComponent<Transform>();          
        }
    }

    void Update()
    {
        if (SubjectTransform != null)
        {
            transform.position = new Vector3(SubjectTransform.position.x, SubjectTransform.position.y, transform.position.z);
        }
    }
}
