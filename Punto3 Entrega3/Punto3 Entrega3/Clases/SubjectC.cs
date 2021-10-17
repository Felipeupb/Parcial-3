using System;
using System.Collections.Generic;
using System.Text;
//using Punto3_Entrega3.Clases.SubjectH;

namespace Punto3_Entrega3.Clases
{
    class SubjectC
    {
        static int _registerObserver(Subject* this, Observer* observer)
        { 

            for (int i = 0; i < MAX_OBSERVERS; i++) 
            {
                if (this->observers[i] == null) 
                {
                    this->observers[i] = observer;

                    
                }
            }

            Console.Write("[INF] [SUBJECT] we have rush the max numbers of observers");

        }
        static int _unregisterObserver(Subject *this, Observer* observer) 
        {

            for (int i = 0; i < MAX_OBSERVERS; i++)
            {
                void* pObserver = this->observers[i];

                if (observer == pObserver)
                {
                    pObserver = NULL;
                    
                }
            }
        }
        static void _notifyObservers(Subject* this)
        {

            for (int i = 0; i < MAX_OBSERVERS; i++)
            {
                if (this->observers[i] != NULL)
                {
                    this->observers[i]->notify(this->observers[i], this->type, this->impl);
                }
            }
        }
        Subject* subjectNew(void* impl, int type)
        {
            this->impl = impl;
            this->type = type;
            this->registerObserver = _registerObserver;
            this->unregisterObserver = _unregisterObserver;
            this->notifyObservers = _notifyObservers;

            return this;
        }
    }
}
