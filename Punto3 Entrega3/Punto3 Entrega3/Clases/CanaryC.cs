using System;
using System.Collections.Generic;
using System.Text;
//using Punto3_Entrega3.Clases.CanaryH;

namespace Punto3_Entrega3.Clases
{
    class CanaryC
    {
        static void _see() 
        {
            Cat->registerObserver(Cat, this->observer);
            Console.Write("[0] just heard [1]", this->name, Cat->name);
        }

        static void _handleCatEvent() 
        {
            Console.Write("[0] just heard [1]", this->name, Cat->name); 
        }
        static void _notify(*Canary this, int numero, void  *subject) 
        {
            _handleCatEvent(this, (*Cat) subject);
        }
        *Canary Canary_create(char* canarysName) 
        {
            this->name = canarysName;
            this->see = _see;
            this->observer = observerNew(this,(void (*)(void*, int, void*))_notify);

            return this;
        }
    }
}
