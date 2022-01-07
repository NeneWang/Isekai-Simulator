using System.Collections;
using System.Collections.Generic;
using Naninovel;
using UnityEngine;
using UnityEngine.UI;

public class changeCharacterAnimation : MonoBehaviour
{
    Animator animator;

    void start()
    {
        animator = GetComponent<Animator>();
    }

    public void updateAnimation()
    {
        var variableManager = Engine.GetService<ICustomVariableManager>();
        var p_animation = variableManager.GetVariableValue("p_animation");
        animator.SetInteger("event", int.Parse(p_animation));
    }
}
