using System;
using System.Collections.Generic;
using System.Text;
//using Punto3_Entrega3.Clases.DogC;

namespace Punto3_Entrega3.Clases
{
    class DogC
    {
        static void _smell(Dog* this, Cat* cat) 
        {
            cat.registerObserver(cat, this->observer);
            Console.Write("[0] Just smelled [1]", this->name, cat->name);
        }
        static void _handleCatEvent(Dog* this, Cat* cat) 
        {
            Console.Write("[0] just heard [1]", this->name, cat->name);
        }
        static void _notify(Dog* this, int numero, void* subject) 
        {
            _handleCatEvent(this, (Cat*)subject);
        }
        Dog* DOG_create(char* dogsName)
        {
            this->name = dogsName;
            this->smell = _smell;
            this->observer = observerNew(this, (void(*)(void*, int, void*))_notify);

            return this;
        }
    }
}
