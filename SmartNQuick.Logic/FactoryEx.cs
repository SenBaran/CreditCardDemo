//@Ignore
using CommonBase.Extensions;
using SmartNQuick.Contracts;
using SmartNQuick.Contracts.Client;
using SmartNQuick.Contracts.Persistence;
using SmartNQuick.Logic.Contracts;
using SmartNQuick.Logic.Controllers;
using SmartNQuick.Logic.Controllers.BookLibrary;
using System;

namespace SmartNQuick.Logic
{
	partial class Factory
	{

        static partial void CreateController<C>(ControllerObject controllerObject, ref IControllerAccess<C> controller) where C : IIdentifiable
        {
            controllerObject.CheckArgument(nameof(controllerObject));
            if (typeof(C) == typeof(IBookLibrary))
            {
                controller = new BookLibraryController(controllerObject) as IControllerAccess<C>;
            }
        }

        static partial void CreateController<C>(IContext context, ref IControllerAccess<C> controller) where C : IIdentifiable
        {
   
            if (typeof(C) == typeof(IBookLibrary))
            {
                controller = new BookLibraryController(context) as IControllerAccess<C>;
            }
        }
    }
}
