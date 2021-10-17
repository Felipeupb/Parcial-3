using System;
using System.Collections.Generic;
using System.Text;
//using Punto3_Entrega3.Clases.ObserverH;

namespace Punto3_Entrega3.Clases
{
    class SubjectH
    {
        int type;
        void* impl;
        Observer * observers[MAX_OBSERVERS];
        int (* registerObserver) (struct __subject*, Observer*);
	    int (* unregisterObserver) (struct __subject *, Observer*);
	    void (* notifyObservers) (struct __subject*);

        Subject * subjectNew(void*, int);
    }
}
