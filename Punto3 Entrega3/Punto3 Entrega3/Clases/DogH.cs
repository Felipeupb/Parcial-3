using System;
using System.Collections.Generic;
using System.Text;
//using Punto3_Entrega3.Clases.ObserverH;
//using Punto3_Entrega3.Clases.CatH;

namespace Punto3_Entrega3.Clases
{
    class DogH
    {
        char* name;
        void (*smell)(struct_dog*, Cat*);
        Observer* observer;

        Dog* DOG_create(char*);
    }
}
