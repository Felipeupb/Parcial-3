using System;
using System.Collections.Generic;
using System.Text;
//using Punto3_Entrega3.Clases.ObserverH;
//using Punto3_Entrega3.Clases.SubjectH;

namespace Punto3_Entrega3.Clases
{
    class CatH
    {
        char* name;
        void (*destroy)();

        CatEvent event;
        CatEvent (*getEvent)(struct _cat*);

        void (*speak)(struct _cat*);

        Subject* subject;
        int (* registerObserver) (struct __cat*, Observer*);
        int (* unregisterObserver) (struct __cat *, Observer*);

        Cat* CAT_create(char*);
    }
}
