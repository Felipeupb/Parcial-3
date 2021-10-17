using System;
using System.Collections.Generic;
using System.Text;
//using Punto3_Entrega3.Clases.ObserverH;

namespace Punto3_Entrega3.Clases
{
    class ObserverC
    {
        static void _notify(Observer *this, int type, void *subject ) 
        {
            this->notifyImpl(this->impl, type, subject);
        }
        ObserverC* observerNew(void* impl, void(*notifyImpl)(void*, int, void*)) 
        {
            this->notify = _notify;
            this->impl = impl;
            this->notifyImpl = notifyImpl;

            return this;
        }
    }
}
