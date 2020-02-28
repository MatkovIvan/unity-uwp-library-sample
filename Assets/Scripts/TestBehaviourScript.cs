using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviourScript : MonoBehaviour
{
    void Start()
    {
#if UNITY_WSA_10_0 && !UNITY_EDITOR
        var _ = MyClassLibrary.SomeLibraryClass.DoSomeWork();
#endif
    }
}
