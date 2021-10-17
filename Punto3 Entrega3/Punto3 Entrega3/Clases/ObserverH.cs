using System;
using System.Collections.Generic;
using System.Text;
//using Punto3_Entrega3.Clases.CommonH;
namespace Punto3_Entrega3.Clases
{
    class ObserverH
    {
        void* impl;
        void (* notify) (struct _observer*, int, void*);
        void (*notifyImpl) (void*, int, void*);

        Observer* observerNew(void*, void(*)(void*, int, void*));
    }
