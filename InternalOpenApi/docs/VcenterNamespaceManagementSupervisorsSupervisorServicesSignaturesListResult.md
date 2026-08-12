# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesListResult
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.ListResult contains signature verification details of a Supervisor Service across multiple Supervisors.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Signatures** | [**List&lt;VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesSummary&gt;**](VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesSummary.md) | A list of signature details for the service version, one entry per Supervisor. Each entry aggregates the status of all image package bundles referenced by the service version on that Supervisor.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

