# Vcenter.ViJson.OpenApi.Model.VStorageObjectReconcileResultReconcileDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostName** | **string** | Host name where reconcile operation was performed.  This will have the either VC name or the host name based on where the details were captured. In case we do not get the hostName for the system it would be empty string.  | [optional] 
**ReconcileReportPath** | **string** | Reconcile report path in host.  | [optional] 
**IsReconciled** | **bool** | Set to true if reconcile was done from host, false otherwise for host.  This will be unset for the vcenter part of result.  | [optional] 
**IsDeepScanned** | **bool** | If deepScan was done from host, false otherwise for host.  This will be unset for vcenter part of result.  | [optional] 
**NumberOfReconcileIssues** | **int** | Number of reconcile issues found  | [optional] 
**NumberOfFcdsBeforeReconcile** | **int** | Number of fcds before reconcile operation This will be unset for vcenter part of result.  | [optional] 
**NumberOfFcdsAfterReconcile** | **int** | Number of fcds after reconcile operation.  This will be unset for vcenter part of result.  | [optional] 
**InvalidDiskPaths** | [**List&lt;VStorageObjectReconcileResultInvalidDiskPath&gt;**](VStorageObjectReconcileResultInvalidDiskPath.md) | reconcile invalid disk paths  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

