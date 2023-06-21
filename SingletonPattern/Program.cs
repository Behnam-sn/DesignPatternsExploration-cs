// See https://aka.ms/new-console-template for more information
using SingletonPattern;

var singleton = Singleton.GetInstance();

var singletonWithSynchronization = SingletonWithSynchronization.GetInstance();

var singletonWithEagerInstantiation = SingletonWithEagerInstantiation.GetInstance();

var singletonWithDoubleCheckedLocking = SingletonWithDoubleCheckedLocking.GetInstance();