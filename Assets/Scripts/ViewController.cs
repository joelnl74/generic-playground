using Core.Interfaces;
using UnityEngine;
using Zenject;

namespace Core.ViewController
{
    public class ViewController<TPresenter, TIView, TBaseView> : MonoBehaviour
        where TIView : IView
        where TBaseView : TIView
        where TPresenter : IPresenter<TIView>
    {
        [SerializeField] protected TBaseView view;
        protected TPresenter _presenter;

        [Inject]
        public void Constructor(TPresenter presenter)
        {
            _presenter = presenter;
            _presenter.Bind(view);
        }
    }

}
