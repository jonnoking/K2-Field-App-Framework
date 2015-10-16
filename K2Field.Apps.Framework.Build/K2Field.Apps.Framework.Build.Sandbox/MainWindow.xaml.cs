using SourceCode.Hosting.Client.BaseAPI;
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




            SourceCode.SmartObjects.Management.SmartObjectManagementServer SmartObjectManagementSvr = GetSmOServer();
            SmartObjectDefinition appType = new AppType().GetDefinition();
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition Def = CreateSmartObject(SmartObjectManagementSvr, appType);
            
            //SmartObjectManagementSvr.PublishSmartObject(Def.ToXml(), "Test Category");


            SmartObjectDefinitionsPublish smoPublish = new SmartObjectDefinitionsPublish();
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppBusinessAudit().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppException().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppInstance().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppKPI().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppPriority().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppProcess().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppStage().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppStageAction().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppStatus().GetDefinition())));
            smoPublish.SmartObjects.Add(CreateSmartObject(SmartObjectManagementSvr, (new AppType().GetDefinition())));
            
            PublishSmartObjects(smoPublish);
        }

        private SourceCode.SmartObjects.Authoring.SmartObjectDefinition CreateSmartObject(SourceCode.SmartObjects.Management.SmartObjectManagementServer SmartObjectManagementSvr, K2Field.Apps.Framework.Build.SmartObjectDefinition SmO)
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
                //smoDefinition.AddDeploymentCategory("test category");
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
