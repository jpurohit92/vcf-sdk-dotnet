# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSummaryListItem
The Vcenter.NamespaceManagement.Supervisors.Summary.ListItem schema contains information about a Supervisor returned by *GET /vcenter/namespace-management/supervisors/summaries* operation  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Supervisor** | **string** | The immutable identifier of the Supervisor generated during enablement.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. | 
**Info** | [**VcenterNamespaceManagementSupervisorsSummaryInfo**](VcenterNamespaceManagementSupervisorsSummaryInfo.md) | The current state of the Supervisor.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

