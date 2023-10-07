using Core.Interfaces;

namespace Core.Presenter
{
    public class Presenter<TView> : IPresenter<TView>
        where TView : class, IView
    {
        protected TView _view;

        public void Bind(TView view)
        {
            _view = view;
        }
    }

}
