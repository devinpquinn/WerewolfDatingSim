using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Naninovel.Async.CompilerServices
{
    internal class MoveNextRunner<TStateMachine>
        where TStateMachine : IAsyncStateMachine
    {
        public TStateMachine StateMachine;

        [DebuggerHidden]
        public void Run ()
        {
            StateMachine.MoveNext();
        }
    }
}
