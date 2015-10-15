using SourceCode.Hosting.Client.BaseAPI;
using SourceCode.SmartObjects.Authoring;
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



        }

        private void CreateSmartObject(SourceCode.SmartObjects.Management.SmartObjectManagementServer SmartObjectManagementSvr, K2Field.Apps.Framework.Build.SmartObjectDefinition SmO)
        {
            
            ServiceInstance serviceInstance = ServiceInstance.Create(SmartObjectManagementSvr.GetServiceInstanceForExtend(SmO.ServiceInstanceId, string.Empty));
            ExtendObject extendObject = serviceInstance.GetCreateExtender();

            extendObject.Name = SmO.SystemName;
            extendObject.Metadata.DisplayName = SmO.DisplayName;
            extendObject.Metadata.Description = SmO.Description;
            
            foreach(K2Field.Apps.Framework.Build.SmartObjectProperty prop in SmO.Properties)
            {
                ExtendObjectProperty SoProp = new ExtendObjectProperty();
                SoProp.Guid = prop.Id;
                SoProp.Name = prop.SystemName;
                SoProp.Metadata.DisplayName = prop.DisplayName;
                SoProp.Type = (PropertyDefinitionType)prop.DataType;
                if (prop.ExtendType != null)
                {
                    SoProp.ExtendType = (SourceCode.SmartObjects.Authoring.ExtendPropertyType)prop.ExtendType;
                }
                else
                {
                    SoProp.ExtendType = SourceCode.SmartObjects.Authoring.ExtendPropertyType.Default;
                }
                //ServiceElementDefinition
                ServiceElementDefinitionCollection
                //SoProp.Metadata.ServiceElements
                //ServiceElementDefinition a = new ServiceElementDefinition();
                //a.Guid = Guid.NewGuid();
                //a.Name = "maxsize";
                //a.Value = "100";
                

            }


            //// Create 'id' property
            //ExtendObjectProperty idProperty = new ExtendObjectProperty();
            //idProperty.Name = "Id";
            //idProperty.Metadata.DisplayName = idProperty.Name;
            //idProperty.Type = PropertyDefinitionType.Autonumber;
            //idProperty.ExtendType = ExtendPropertyType.UniqueIdAuto;

            //// Create 'name' property
            //ExtendObjectProperty nameProperty = new ExtendObjectProperty();
            //nameProperty.Name = "Name";
            //nameProperty.Metadata.DisplayName = nameProperty.Name;
            //nameProperty.Type = PropertyDefinitionType.Text;

            // Create other properties here as needed
            // Add the new properties below

            //foreach (ExtendObjectProperty item in properties)
            //{
            //    extendObject.Properties.Add(item);
            //}

            // Add properties
            //extendObject.Properties.Add(idProperty);
            //extendObject.Properties.Add(nameProperty);

            SmartObjectDefinition smoDefinition = new SmartObjectDefinition();

            

            // Create SmartObject Definition
            //smoDefinition.Create(extendObject);
            //smoDefinition.Build();



            //return smoDefinition;
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
