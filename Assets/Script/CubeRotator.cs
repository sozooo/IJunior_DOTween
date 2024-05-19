using DG.Tweening;
using UnityEngine;

public class CubeRotator : ObjectTween
{
    [SerializeField] private Vector3 _endValue;

    private void Start()
    {

        transform.DORotate(_endValue, Duration).SetLoops(Repeats, LoopMode);
    }
}
