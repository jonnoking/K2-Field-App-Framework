﻿using SourceCode.Hosting.Client.BaseAPI;
using SourceCode.SmartObjects.Authoring;
using SourceCode.SmartObjects.Management;
using SourceCode.SmartObjects.Services.Management;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace K2Field.Apps.Framework.Build.Sandbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void btnCreateFrameworkSmartObjects_Click(object sender, RoutedEventArgs e)
        {
            //string BaseDirectory = @"C:\Development\K2 Field App Framework";
            //System.IO.File.WriteAllText(BaseDirectory + "\\K2App.Core.SMO.AppType.json", Newtonsoft.Json.JsonConvert.SerializeObject(AppType));

            SourceCode.SmartObjects.Management.SmartObjectManagementServer Server = GetSmOServer();
            

            Dictionary<Guid, string> FrameworkSmartObjects = new Dictionary<Guid, string>();
            FrameworkSmartObjects.Add(new Guid("5a3c77f1-731f-4930-a1ec-533dd8300ff3"), "K2App_Core_SMO_AppBusinessAudit");
            FrameworkSmartObjects.Add(new Guid("0c020fc7-8611-4826-9399-904ba5873100"), "K2App_Core_SMO_AppException");
            FrameworkSmartObjects.Add(new Guid("9b9c753b-b8cc-4108-80c6-ba14141d8f6f"), "K2App_Core_SMO_AppInstance");
            FrameworkSmartObjects.Add(new Guid("c501ff73-20ef-44ac-a5fe-9e35fc92df79"), "K2App_Core_SMO_AppKPI");
            FrameworkSmartObjects.Add(new Guid("74c9793e-e9cc-44b7-8f03-465b40abe117"), "K2App_Core_SMO_AppPriority");
            FrameworkSmartObjects.Add(new Guid("2A2FED0D-3141-411C-96A7-2EC1CDD1E78E"), "K2App_Core_SMO_AppProcess");
            FrameworkSmartObjects.Add(new Guid("6d8facc6-40da-4a74-b8cc-f9bec1b9cc25"), "K2App_Core_SMO_AppStage");
            FrameworkSmartObjects.Add(new Guid("e9de772e-3ab7-417a-b07d-3acf862fbddd"), "K2App_Core_SMO_AppStageAction");
            FrameworkSmartObjects.Add(new Guid("7d89eee6-cda0-4e74-b47c-296acd4959a7"), "K2App_Core_SMO_AppStatus");
            FrameworkSmartObjects.Add(new Guid("5a82e2fc-cd5b-4346-b508-d01095a51de3"), "K2App_Core_SMO_AppType");

            SmartObjectExplorer smoExp = Server.GetSmartObjects(FrameworkSmartObjects.Values.ToArray());
            foreach(SmartObjectInfo smo in smoExp.SmartObjectList)
            {
                Server.DeleteSmartObject(smo.Guid, true);
            }

            

            
            //SmartObjectManagementSvr.PublishSmartObject(Def.ToXml(), "Test Category");

            string DeploymentCategory = @"New App Framework\SmartObjects";

            //SmartObjectDefinitionsPublish smoPublish = new SmartObjectDefinitionsPublish();

            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppBusinessAudit().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppException().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppInstance().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppKPI().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppPriority().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppProcess().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppStage().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppStageAction().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppStatus().GetDefinition()), DeploymentCategory));
            //smoPublish.SmartObjects.Add(CreateSmartObject(Server, (new AppType().GetDefinition()), DeploymentCategory));

            //Server.PublishSmartObjects(smoPublish.ToPublishXml());

            SourceCode.SmartObjects.Authoring.SmartObjectDefinition AuditDef = CreateSmartObject(Server, (new AppBusinessAudit().GetDefinition()), DeploymentCategory);
            Server.DeploySmartObject(AuditDef.ToXml(), AuditDef.Guid);

        }

        private SourceCode.SmartObjects.Authoring.SmartObjectDefinition CreateSmartObject(SourceCode.SmartObjects.Management.SmartObjectManagementServer SmartObjectManagementSvr, K2Field.Apps.Framework.Build.SmartObjectDefinition SmO, string DeploymentCategory)
        {
            
            ServiceInstance serviceInstance = ServiceInstance.Create(SmartObjectManagementSvr.GetServiceInstanceForExtend(SmO.ServiceInstanceId, string.Empty));
            ExtendObject extendObject = serviceInstance.GetCreateExtender();

            extendObject.Guid = SmO.Id;
            extendObject.Name = SmO.SystemName;
            extendObject.Metadata.DisplayName = SmO.DisplayName;
            extendObject.Metadata.Description = SmO.Description;
               

            foreach(K2Field.Apps.Framework.Build.SmartObjectProperty prop in SmO.Properties)
            {
                ExtendObjectProperty SoProp = new ExtendObjectProperty();
                SoProp.Guid = prop.Id;
                SoProp.Name = prop.SystemName.Replace(" ", "_").Replace(".", "_");
                SoProp.Metadata.DisplayName = prop.DisplayName;
                SoProp.Type = (PropertyDefinitionType)prop.DataType;
                SoProp.ExtendType = (SourceCode.SmartObjects.Authoring.ExtendPropertyType)prop.ExtendType;
                
                if (prop.MaxSize.HasValue && prop.MaxSize.Value > 0)
                {
                    SoProp.Metadata.AddServiceElement("maxsize", prop.MaxSize.Value.ToString());
                }
                else
                {
                    SoProp.Metadata.AddServiceElement("maxsize", "200");
                }

                if (!extendObject.Properties.ContainsName(prop.SystemName))
                {
                    extendObject.Properties.Add(SoProp);
                }                
            }

            


            SourceCode.SmartObjects.Authoring.SmartObjectDefinition smoDefinition = new SourceCode.SmartObjects.Authoring.SmartObjectDefinition();
            
            try
            {

                // Create SmartObject Definition
                smoDefinition.Create(extendObject);
                smoDefinition.AddDeploymentCategory(DeploymentCategory);
                
                smoDefinition.Build();
            }
            catch (SmartObjectDefinitionException defEx)
            {
                MessageBox.Show(defEx.Message);
                throw;
            }


            return smoDefinition;
        }

        private SourceCode.SmartObjects.Management.SmartObjectManagementServer GetSmOServer()
        {
            SCConnectionStringBuilder ConnectionString = new SCConnectionStringBuilder();
            ConnectionString.Authenticate = true;
            ConnectionString.IsPrimaryLogin = true;
            ConnectionString.Integrated = true;
            ConnectionString.Host = "localhost";
            ConnectionString.Port = 5555;

            SourceCode.SmartObjects.Management.SmartObjectManagementServer SmartObjectManagementSvr = new SourceCode.SmartObjects.Management.SmartObjectManagementServer();
            SmartObjectManagementSvr.CreateConnection();
            SmartObjectManagementSvr.Connection.Open(ConnectionString.ConnectionString);

            //ServiceManagementSvr = new ServiceManagementServer();
            //ServiceManagementSvr.Connection = SmartObjectManagementSvr.Connection;

            return SmartObjectManagementSvr;
        }

    }
}
