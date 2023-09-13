using Messaging;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class PlayGroundController : MonoBehaviour
{
    [SerializeField] private Button _toastTextButton;

    private IToastPresenter _toastPresenter;

    [Inject]
    public void Init(IToastPresenter toastPresenter)
        => _toastPresenter = toastPresenter;

    void Awake()
        => _toastTextButton.onClick.AddListener(ShowToast);

    private void ShowToast()
        => _toastPresenter.Publish("test", "message");
}
