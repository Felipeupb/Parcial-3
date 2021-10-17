using System;
using System.Collections.Generic;
using System.Text;

namespace Punto3_Entrega3.Clases
{
    class CatC
    {
        static void _speak(Cat* this) 
        {
            Console.Write("[0]", "My name is:");
            Console.Write("[0]", this->name);
            Console.Write("[0]", "Miaaaau");
            this->event = _speak;
            this->subject->notifyObservers(this->subject);
        }
        static CatEvent _getEvent(Cat* this) 
        {
            return this->event;
        }
        static int _registerObserver(Cat* this, Observer* observer) 
        { 
            return this->subject->registerObserver(this->subject, )
        }
        static int _unregisterObserver(Cat* this, Observer* observer) 
        {
            return this->subject->unregisterObserver(this->subject, observer);
        }
        Cat* CAT_create(char* name) 
        {
            this->name = name;
            this->getEvent = _getEvent;
            this->speak = _speak;

            this->subject = subjectNew(this, 1);
            this->registerObserver = _registerObserver;
            this->unregisterObserver = _unregisterObserver;

            return this;
        }

    }
}
