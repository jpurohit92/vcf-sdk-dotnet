# Vcenter.ViJson.OpenApi.Model.VsanPerfsvcHealthResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatsObjectInfo** | [**VsanObjectInformation**](VsanObjectInformation.md) | This is vSAN stats object information.  | [optional] 
**StatsObjectConsistent** | **bool** | This is vSAN stats object consistency check value.  | [optional] 
**StatsObjectPolicyConsistent** | **bool** | This is vSAN stats object policy consistency check value.  | [optional] 
**DatastoreCompatible** | **bool** | This value indicate that if the vSAN datastore is compatible with the configuration policy.  | [optional] 
**EnoughFreeSpace** | **bool** | This value indicate that if the vSAN datastore has enough free space to enable vsan performance service.  | [optional] 
**RemediateAction** | **string** | vSAN performance service remediation action.  See also *VsanPerfsvcRemediateAction_enum*.  | [optional] 
**HostResults** | [**List&lt;VsanPerfNodeInformation&gt;**](VsanPerfNodeInformation.md) | This is list of hosts&#39; performance service information.  See also *VsanPerfNodeInformation*.  | [optional] 
**VerboseModeStatus** | **bool** | This value indicate that if the vSAN performance service verbose mode is enable or not.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

