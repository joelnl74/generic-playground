namespace Core.Interfaces
{
    public interface IPresenter<in TView> where TView : IView
    {
        void Bind(TView IView);
    }
}
