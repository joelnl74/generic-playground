using Core.Interfaces;
using Gatcha;

public interface IGatchaPresenter : IPresenter<IGatchaView>
{
    public void Pull(ProductDefinition productDefinition);
}
