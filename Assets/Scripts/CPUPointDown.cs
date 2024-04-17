using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CPUPointDown : MonoBehaviour, IPointerClickHandler
{
    public AnimationClip moveAnimationOpen;
    public AnimationClip moveAnimationClose;
    private bool isOpen;

    public virtual void Move()
    {
        StartCoroutine(MoveCoroutine());
    }

    void Start()
    {
        Application.targetFrameRate = 60;
        this.isOpen = false;
    }

    private IEnumerator MoveCoroutine()
    {
        Debug.Log("确认动画");
        Animator animator = gameObject.GetComponent<Animator>();
        if (animator != null)
        {
            if (this.isOpen == false)
            {
                animator.Play(moveAnimationOpen.name);
                this.isOpen = true;
                yield return new WaitForSeconds(moveAnimationOpen.length);
            }
            else
            {
                animator.Play(moveAnimationClose.name);
                this.isOpen = false;
                yield return new WaitForSeconds(moveAnimationClose.length);
            }

        }
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("确认启动");
        this.Move();
    }

}
