using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class FMODController : MonoBehaviour
{
    public StudioEventEmitter emitter;

    void Start()
    {
        //instance = RuntimeManager.CreateInstance(
        //    "event:/Proson"
        //);

        //instance.start();
    }


    public void SetBlur(float value)
    {
        FMOD.RESULT result =
            emitter.EventInstance.setParameterByName(
                "VoiceBlur",
                value
            );

        Debug.Log(result);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))   
        {
            Debug.Log(1);
            SetBlur(1.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(2);
            SetBlur(0.4f);
        }
    }

    void OnDestroy()
    {
        // 释放内存
        emitter.EventInstance.release();
    }
}
