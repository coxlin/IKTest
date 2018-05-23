using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class IKControl : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private bool _isIKActive = false;

    [SerializeField]
    private Transform _lookObj;

    private void OnAnimatorIK(int layerIndex)
    {
        if (_animator != null)
        {
            if (_isIKActive)
            {
                if (_isIKActive)
                {
                    if (_lookObj != null)
                    {
                        _animator.SetLookAtWeight(1);
                        _animator.SetLookAtPosition(_lookObj.position);
                    }
                }
            }
            else
            {
                _animator.SetLookAtWeight(0);
            }
        }
    }
}
