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

            string DeploymentCategory = @"New App Framework\SmartObjects";

            SmartObjectDefinitionsPublish smoPublish = new SmartObjectDefinitionsPublish();
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdAudit = CreateSmartBoxSmartObject(Server, (new AppBusinessAudit().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdAudit);


            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdException = CreateSmartBoxSmartObject(Server, (new AppException().GetDefinition()), DeploymentCategory);           
            smoPublish.SmartObjects.Add(sdException);

            
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdInstance = CreateSmartBoxSmartObject(Server, (new AppInstance().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdInstance);


            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdKPI = CreateSmartBoxSmartObject(Server, (new AppKPI().GetDefinition()), DeploymentCategory);
            smoPublish.SmartObjects.Add(sdKPI);

            
            SourceCode.SmartObjects.Authoring.SmartObjectDefinition sdPriority = CreateSmartBoxSmartObject(Server, (new AppPriority().GetDefinition()), DeploymentCategory);
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

            SourceCode.SmartObjects.Client.SmartObject smoType = Client.GetSmartObject(new Guid("5a82e2fc-cd5b-4346-b508-d01095a51de3"));
            //smoType.Properties["ID"].Value = "{76AD4E2C-D505-4724-BE20-FE30F0494267}";
            smoType.Properties["Name"].Value = "Client Onboarding";
            smoType.Properties["Description"].Value = "Client Onboarding";
            smoType.Properties["Prefix"].Value = "CO";
            //smoType.Properties["Icon"].Value = "Client Onboarding";
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

            Client.ExecuteScalar(smoType);

            MessageBox.Show("Case Type updated");

        }

    }
}
