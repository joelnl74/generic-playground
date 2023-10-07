using Core.ViewController;
using UnityEngine;

public class GatchaViewController : ViewController<IGatchaPresenter, IGatchaView, GatchaView>
{
    [SerializeField] private ProductDefinition _productDefinition;

    // Start is called before the first frame update
    void Start()
    {
        view._button.onClick.AddListener(() =>
        {
            _presenter.Pull(_productDefinition);
        });
    }
}
