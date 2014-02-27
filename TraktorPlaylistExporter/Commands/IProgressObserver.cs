using System;
using System.Collections.Generic;
using System.Linq;

namespace TraktorPlaylistExporter
{
    public interface IProgressObserver
    {
        void OnOperationStarted(string text);

        void OnStepCompleted(string text);

        void OnOperationEnded(string text);

        void OnError(string error);
    }
}
