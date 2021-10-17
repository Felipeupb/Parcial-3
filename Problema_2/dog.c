#include "dog.h"

static void _destroy(Dog* this)
{
	this->observer->destroy(this->observer);

	if (this != NULL){
		free(this);
		this = NULL;
	}
}

static void _smell(Dog * this, Cat* cat)
{
	cat->registerObserver(cat, this->observer);
	printf("%s Just smelled %s\n", this->name, cat->name);
}

static void _handleCatEvent(Dog* this, Cat* cat)
{
	printf("%s\n just heard %s\n", this->name, cat->name);
}


static void _notify(Dog* this, int numero, void* subject) {
	_handleCatEvent(this, (Cat*) subject);
}

Dog* DOG_create(char* dogsName)
{
	Dog* this = (Dog*) malloc(sizeof(*this));

	this->name = dogsName;
	this->smell = _smell;
	this->destroy = _destroy;
	this->observer = observerNew(this, (void (*)(void*, int, void*))_notify);

	return this;
}

