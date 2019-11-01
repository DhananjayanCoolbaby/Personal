// <copyright file="NinjectControllerFactory.cs" company="CTS">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary>
// Global Config
// </summary>
//-----------------------------------------------------------------------
namespace CWR.Web
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Ninject;
    using CWR.BusinessService;
    using CWR.Repository;
    using CWR.Utility;

    /// <summary>
    /// NInject Controller Factory Methods
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design",
        "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable",
        Justification = "Justification")]
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        /// <summary>
        /// Kernel service
        /// </summary>
        private IKernel ninjectKernel;

        /// <summary>
        /// Initializes a new instance of the <see cref="NinjectControllerFactory" /> class.
        /// </summary>
        public NinjectControllerFactory()
        {
            this.ninjectKernel = new StandardKernel();
            this.AddBindings();
        }

        ////Get controller instance

        /// <summary>
        /// Get Controller Instance
        /// </summary>
        /// <param name="requestContext">request context</param>
        /// <param name="controllerType">controller type</param>
        /// <returns>dependency object</returns>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            //// returning controller type
            return controllerType == null
                       ? null
                       : (IController)this.ninjectKernel.Get(controllerType);
        }

        /// <summary>
        /// Define Bindings
        /// </summary>
        private void AddBindings()
        {
            ////declaring dependency mapper
            DependencyMapper dependency = new DependencyMapper();
            dependency.LoadDependency(this.ninjectKernel);
            DependencyMapperForDataAccess dependencyDataAccess = new DependencyMapperForDataAccess();
            dependencyDataAccess.LoadDependency(this.ninjectKernel);
        }
    }
}