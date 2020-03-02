using System;
using System.Threading.Tasks;
using UnityEngine;

public class TestBehaviourScript : MonoBehaviour
{
    void Start()
    {
#if UNITY_WSA_10_0 && !UNITY_EDITOR
        Task<Guid> id = MyClassLibrary.SomeLibraryClass.DoSomeWork();
        Debug.Log("Device ID: " + id.Result.ToString());
#endif
    }
}
