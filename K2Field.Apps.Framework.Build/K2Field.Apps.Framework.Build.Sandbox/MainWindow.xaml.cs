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

        SourceCode.SmartObjects.Management.SmartObjectManagementServer Server = null;
        SourceCode.SmartObjects.Client.SmartObjectClientServer Client = null;

        public MainWindow()
        {
            InitializeComponent();
            Server = GetSmOMgmServer();
            Client = GetSmOServer();
        }



        private void btnCreateFrameworkSmartObjects_Click(object sender, RoutedEventArgs e)
        {
            //string BaseDirectory = @"C:\Development\K2 Field App Framework";
            //System.IO.File.WriteAllText(BaseDirectory + "\\K2App.Core.SMO.AppType.json", Newtonsoft.Json.JsonConvert.SerializeObject(AppType));

            //SourceCode.SmartObjects.Management.SmartObjectManagementServer Server = GetSmOServer();
                      
            
            //SmartObjectManagementSvr.PublishSmartObject(Def.ToXml(), "Test Category");

            string DeploymentCategory = @"App Framework\SmartObjects";
            string LookupCategory = @"App Framework\Lookups";

            SmartObjectDefinitionsPublish smoPublish = new SmartObjectDefinitionsPublish();
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdAudit = CreateSmartBoxSmartObject(Server, (new AppBusinessAudit().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdAudit);


            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdException = CreateSmartBoxSmartObject(Server, (new AppException().GetDefinition()), DeploymentCategory);           
            smoPublish.SmartObjects.Add(sdException);

            
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdInstance = CreateSmartBoxSmartObject(Server, (new AppInstance().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdInstance);


            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdKPI = CreateSmartBoxSmartObject(Server, (new AppKPI().GetDefinition()), LookupCategory);
            smoPublish.SmartObjects.Add(sdKPI);


            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdPriority = CreateSmartBoxSmartObject(Server, (new AppPriority().GetDefinition()), LookupCategory);
            smoPublish.SmartObjects.Add(sdPriority);

            
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdProcess = CreateSmartBoxSmartObject(Server, (new AppProcess().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdProcess);

            
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdStage = CreateSmartBoxSmartObject(Server, (new AppStage().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdStage);

            
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdStageAction = CreateSmartBoxSmartObject(Server, (new AppStageAction().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdStageAction);

            
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdStatus = CreateSmartBoxSmartObject(Server, (new AppStatus().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdStatus);

            
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdType = CreateSmartBoxSmartObject(Server, (new AppType().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdType);

            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdTypeAction = CreateSmartBoxSmartObject(Server, (new AppTypeAction().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdTypeAction);

            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdImage = CreateSmartBoxSmartObject(Server, (new AppImage().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdImage);



            // App Instance to App Business Audit
            sdInstance.AddAssociation(sdAudit, sdAudit.Properties["App_Instance_ID"], sdInstance.Properties["ID"], "AppInstanceAppBusinessAudt");
            // App Instance to App Process
            sdInstance.AddAssociation(sdProcess, sdProcess.Properties["App_Instance_ID"], sdInstance.Properties["ID"], "AppInstanceAppProcess");
            // Parent App Instance to App Instance
            sdInstance.AddAssociation(sdInstance, sdProcess.Properties["ID"], sdInstance.Properties["Parent_Application_Instance_ID"], "ParentAppInstanceAppInstance");


            // App Type to App Stage
            sdType.AddAssociation(sdStage, sdStage.Properties["App_Type_ID"], sdType.Properties["ID"], "AppTypeAppStage");

            // App Type to App Status
            sdType.AddAssociation(sdStatus, sdStatus.Properties["App_Type_ID"], sdType.Properties["ID"], "AppTypeAppStatus");

            // App Type to App Type Action
            sdType.AddAssociation(sdTypeAction, sdTypeAction.Properties["App_Type_ID"], sdType.Properties["ID"], "AppTypeAppTypeAction");

            // App Type Action to Image
            sdImage.AddAssociation(sdTypeAction, sdTypeAction.Properties["Icon_ID"], sdImage.Properties["ID"], "AppImageAppTypeActionIcon");

            // App Type to Image
            sdImage.AddAssociation(sdType, sdType.Properties["Icon_ID"], sdImage.Properties["ID"], "AppImageAppTypeIcon");

            // App Stage Action to Image
            sdImage.AddAssociation(sdStageAction, sdStageAction.Properties["Icon_ID"], sdImage.Properties["ID"], "AppImageAppStageActionIcon");

            // App Type to App KPI
            //sdType.AddAssociation(sdKPI, sdKPI.Properties["App_Type_ID"], sdType.Properties["ID"], "AppTypeAppKPI");

            // App Type to App Priority
            //sdType.AddAssociation(sdPriority, sdStatus.Properties["App_Type_ID"], sdPriority.Properties["ID"], "AppTypeAppPriority");

            // App Stage to App Stage Action
            sdStage.AddAssociation(sdStageAction, sdStageAction.Properties["App_Stage_ID"], sdStage.Properties["ID"], "AppStageAppStageAction");


            // NEED TO CREATE APP TYPE ACTION object

            Server.PublishSmartObjects(smoPublish.ToPublishXml());

            //SourceCode.SmartObjects.Authoring.SmartObjectDefinition AuditDef = CreateSmartBoxSmartObject(Server, (new AppBusinessAudit().GetDefinition()), DeploymentCategory);
            //Server.DeploySmartObject(AuditDef.ToSmartObjectDeployXml(), AuditDef.Guid);

            //SourceCode.SmartObjects.Authoring.SmartObjectDefinition ExcDef = CreateSmartObject(Server, (new AppException().GetDefinition()), DeploymentCategory);
            
            //Server.DeploySmartObject(ExcDef.ToSmartObjectDeployXml(), ExcDef.Guid);

            //string InstanceAudit = Server.GetAssociationSmartObject(Guid.NewGuid());
            //AssociationSmartObject a = AssociationSmartObject.Create(sdAudit.to




            smoPublish = new SmartObjectDefinitionsPublish();


            MessageBox.Show("Framework Created");

        }

        private SourceCode.SmartObjects.Authoring.SmartObjectDefinition CreateSmartBoxSmartObject(SourceCode.SmartObjects.Management.SmartObjectManagementServer SmartObjectManagementSvr, K2Field.Apps.Framework.Build.SmartObjectDefinition SmO, string DeploymentCategory)
        {
            
            ServiceInstance serviceInstance = ServiceInstance.Create(SmartObjectManagementSvr.GetServiceInstanceForExtend(SmO.ServiceInstanceId, string.Empty));
            ExtendObject extendObject = serviceInstance.GetCreateExtender();            
            // do set ID here - set on SmartObjectDefinition - extender is specifically for SmartBox
            //extendObject.Guid = SmO.Id;
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

                if (prop.DataType == SmODataType.Text)
                {
                    if (prop.MaxSize.HasValue && prop.MaxSize.Value > 0)
                    {
                        SoProp.Metadata.AddServiceElement("maxsize", prop.MaxSize.Value.ToString());
                    }
                    else
                    {
                        SoProp.Metadata.AddServiceElement("maxsize", "200");
                    }
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
                
                // must set the SmartObject Id here
                smoDefinition.Guid = SmO.Id;
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

        private SourceCode.SmartObjects.Management.SmartObjectManagementServer GetSmOMgmServer()
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

        private SourceCode.SmartObjects.Client.SmartObjectClientServer GetSmOServer()
        {
            SCConnectionStringBuilder ConnectionString = new SCConnectionStringBuilder();
            ConnectionString.Authenticate = true;
            ConnectionString.IsPrimaryLogin = true;
            ConnectionString.Integrated = true;
            ConnectionString.Host = "localhost";
            ConnectionString.Port = 5555;

            SourceCode.SmartObjects.Client.SmartObjectClientServer SmoClient = new SourceCode.SmartObjects.Client.SmartObjectClientServer();
            SmoClient.CreateConnection();
            SmoClient.Connection.Open(ConnectionString.ConnectionString);

            return SmoClient;
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
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

            

            SmartObjectExplorer smoExp = Server.GetSmartObjects(FrameworkSmartObjects.Keys.ToArray());
            foreach (SmartObjectInfo smo in smoExp.SmartObjectList)
            {
                Server.DeleteSmartObject(smo.Guid, true);
            }

            MessageBox.Show("Framework Assets Deleted");
        }

        
        Guid AppTypeId = new Guid();

        Guid DefaultKPI = new Guid();
        Guid DefaultPriority = new Guid();
        Guid DefaultStage = new Guid();
        Guid DefaultStatus = new Guid();

        private void btnCreateAppType_Click(object sender, RoutedEventArgs e)
        {
            //          //<image><name>Case_Stage_Completed16.png</name><content>iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyBpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMC1jMDYwIDYxLjEzNDc3NywgMjAxMC8wMi8xMi0xNzozMjowMCAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzIiB4bXBNTTpJbnN0YW5jZUlEPSJ4bXAuaWlkOjZCMDY5QjBGNDQ4MzExRTRCQTRBQTJBMTM4MzNGQUQ0IiB4bXBNTTpEb2N1bWVudElEPSJ4bXAuZGlkOjZCMDY5QjEwNDQ4MzExRTRCQTRBQTJBMTM4MzNGQUQ0Ij4gPHhtcE1NOkRlcml2ZWRGcm9tIHN0UmVmOmluc3RhbmNlSUQ9InhtcC5paWQ6NkIwNjlCMEQ0NDgzMTFFNEJBNEFBMkExMzgzM0ZBRDQiIHN0UmVmOmRvY3VtZW50SUQ9InhtcC5kaWQ6NkIwNjlCMEU0NDgzMTFFNEJBNEFBMkExMzgzM0ZBRDQiLz4gPC9yZGY6RGVzY3JpcHRpb24+IDwvcmRmOlJERj4gPC94OnhtcG1ldGE+IDw/eHBhY2tldCBlbmQ9InIiPz4W5wZOAAAA3UlEQVR42mL8//8/AyWAkSoGMDIyEqV4xSq9+UAqAYg/AHFheOjFBUzE2gTU3ADVDAICQAwyjIGJSM0OQKoemxwTEZrhtqGBCcS6AKRZAU3sQkTYpUIQgwXJfzAnLgBKJkLFC4BUAJpmUAAmosTCytX66HHZCMQbgPg8FhclAi1YAGKA9OLyAsg167GIL4BpRg/ECVgUo/v7ASjucSYkoH9BzjXAE5iGQNsvIAuge8ERags2UIiuGWtSBroC5IL90JQGAxuAmgOxacYIRKgthdCoAsc3cpTRJDcCBBgAcuFX2OyO/l8AAAAASUVORK5CYII=</content></image>
            //"<image><name>Quote to Cash.png</name><content>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</content></image>";

            SourceCode.SmartObjects.Client.SmartObject smoTypeImage = Client.GetSmartObject("K2App_Core_SMO_AppImage");
            //smoType.Properties["ID"].Value = "{76AD4E2C-D505-4724-BE20-FE30F0494267}";
            smoTypeImage.Properties["Name"].Value = "Case Stage Completed";
            smoTypeImage.Properties["Image"].Value = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyBpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMC1jMDYwIDYxLjEzNDc3NywgMjAxMC8wMi8xMi0xNzozMjowMCAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzIiB4bXBNTTpJbnN0YW5jZUlEPSJ4bXAuaWlkOjZCMDY5QjBGNDQ4MzExRTRCQTRBQTJBMTM4MzNGQUQ0IiB4bXBNTTpEb2N1bWVudElEPSJ4bXAuZGlkOjZCMDY5QjEwNDQ4MzExRTRCQTRBQTJBMTM4MzNGQUQ0Ij4gPHhtcE1NOkRlcml2ZWRGcm9tIHN0UmVmOmluc3RhbmNlSUQ9InhtcC5paWQ6NkIwNjlCMEQ0NDgzMTFFNEJBNEFBMkExMzgzM0ZBRDQiIHN0UmVmOmRvY3VtZW50SUQ9InhtcC5kaWQ6NkIwNjlCMEU0NDgzMTFFNEJBNEFBMkExMzgzM0ZBRDQiLz4gPC9yZGY6RGVzY3JpcHRpb24+IDwvcmRmOlJERj4gPC94OnhtcG1ldGE+IDw/eHBhY2tldCBlbmQ9InIiPz4W5wZOAAAA3UlEQVR42mL8//8/AyWAkSoGMDIyEqV4xSq9+UAqAYg/AHFheOjFBUzE2gTU3ADVDAICQAwyjIGJSM0OQKoemxwTEZrhtqGBCcS6AKRZAU3sQkTYpUIQgwXJfzAnLgBKJkLFC4BUAJpmUAAmosTCytX66HHZCMQbgPg8FhclAi1YAGKA9OLyAsg167GIL4BpRg/ECVgUo/v7ASjucSYkoH9BzjXAE5iGQNsvIAuge8ERags2UIiuGWtSBroC5IL90JQGAxuAmgOxacYIRKgthdCoAsc3cpTRJDcCBBgAcuFX2OyO/l8AAAAASUVORK5CYII=";

            smoTypeImage.MethodToExecute = "Create";

            var smoTypeImageResult = Client.ExecuteScalar(smoTypeImage);
            Guid AppTypeImageId = Guid.Parse(smoTypeImageResult.Properties["ID"].Value);


            SourceCode.SmartObjects.Client.SmartObject smoType = Client.GetSmartObject(new Guid("5a82e2fc-cd5b-4346-b508-d01095a51de3"));
            //smoType.Properties["ID"].Value = "{76AD4E2C-D505-4724-BE20-FE30F0494267}";
            smoType.Properties["Name"].Value = "Client Onboarding";
            smoType.Properties["Description"].Value = "Client Onboarding";
            smoType.Properties["Prefix"].Value = "CO";
            smoType.Properties["Icon_ID"].Value = AppTypeImageId.ToString();
            smoType.Properties["Description"].Value = "Client Onboarding";

            smoType.Properties["Default_KPI_Id"].Value = "0B6F78F5-B18F-4FFF-808C-DA74F0BD4387";
            smoType.Properties["Default_Priority_Id"].Value = "C5A810F5-95AC-4FDC-8C30-9EB8C790E530";

            
            smoType.Properties["Created_On"].Value = DateTime.Now.ToString();
            smoType.Properties["Created_By"].Value = "denallix\\administrator";
            smoType.Properties["Modified_On"].Value = DateTime.Now.ToString();
            smoType.Properties["Modified_By"].Value = "denallix\\administrator";

            smoType.Properties["Start_Form"].Value = "CSR+-+New+Request";
            smoType.Properties["Update_Form"].Value = "CSR+-+New+Request";
            smoType.Properties["View_Form"].Value = "CSR+-+New+Request";
            smoType.Properties["Management_Form"].Value = "CSR+-+Request+List";

            smoType.Properties["Expected_Duration_Minutes"].Value = "600";

            smoType.Properties["Is_Active"].Value = "true";
            smoType.Properties["Is_Deleted"].Value = "false";
            smoType.Properties["Sort_Order"].Value = "0";

            smoType.MethodToExecute = "Create";

            var smoTypeResult = Client.ExecuteScalar(smoType);
            AppTypeId = Guid.Parse(smoTypeResult.Properties["ID"].Value);

            CreateTypeActions("1C4B0B36-DAC8-44D3-892F-737291FD3EA4", AppTypeId.ToString(), "App_Type_ID");

            MessageBox.Show("Case Type Create");
        }

        private void btnCreateKPIPriority_Click(object sender, RoutedEventArgs e)
        {
            /* 
 * Client Onboarding
 * 
 */


            // App Priority
            Dictionary<Guid, string> Priority = new Dictionary<Guid, string>();
            Priority.Add(Guid.Parse("{AFD4EE8C-ABD4-4EA2-B2A8-A72AD492E141}"), "Low");
            Priority.Add(Guid.Parse("{C5A810F5-95AC-4FDC-8C30-9EB8C790E530}"), "Normal");
            Priority.Add(Guid.Parse("{9C5C7932-B9C7-4ACB-99DA-9BCFC28A7262}"), "High");
            Priority.Add(Guid.Parse("{5F9853DE-B0C0-45BC-B93F-E0F966DDD65D}"), "Critical");
            int i = 0;
            foreach (var p in Priority)
            {

                SourceCode.SmartObjects.Client.SmartObject smoPriority = Client.GetSmartObject(new Guid("74c9793e-e9cc-44b7-8f03-465b40abe117"));

                smoPriority.Properties["ID"].Value = p.Key.ToString();
                smoPriority.Properties["Name"].Value = p.Value;
                smoPriority.Properties["Description"].Value = p.Value;
                smoPriority.Properties["Sort_Order"].Value = i.ToString();

                smoPriority.MethodToExecute = "Create";

                SourceCode.SmartObjects.Client.SmartObject result = Client.ExecuteScalar(smoPriority);

                if (p.Value.Equals("Normal"))
                {
                    DefaultPriority = Guid.Parse(result.Properties["ID"].Value);
                }
                i++;
            }



            // App KPI
            Dictionary<Guid, string> KPI = new Dictionary<Guid, string>();
            KPI.Add(Guid.Parse("{A8BB6A38-7766-4584-ABC5-A4DBCD16EE67}"), "Low");
            KPI.Add(Guid.Parse("{0B6F78F5-B18F-4FFF-808C-DA74F0BD4387}"), "Normal");
            KPI.Add(Guid.Parse("{B3B8E274-4BBD-4415-B770-9F46450D50D5}"), "High");
            KPI.Add(Guid.Parse("{41059520-DF45-4832-A9BF-7514306AB6AD}"), "Critical");
            i = 0;

            foreach (var p in KPI)
            {
                SourceCode.SmartObjects.Client.SmartObject smoPriority = Client.GetSmartObject(new Guid("c501ff73-20ef-44ac-a5fe-9e35fc92df79"));

                smoPriority.Properties["ID"].Value = p.Key.ToString();
                smoPriority.Properties["Name"].Value = p.Value;
                smoPriority.Properties["Description"].Value = p.Value;
                smoPriority.Properties["Sort_Order"].Value = i.ToString();

                smoPriority.MethodToExecute = "Create";

                SourceCode.SmartObjects.Client.SmartObject result = Client.ExecuteScalar(smoPriority);

                if (p.Value.Equals("Normal"))
                {
                    DefaultKPI = Guid.Parse(result.Properties["ID"].Value);
                }
                i++;
            }

            MessageBox.Show("Priorities and KPIs created");
        }

        private void btnCreateStages_Click(object sender, RoutedEventArgs e)
        {

            List<string> Stages = new List<string>()
            {
                "Draft",
                "Submission",
                "Review",
                "Legal Review",
                "Onboarding",
                "Complete",
                "Cancelled"
            };

            for (int i = 0; i < Stages.Count;i++ )
            {
                SourceCode.SmartObjects.Client.SmartObject smoStage = Client.GetSmartObject(new Guid("6d8facc6-40da-4a74-b8cc-f9bec1b9cc25"));

                smoStage.Properties["Name"].Value = Stages[i];
                smoStage.Properties["Description"].Value = Stages[i];
                smoStage.Properties["Sort_Order"].Value = Stages[i];
                smoStage.Properties["Created_On"].Value = DateTime.Now.ToString();
                smoStage.Properties["Created_By"].Value = "denallix\\administrator";
                smoStage.Properties["Modified_On"].Value = DateTime.Now.ToString();
                smoStage.Properties["Modified_By"].Value = "denallix\\administrator";
                smoStage.Properties["Is_Active"].Value = "true";
                smoStage.Properties["Is_Deleted"].Value = "false";
                smoStage.Properties["Sort_Order"].Value = i.ToString();

                smoStage.Properties["App_Type_ID"].Value = AppTypeId.ToString();

                smoStage.MethodToExecute = "Create";

                SourceCode.SmartObjects.Client.SmartObject result = Client.ExecuteScalar(smoStage);

                CreateTypeActions("e9de772e-3ab7-417a-b07d-3acf862fbddd", result.Properties["ID"].Value.ToString(), "App_Stage_ID");

                if (Stages[i].Equals("Draft"))
                {
                    DefaultStage = Guid.Parse(result.Properties["ID"].Value);
                }

                result = null;
                smoStage = null;
            }
            MessageBox.Show("Stages created");
        }
        
        public void CreateTypeActions(string actionsmoid, string typeid, string typeidname)
        {
            
            Dictionary<string, string> StageActions = new Dictionary<string, string>();
            StageActions.Add("Assign Task", "cm.task__create.form");
            StageActions.Add("Send Message", "cm.sendmessage.form");
            StageActions.Add("Log Conversation", "cm.logconversation.form");
            StageActions.Add("Attach Document", "cm.logconversation.form");
            StageActions.Add("Edit Priority", "cm.logconversation.form");

            for (int i = 0; i < StageActions.Count; i++)
            {
                SourceCode.SmartObjects.Client.SmartObject smoTypAction = Client.GetSmartObject(new Guid(actionsmoid));

                smoTypAction.Properties["Name"].Value = StageActions.ElementAt(i).Key;
                smoTypAction.Properties["Description"].Value = StageActions.ElementAt(i).Key;
                smoTypAction.Properties["Sort_Order"].Value = StageActions.ElementAt(i).Key;
                smoTypAction.Properties["Action_Form"].Value = StageActions.ElementAt(i).Value;
                smoTypAction.Properties["Is_Important"].Value = "false";
                smoTypAction.Properties["Created_On"].Value = DateTime.Now.ToString();
                smoTypAction.Properties["Created_By"].Value = "denallix\\administrator";
                smoTypAction.Properties["Modified_On"].Value = DateTime.Now.ToString();
                smoTypAction.Properties["Modified_By"].Value = "denallix\\administrator";
                smoTypAction.Properties["Is_Active"].Value = "true";
                smoTypAction.Properties["Is_Deleted"].Value = "false";
                smoTypAction.Properties["Sort_Order"].Value = i.ToString();

                smoTypAction.Properties[typeidname].Value = typeid;

                smoTypAction.MethodToExecute = "Create";

                SourceCode.SmartObjects.Client.SmartObject result = Client.ExecuteScalar(smoTypAction);
            }
            
        }

        private void btnCreateStatus_Click(object sender, RoutedEventArgs e)
        {
            List<string> Status = new List<string>()
            {
                "Pending",
                "Active",
                "Active - Under Review",
                "Completed - Onboarded",
                "Cancelled"
            };

            for (int i = 0; i < Status.Count; i++)
            {
                SourceCode.SmartObjects.Client.SmartObject smoStatus = Client.GetSmartObject(new Guid("7d89eee6-cda0-4e74-b47c-296acd4959a7"));

                smoStatus.Properties["Name"].Value = Status[i];
                smoStatus.Properties["Description"].Value = Status[i];
                smoStatus.Properties["Sort_Order"].Value = Status[i];
                smoStatus.Properties["Created_On"].Value = DateTime.Now.ToString();
                smoStatus.Properties["Created_By"].Value = "denallix\\administrator";
                smoStatus.Properties["Modified_On"].Value = DateTime.Now.ToString();
                smoStatus.Properties["Modified_By"].Value = "denallix\\administrator";
                smoStatus.Properties["Is_Active"].Value = "true";
                smoStatus.Properties["Is_Deleted"].Value = "false";
                smoStatus.Properties["Sort_Order"].Value = i.ToString();

                smoStatus.Properties["App_Type_ID"].Value = AppTypeId.ToString();

                smoStatus.MethodToExecute = "Create";

                SourceCode.SmartObjects.Client.SmartObject result = Client.ExecuteScalar(smoStatus);
               
                if (Status[i].Equals("Pending"))
                {
                    DefaultStatus = Guid.Parse(result.Properties["ID"].Value);
                }

                result = null;
                smoStatus = null;
            }

            MessageBox.Show("Statuses created");
        }

        private void btnUpdateCaseType_Click(object sender, RoutedEventArgs e)
        {
            SourceCode.SmartObjects.Client.SmartObject smoType = Client.GetSmartObject(new Guid("5a82e2fc-cd5b-4346-b508-d01095a51de3"));
            smoType.Properties["ID"].Value = AppTypeId.ToString();
            smoType.Properties["Default_Status_ID"].Value = DefaultStatus.ToString();
            smoType.Properties["Default_Stage_ID"].Value = DefaultStage.ToString();
            smoType.MethodToExecute = "Save";

            var att = Client.ExecuteScalar(smoType);
            att.MethodToExecute = "Load";

            var at = Client.ExecuteScalar(att);


            SourceCode.SmartObjects.Client.SmartObject smoAppInstance = Client.GetSmartObject("K2App_Core_SMO_AppInstance");
            smoAppInstance.Properties["ID"].Value = "{D273104D-79E6-4D02-835D-E53C3D617FA6}";
            smoAppInstance.Properties["App_Type_ID"].Value = AppTypeId.ToString();
            smoAppInstance.Properties["App_Type"].Value = smoType.Properties["Name"].Value.ToString();
            smoAppInstance.Properties["Name"].Value = "Demo App Instance";
            smoAppInstance.Properties["Description"].Value = "Something happened";
            smoAppInstance.Properties["Reference"].Value = "x00001";
            smoAppInstance.Properties["Due_Date"].Value = DateTime.Now.ToString();
            smoAppInstance.Properties["Expected_Duration_Minutes"].Value = "60000";

            smoAppInstance.Properties["Status_ID"].Value = DefaultStatus.ToString();
            smoAppInstance.Properties["Status"].Value = DefaultStatus.ToString();
            smoAppInstance.Properties["Stage_ID"].Value = DefaultStage.ToString();
            smoAppInstance.Properties["Stage"].Value = DefaultStage.ToString();

            smoAppInstance.Properties["Priority_ID"].Value = DefaultPriority.ToString();
            smoAppInstance.Properties["Priority"].Value = DefaultPriority.ToString();

            smoAppInstance.Properties["KPI_ID"].Value = DefaultKPI.ToString();
            smoAppInstance.Properties["KPI"].Value = DefaultKPI.ToString();

            smoAppInstance.Properties["Owner"].Value = "Jonathan King";
            smoAppInstance.Properties["Owner_FQN"].Value = @"denallix\jonno";

            smoAppInstance.Properties["Created_On"].Value = DateTime.Now.ToString();
            smoAppInstance.Properties["Created_By"].Value = @"denallix\jonno";

            smoAppInstance.Properties["Is_Active"].Value = "true";

            smoAppInstance.MethodToExecute = "Create";
            Client.ExecuteScalar(smoAppInstance);

            MessageBox.Show("Case Type updated");
        }

    }
}
