﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Linq.Expressions;
using Caliburn.Micro;
using Dev2.Composition;
using Dev2.Data.ServiceModel.Messages;
using Dev2.Providers.Errors;
using Dev2.Providers.Events;
using Dev2.Studio.Core;
using Dev2.Studio.Core.AppResources.Enums;
using Dev2.Studio.Core.Interfaces;
using Dev2.Studio.Core.Messages;
using Dev2.Studio.Webs.Callbacks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dev2.Core.Tests.Webs
{
    [TestClass]
    public class ServiceCallbackHandlerTests
    {
        static ImportServiceContext _importContext;

        private static Mock<IEventAggregator> _eventAgrregator;

        #region Class/TestInitialize

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _importContext = new ImportServiceContext();
            ImportService.CurrentContext = _importContext;

            ImportService.Initialize(new List<ComposablePartCatalog>
            {
                new FullTestAggregateCatalog()
            });
            ImportService.AddExportedValueToContainer<IFrameworkSecurityContext>(new MockSecurityProvider(""));
            _eventAgrregator = new Mock<IEventAggregator>();
            ImportService.AddExportedValueToContainer(_eventAgrregator.Object);

        }

        [TestInitialize]
        public void TestInitialize()
        {
            ImportService.CurrentContext = _importContext;
        }

        #endregion

        #region Save

        [TestMethod]
        public void ServiceCallbackHandlerSaveWithValidArgsExpectedPublishesUpdateResourceMessage()
        {
            const string ResourceName = "TestService";

            var showDependencyProvider = new Mock<IShowDependencyProvider>();


            var resourceModel = new Mock<IResourceModel>();
            resourceModel.Setup(r => r.ResourceName).Returns(ResourceName);

            var resourceRepo = new Mock<IResourceRepository>();
            resourceRepo.Setup(r => r.ReloadResource(It.IsAny<string>(), It.IsAny<ResourceType>(), It.IsAny<IEqualityComparer<IResourceModel>>()))
                .Returns(new List<IResourceModel> { resourceModel.Object });

            var envModel = new Mock<IEnvironmentModel>();
            envModel.Setup(e => e.ResourceRepository).Returns(resourceRepo.Object);

            var aggregator = new Mock<IEventAggregator>();
            var envRepo = new Mock<IEnvironmentRepository>();
            var handler = new ServiceCallbackHandlerMock(envRepo.Object, showDependencyProvider.Object) { EventAggregator = aggregator.Object };

            aggregator.Setup(e => e.Publish(It.IsAny<UpdateResourceMessage>()))
                .Callback<Object>(m =>
                {
                    var msg = (UpdateResourceMessage)m;
                    Assert.AreEqual(ResourceName, msg.ResourceModel.ResourceName);
                })
                .Verifiable();

            var jsonObj = JObject.Parse("{ 'ResourceName': '" + ResourceName + "','ResourceType':'Service'}");
            handler.TestSave(envModel.Object, jsonObj);

            aggregator.Verify(e => e.Publish(It.IsAny<UpdateResourceMessage>()), Times.Once());
        }

        [TestMethod]
        public void ServiceCallbackHandlerSaveWithValidArgsWithMessages()
        {
            //------------------------------Setup-------------------------------------------------
            Mock<IShowDependencyProvider> showDependencyProvider;
            Mock<IResourceRepository> resourceRepo;
            const string ResourceName = "TestService";
            SetupObjects(out showDependencyProvider, out resourceRepo, ResourceName);

            var compileMessageTos = new List<CompileMessageTO> { new CompileMessageTO() };

            var envConnection = SetupConnectionWithCompileMessageList(compileMessageTos);

            var envModel = new Mock<IEnvironmentModel>();
            envModel.Setup(e => e.ResourceRepository).Returns(resourceRepo.Object);
            envModel.Setup(e => e.Connection).Returns(envConnection.Object);

            var aggregator = new Mock<IEventAggregator>();
            var envRepo = new Mock<IEnvironmentRepository>();
            var handler = new ServiceCallbackHandlerMock(envRepo.Object, showDependencyProvider.Object) { EventAggregator = aggregator.Object };

            var jsonObj = JObject.Parse("{ 'ResourceName': '" + ResourceName + "','ResourceType':'Service'}");
            //------------------------------Execute -------------------------------------------------
            handler.TestSave(envModel.Object, jsonObj);
            //------------------------------Assert Result -------------------------------------------------
            showDependencyProvider.Verify(provider => provider.ShowDependencyViewer(It.IsAny<IContextualResourceModel>(), 1, aggregator.Object), Times.Once());
        }

        static Mock<IEnvironmentConnection> SetupConnectionWithCompileMessageList(List<CompileMessageTO> compileMessageTos)
        {
            CompileMessageList compileMessageList = new CompileMessageList();
            compileMessageList.MessageList = compileMessageTos;
            compileMessageList.NumberOfDependants = 1;
            string serializeObject = JsonConvert.SerializeObject(compileMessageList);
            var envConnection = new Mock<IEnvironmentConnection>();
            envConnection.Setup(c => c.ServerEvents).Returns(new EventPublisher());
            envConnection.Setup(connection => connection.ExecuteCommand(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<Guid>()))
                .Returns(serializeObject);
            return envConnection;
        }

        [TestMethod]
        public void ServiceCallbackHandlerSaveWithValidArgsWithNoMessages()
        {
            //------------------------------Setup-------------------------------------------------
            Mock<IShowDependencyProvider> showDependencyProvider;
            Mock<IResourceRepository> resourceRepo;
            const string ResourceName = "TestService";
            SetupObjects(out showDependencyProvider, out resourceRepo, ResourceName);

            var envConnection = SetupConnectionWithCompileMessageList(new List<CompileMessageTO>());

            var envModel = new Mock<IEnvironmentModel>();
            envModel.Setup(e => e.ResourceRepository).Returns(resourceRepo.Object);
            envModel.Setup(e => e.Connection).Returns(envConnection.Object);

            var aggregator = new Mock<IEventAggregator>();
            var envRepo = new Mock<IEnvironmentRepository>();
            var handler = new ServiceCallbackHandlerMock(envRepo.Object, showDependencyProvider.Object) { EventAggregator = aggregator.Object };
            var jsonObj = JObject.Parse("{ 'ResourceName': '" + ResourceName + "','ResourceType':'Service'}");
            //------------------------------Execute -------------------------------------------------
            handler.TestSave(envModel.Object, jsonObj);
            //------------------------------Assert Result -------------------------------------------------
            showDependencyProvider.Verify(provider => provider.ShowDependencyViewer(It.IsAny<IContextualResourceModel>(), 1, aggregator.Object), Times.Never());
        }

        static IResourceModel SetupObjects(out Mock<IShowDependencyProvider> showDependencyProvider, out Mock<IResourceRepository> resourceRepo, string resourceName)
        {
            showDependencyProvider = new Mock<IShowDependencyProvider>();

            var resourceModel = new Mock<IResourceModel>();
            resourceModel.Setup(r => r.ResourceName).Returns(resourceName);
            resourceModel.Setup(r => r.Errors).Returns(new ObservableReadOnlyList<IErrorInfo>());

            resourceRepo = new Mock<IResourceRepository>();
            resourceRepo.Setup(r => r.ReloadResource(It.IsAny<string>(), It.IsAny<ResourceType>(), It.IsAny<IEqualityComparer<IResourceModel>>()))
                .Returns(new List<IResourceModel> { resourceModel.Object });
            resourceRepo.Setup(repository => repository.FindSingle(It.IsAny<Expression<Func<IResourceModel, bool>>>()))
                .Returns(resourceModel.Object);
            return resourceModel.Object;
        }

        #endregion



    }
}