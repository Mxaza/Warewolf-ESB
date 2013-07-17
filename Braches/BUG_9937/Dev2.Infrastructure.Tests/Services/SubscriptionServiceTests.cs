﻿using System;
using Dev2.Providers.Events;
using Dev2.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Dev2.Infrastructure.Tests.Services
{
    [TestClass]
    public class SubscriptionServiceTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SubscriptionServiceConstructorWithNullArgsExpectedThrowsArgumentNullException()
        {
            var service = new SubscriptionService<object>(null);
        }

        [TestMethod]
        public void SubscriptionServiceSubscribeWithArgsExpectedAddsSubscription()
        {
            var publisher = CreatePublisher();
            var service = new SubscriptionService<object>(publisher.Object);
            Assert.AreEqual(0, service.Count);
            service.Subscribe(null, memo => { });
            service.Subscribe(o => o != null, memo => { });
            Assert.AreEqual(2, service.Count);
        }

        [TestMethod]
        public void SubscriptionServiceDisposeExpectedDisposesSubscriptions()
        {
            var publisher = CreatePublisher();
            var service = new SubscriptionService<object>(publisher.Object);

            service.Subscribe(null, obj => { });
            Assert.AreEqual(1, service.Count);
            service.Dispose();
            Assert.AreEqual(0, service.Count);
        }

        static Mock<IEventPublisher> CreatePublisher()
        {
            var subscription = new Mock<IDisposable>();

            var observable = new Mock<IObservable<object>>();
            observable.Setup(o => o.Subscribe(It.IsAny<IObserver<object>>())).Returns(subscription.Object);

            var publisher = new Mock<IEventPublisher>();
            publisher.Setup(p => p.GetEvent<object>()).Returns(observable.Object);
            return publisher;
        }
    }
}
