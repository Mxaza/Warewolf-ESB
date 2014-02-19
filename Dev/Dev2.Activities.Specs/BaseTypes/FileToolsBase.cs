using System;
using System.Net;
using Dev2.PathOperations;
using Nuane.Net;
using TechTalk.SpecFlow;

namespace Dev2.Activities.Specs.BaseTypes
{
    [Binding]
    public class FileToolsBase : RecordSetBases
    {
        public static SftpServer Server;
        public static readonly object ServerLock = new object();

        #region Overrides of RecordSetBases

        protected override void BuildDataList()
        {
        }

        /// <summary>
        /// Starts the SFTP server.
        /// </summary>
        protected static void StartSftpServer()
        {
            lock(ServerLock)
            {
                if(Server == null)
                {
                    SshKey rsaKey = SshKey.Generate(SshKeyAlgorithm.RSA, 1024);
                    SshKey dssKey = SshKey.Generate(SshKeyAlgorithm.DSS, 1024);

                    // add keys, bindings and users
                    Server = new SftpServer { Log = Console.Out };
                    Server.Keys.Add(rsaKey);
                    Server.Keys.Add(dssKey);
                    Server.Bindings.Add(IPAddress.Any, 22);
                    Server.Users.Add(new SshUser("dev2", "Q/ulw&]", @"C:\Temp"));
                    // start the server                                                    
                    Server.Start();
                }
            }
        }

        protected static void RemovedFilesCreatedForTesting()
        {
            // ReSharper disable EmptyGeneralCatchClause

            var broker = ActivityIOFactory.CreateOperationsBroker();
            string destLocation;
            if(ScenarioContext.Current.TryGetValue(CommonSteps.ActualDestinationHolder, out destLocation))
            {
                IActivityIOPath dst = ActivityIOFactory.CreatePathFromString(destLocation,
                    ScenarioContext.Current.Get<string>(CommonSteps.DestinationUsernameHolder),
                    ScenarioContext.Current.Get<string>(CommonSteps.DestinationPasswordHolder),
                    true);
                IActivityIOOperationsEndPoint dstEndPoint = ActivityIOFactory.CreateOperationEndPointFromIOPath(dst);
                try
                {
                    broker.Delete(dstEndPoint);
                }
                catch(Exception)
                {
                    //The file may already be deleted
                }
            }

            IActivityIOPath source = ActivityIOFactory.CreatePathFromString(ScenarioContext.Current.Get<string>(CommonSteps.ActualSourceHolder),
                ScenarioContext.Current.Get<string>(CommonSteps.SourceUsernameHolder),
                ScenarioContext.Current.Get<string>(CommonSteps.SourcePasswordHolder),
                true);
            IActivityIOOperationsEndPoint sourceEndPoint = ActivityIOFactory.CreateOperationEndPointFromIOPath(source);
            try
            {
                broker.Delete(sourceEndPoint);
            }
            catch(Exception)
            {
                //The file may already be deleted
            }

            try
            {
                if(Server != null)
                {
                    Server.Bindings.Clear();
                    Server.Stop();
                }
            }
            catch
            {
                //Server may already be stopped
            }
            Server = null;
        }
        #endregion
    }
}