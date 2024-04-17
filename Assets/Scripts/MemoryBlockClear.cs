using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryBlockClear : MonoBehaviour
{
    public AnimationClip clearAnimation;
    public GameObject AfterClearShow;

    public virtual void Clear()
    {
        Debug.Log("执行");
        StartCoroutine(ClearCoroutine());
    }

    public GameObject ClearedObject;
    private IEnumerator ClearCoroutine()
    {
        Debug.Log("清除block");
        Animator animator = gameObject.GetComponent<Animator>();
        if (animator != null)
        {
            animator.Play(clearAnimation.name);
            yield return new WaitForSeconds(clearAnimation.length);

            Destroy(ClearedObject.gameObject);
            AfterClearShow.SetActive(true);
            Destroy(gameObject);
            Debug.Log("清除block");
        }
    }
}
