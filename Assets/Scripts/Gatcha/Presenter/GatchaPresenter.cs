using Core.Interfaces;
using Core.Presenter;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GatchaPresenter : Presenter<IGatchaView>,
    IGatchaPresenter
{
    private List<BaseEntity> _entitiesPulled = new List<BaseEntity>();

    public void Pull(ProductDefinition productDefinition)
    {
        if (_entitiesPulled.Count > 0)
        {
            GetNext();

            return;
        }

        _entitiesPulled = productDefinition.GetRandomPulls(10);
        GetNext();
    }

    private void GetNext()
    {
        var entity = _entitiesPulled.FirstOrDefault();

        if (entity == null)
        {
            // Call view end.
            _view.DidComplete();
            _entitiesPulled = null;

            return;
        }

        _view.DidLoadData(entity);
        _entitiesPulled.RemoveAt(0);
    }
}
