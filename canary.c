#include "canary.h"

static void _destroy(Canary* this)
{
	this->observer->destroy(this->observer);

	if (this != NULL){
		free(this);
		this = NULL;
	}
}

static void _see(Canary * this, Cat* cat)
{
	cat->registerObserver(cat, this->observer);
	printf("%s Just saw %s\n", this->name, cat->name);
}

static void _handleCatEvent(Canary* this, Cat* cat)
{
	printf("%s\n just heard %s\n", this->name, cat->name);
}


static void _notify(Canary* this, int numero, void* subject) {
	_handleCatEvent(this, (Cat*) subject);
}

Canary* Canary_create(char* canarysName)
{
	Canary* this = (Canary*) malloc(sizeof(*this));

	this->name = canarysName;
	this->see = _see;
	this->destroy = _destroy;
	this->observer = observerNew(this, (void (*)(void*, int, void*))_notify);

	return this;
}