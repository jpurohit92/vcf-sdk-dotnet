# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsUpgradesProgress
The Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.Progress schema contains detailed information about the Supervisor upgrade progress.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **long** | Total amount of the work for the operation. The work here represents the number of master nodes in the Supervisor need to be upgraded.  This property was added in __vSphere API 9.1.0.0__. | 
**Completed** | **long** | Current progress of the upgrade operation, represented as a percentage of completion.  This property was added in __vSphere API 9.1.0.0__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Message about the work progress.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

